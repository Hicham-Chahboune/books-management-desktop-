using BookStore.Repository.Implementations;
using ENSAS_Book.ModelsDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ENSAS_Book
{
   
    public partial class AuthorForm : UserControl
    {
        //id Author for updating and saving
        private Guid IDAUTHOR;

        public AuthorForm()
        {
            InitializeComponent();
        }
        private void loadData(UnitOfWork uow) {
            dgvAuthors.DataSource = uow.Authors.Find(null, "Books").Select(p => new
            {
                p.IdAuthor,
                p.Name,
                p.Email,
                p.Gender,
                Books = p.Books.Count()

            }).ToList();

        }
        private void btnSaveAuthor_Click(object sender, EventArgs e)
        {
            using (UnitOfWork uow = new UnitOfWork(new ENSAS_BooksContext()))
            {
                Author author = new Author()
                {
                    Name = txtName.Text,
                    Email = txtEmail.Text,
                    Gender = txtGenderM.Checked==true ? txtGenderM.Text : txtGenderF.Text
                };
                uow.Authors.Add(author);
                int res = uow.Complete();
                if (res > 0)
                {
                    // MessageBox.Show("Author created successfully ID : " + author.IdAuthor, "Info Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData(uow);
                    txtName.Text = "";
                       txtEmail.Text = "";
                        txtName.Focus();
                        txtGenderM.Select();
                        txtNbAuthors.Text = dgvAuthors.RowCount.ToString();
                    
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AuthorForm_Load(object sender, EventArgs e)
        {
            using (UnitOfWork uow=new UnitOfWork(new ENSAS_BooksContext()))
            {
                loadData(uow);
            }
            dgvAuthors.Columns["IdAuthor"].Visible = false;
            dgvAuthors.Columns["Name"].Width = 250;
            dgvAuthors.Columns["Email"].Width = 300;
            dgvAuthors.Columns["Gender"].Width = 100;
            dgvAuthors.Columns["Books"].Width = 100;
            dgvAuthors.RowTemplate.Height = 30;
            dgvAuthors.RowHeadersVisible = false;
            //Shared.AddColumnIcon(dgvAuthors, "Print", "print");
            Shared.AddColumnIcon(dgvAuthors, "Delete", "remove");

            txtNbAuthors.Text = dgvAuthors.RowCount.ToString();
            btnUpdateAuthor.Visible = false;

        }

        private void dgvAuthors_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1)
            {
                //get column name
                string colName = dgvAuthors.Columns[e.ColumnIndex].Name;
                if(colName!="Delete" && colName != "Print")
                {
                    dgvAuthors.Cursor = Cursors.Default;
                }
                else
                {
                    dgvAuthors.Cursor = Cursors.Hand;
                }
            }

        }

        //Delete Author
        private void dgvAuthors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Select Current row
            DataGridViewRow Current = dgvAuthors.Rows[e.RowIndex];
            Current.Selected = true;

            //get column name
            string colName = dgvAuthors.Columns[e.ColumnIndex].Name;
            if (colName == "Delete")
            {
                //Get id Author for removing Author
                Guid idAuthor =Guid.Parse( dgvAuthors.Rows[e.RowIndex].Cells["IdAuthor"].Value.ToString());
                bool confirm = Shared.ConfirmDelete("do you delete this Author ?");
                if (confirm)
                {
                    using (UnitOfWork uow = new UnitOfWork(new ENSAS_BooksContext()))
                    {
                        Author author = uow.Authors.Get(idAuthor);
                        uow.Authors.Remove(author);
                        uow.Complete();
                        loadData(uow);
                        txtNbAuthors.Text = dgvAuthors.RowCount.ToString();


                    }
                }
                
                
            }

        }

        private void dgvAuthors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                IDAUTHOR =Guid.Parse( dgvAuthors.Rows[e.RowIndex].Cells["IdAuthor"].Value.ToString());
                using (UnitOfWork uow=new UnitOfWork(new ENSAS_BooksContext()))
                {
                    Author author = uow.Authors.Get(IDAUTHOR);
                    //Get data from database
                    txtName.Text = author.Name;
                    txtEmail.Text = author.Email;
                    txtGenderM.Checked=(author.Gender=="M")?true:false;
                    txtGenderF.Checked=(author.Gender=="F")?true:false;
                    btnSaveAuthor.Enabled = false;
                    btnUpdateAuthor.Visible = true;
                }
            }
        }

        private void btnUpdateAuthor_Click(object sender, EventArgs e)
        {
            using (UnitOfWork uow = new UnitOfWork(new ENSAS_BooksContext()))
            {
                Author author = uow.Authors.Get(IDAUTHOR);
                //Get data from database
                  author.Name= txtName.Text;
                 author.Email= txtEmail.Text;
                author.Gender = txtGenderM.Checked == true ? txtGenderM.Text : txtGenderF.Text;
                uow.Complete();
                loadData(uow);

                btnUpdateAuthor.Visible = false;
            }

        }
    }
}
