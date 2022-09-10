using BookStore.Repository.Implementations;
using ENSAS_Book.forms;
using ENSAS_Book.ModelsDB;
using ENSAS_Book.ModelsHelpers;
using LinqKit;
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

    public partial class BooksForm : UserControl
    {

        private int TotalPages = 0;
        private Page page;
       // private IEnumerable<BookViewModel> listbooks;
        public BooksForm()
        {
            InitializeComponent();
            //int nbElemByPage = Convert.ToInt32(ConfigurationManager.AppSettings["nbElemByPage"]);              
            page = new Page() { PageIndex = 1, PageSize = 5 };
        }

        public void LoadData()
        {
            //Get Books from DB
            var predicate = PredicateBuilder.New<Book>(true);

            string title = txtTitleSearch.Text.ToLower();
            string category = txtCategorySearch.Text.ToLower();
            Author author = (Author)txtAuthorSearch.SelectedItem;
            Guid idAuthor = (author == null) ? Guid.Empty : author.IdAuthor;

            if (!String.IsNullOrEmpty(title))
                predicate = predicate.And(b => b.Title.ToLower().Contains(title));

            if (!String.IsNullOrEmpty(category))
                predicate = predicate.And(b => b.Category.Categ.ToLower().Contains(category));

            if (idAuthor != Guid.Empty)
                predicate = predicate.And(b => b.IdAuthor == idAuthor);
            using (UnitOfWork uow = new UnitOfWork(new ENSAS_BooksContext()))
            {
                var list = uow.Books.Find(predicate, "Author,Category", page).Select(p => new
                {
                    p.IdBook,
                    p.Title,
                    Descreption = p.DescBook,
                    p.Price,
                    p.NbPages,
                    Published = p.PublishedDate,
                    Categorie = p.Category.Categ,
                    Author = p.Author.Name

                }).ToList();
                dgvBooks.DataSource = list;
                txtNbBooks.Text = dgvBooks.RowCount.ToString();
            }
        }
        private void CalculateTotalPages(Page page)
        {
            using (UnitOfWork uow = new UnitOfWork(new ENSAS_BooksContext()))
            {
                TotalPages = (int)Math.Ceiling((double)uow.Books.GetAll().Count() / page.PageSize);
            }
        }
        private void BooksForm_Load(object sender, EventArgs e)
        {
            LoadData();
            CalculateTotalPages(page);
            btnFirst_Click(sender,e);
            CalculateTotalPages(page);

            dgvBooks.Columns["IdBook"].Visible = false;

            dgvBooks.Columns["Title"].Width = 120;
            dgvBooks.Columns["Descreption"].Width = 350;
            dgvBooks.Columns["Price"].Width = 100;
            dgvBooks.Columns["NbPages"].Width = 100;
            dgvBooks.Columns["Published"].Width = 120;
            dgvBooks.Columns["Categorie"].Width = 120;
            dgvBooks.Columns["Author"].Width = 100;
            dgvBooks.RowTemplate.Height = 30;
            dgvBooks.RowHeadersVisible = false; 

            Shared.AddColumnIcon(dgvBooks, "Edit", "edit");
            //Shared.AddColumnIcon(dgvBooks, "Print", "print");
            Shared.AddColumnIcon(dgvBooks, "Delete", "delete");

            txtAuthorSearch.Items.Add(new Author() { IdAuthor = Guid.Empty, Name = "-- All  Authors --" });
            using (UnitOfWork uow = new UnitOfWork(new ENSAS_BooksContext()))
            {
                foreach (var item in uow.Authors.GetAll())
                {
                    txtAuthorSearch.Items.Add(item);
                }
                txtAuthorSearch.ValueMember = "IdAuthor";
                txtAuthorSearch.DisplayMember = "Name";
                txtAuthorSearch.SelectedIndex = 0;
            }
        }

        private void dgvBooks_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1)
            {
                //get column name
                string colName = dgvBooks.Columns[e.ColumnIndex].Name;
                if (colName != "Delete" && colName != "Print" && colName != "Edit")
                {
                    dgvBooks.Cursor = Cursors.Default;
                }
                else
                {
                    dgvBooks.Cursor = Cursors.Hand;
                }
            }
        }

        //Delete Book
        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex!=-1 && e.RowIndex != -1)
            {
                //Select current row
                DataGridViewRow Current = dgvBooks.Rows[e.RowIndex];
                Current.Selected = true;
                string colName = dgvBooks.Columns[e.ColumnIndex].Name;
                Guid idBook = Guid.Parse(dgvBooks.Rows[e.RowIndex].Cells["IdBook"].Value.ToString());
                if (colName == "Delete")
                {
                    bool confirm = Shared.ConfirmDelete("do you delete this Book ?");
                    if (confirm)
                    {
                        using (UnitOfWork uow = new UnitOfWork(new ENSAS_BooksContext()))
                        {
                            Book book = uow.Books.Get(idBook);
                            uow.Books.Remove(book);
                            uow.Complete();
                            LoadData();

                        }
                    }
                }
                if (colName == "Edit")
                {
                    BookAddEditForm bookAddEditForm = new BookAddEditForm(this,idBook);
                    bookAddEditForm.ShowDialog();

                }
            }
           

        }

        private void btnNewBook_Click(object sender, EventArgs e)
        {
            BookAddEditForm bookAddEditForm = new BookAddEditForm(this);
            Form formlay = new Form();
            formlay.FormBorderStyle = FormBorderStyle.None;
            formlay.StartPosition = FormStartPosition.Manual;
            formlay.Opacity = .90d;
            formlay.BackColor = Color.Black;
            formlay.TopMost = false;
            formlay.ShowInTaskbar = false;
            formlay.WindowState = FormWindowState.Maximized;
            formlay.Show();
            bookAddEditForm.Owner = formlay;
            bookAddEditForm.ShowDialog();
            formlay.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            page.PageIndex = 1;
            txtCurrentPge.Text = $"Page {page.PageIndex} / {TotalPages}";
            LoadData();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (page.PageIndex > 1)
            {
                page.PageIndex--;
                txtCurrentPge.Text = $"Page {page.PageIndex} / {TotalPages}";
                LoadData();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (page.PageIndex < TotalPages)
            {
                page.PageIndex++;
                txtCurrentPge.Text = $"Page {page.PageIndex} / {TotalPages}";
                LoadData();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            page.PageIndex = TotalPages;
            txtCurrentPge.Text = $"Page {page.PageIndex} / {TotalPages}";
            LoadData();
        }
    }
}