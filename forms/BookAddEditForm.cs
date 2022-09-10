using BookStore.Repository.Implementations;
using ENSAS_Book.ModelsDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ENSAS_Book.forms
{
    public partial class BookAddEditForm : Form
    {
        private readonly BooksForm BOOKS_FORM;
        private readonly Guid ID_BOOK_EDIT;
        bool validTitle, validDescription, validPrice,validNbPages;
        public BookAddEditForm()
        {
            InitializeComponent();
        }

        public BookAddEditForm(BooksForm booksForm,[Optional]Guid idBookEdit)
        {
            InitializeComponent();
            this.BOOKS_FORM = booksForm;
            if (idBookEdit!=Guid.Empty) {
                this.ID_BOOK_EDIT = idBookEdit;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BookAddEditForm_Load(object sender, EventArgs e)
        {
            txtImageCover.Text = "";
            using (UnitOfWork uow = new UnitOfWork(new ENSAS_BooksContext()))
            {
                txtAuthor.DataSource = uow.Authors.GetAll();
                txtAuthor.ValueMember = "IdAuthor";
                txtAuthor.DisplayMember = "Name";
                txtCategorie.DataSource = uow.Categoriess.GetAll();
                txtCategorie.ValueMember = "IdCateg";
                txtCategorie.DisplayMember = "Categ";
                if (ID_BOOK_EDIT != Guid.Empty)
                {
                    txtTitleForm.Text = "Edit Book ";
                    btnCreateBook.Text = "Edit Book";
                    Book book = uow.Books.Get(ID_BOOK_EDIT);
                    txtTitle.Text = book.Title;
                    txtDescription.Text = book.DescBook;
                    txtPrice.Text = book.Price.ToString();
                    txtNbPages.Text = book.NbPages.ToString();
                    txtDatePublished.Value = book.PublishedDate.Value;
                    txtCategorie.SelectedItem = book.Category;
                    txtAuthor.SelectedItem = book.Author;
                    if (book.Cover != null)
                    {
                        MemoryStream memoryStream = new MemoryStream(book.Cover);
                        txtImageCover.Image = Image.FromStream(memoryStream);
                    }
                }
            }
        }

        private void btnUploadCover_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images |*.jpg; *.jpeg; *.png; *.bmp";
            ofd.Title = "Select Cover Book ";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtImageCover.Image = new Bitmap(ofd.FileName);
                txtImageCoverPath.Text = ofd.FileName;
            }
        }


        delegate void errorEvent(object sender, EventArgs e);
        private void btnCreateBook_Click(object sender, EventArgs e)
        {
            txtTitle_Validating(sender, e as CancelEventArgs);
            txtDescription_Validating(sender, e as CancelEventArgs);
            txtPrice_Validating(sender, e as CancelEventArgs);
            txtNbPages_Validating(sender, e as CancelEventArgs);
            


            using (UnitOfWork uow = new UnitOfWork(new ENSAS_BooksContext()))
            {
                string title = txtTitle.Text;
                string descBook = txtDescription.Text;
                DateTime publishedDate = txtDatePublished.Value.Date;
                double price = Convert.ToDouble(txtPrice.Text);
                int nbPages = Convert.ToInt32(txtNbPages.Text);
                Guid idAuthor = Guid.Parse(txtAuthor.SelectedValue.ToString());
                Guid idCateg = Guid.Parse(txtCategorie.SelectedValue.ToString());
                if (ID_BOOK_EDIT == Guid.Empty)
                {
                    Book book = new Book()
                    {

                        Title = title,
                        DescBook = descBook,
                        PublishedDate = publishedDate,
                        Price = price,
                        NbPages = nbPages,
                        IdAuthor = idAuthor,
                        IdCateg = idCateg,
                        Cover = (!String.IsNullOrEmpty(txtImageCoverPath.Text) ? Shared.ConvertToBinaryFromFile(txtImageCoverPath.Text) : null)

                    };
                    uow.Books.Add(book);

                }

                else
                {
                    Book book = uow.Books.Get(ID_BOOK_EDIT);
                    book.Title = title;
                    book.DescBook = descBook;
                    book.PublishedDate = publishedDate;
                    book.Price = price;
                    book.NbPages = nbPages;
                    book.IdAuthor = idAuthor;
                    book.IdCateg = idCateg;
                    book.Cover = (!String.IsNullOrEmpty(txtImageCoverPath.Text) ?Shared.ConvertToBinaryFromFile(txtImageCoverPath.Text) : book.Cover);
                }
                if (uow.Complete() > 0)
                {
                    this.Close();
                    BOOKS_FORM.LoadData();
                }

            };
        }

       

        private void txtImageCover_Click(object sender, EventArgs e)
        {

        }

       

        private void txtTitle_Validating(object sender, CancelEventArgs e)
        {
            validTitle = Shared.Validate(errorManagment, txtTitle, "Title is not valid",btnCreateBook);
        }
        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            validDescription = Shared.Validate(errorManagment, txtDescription, "Description is not valid", btnCreateBook);

        }
        private void txtPrice_Validating(object sender, CancelEventArgs e)
        {
            validPrice = Shared.Validate(errorManagment, txtPrice, "Price is not valid", btnCreateBook);

        }
        private void txtNbPages_Validating(object sender, CancelEventArgs e)
        {
            validNbPages = Shared.Validate(errorManagment, txtNbPages, "number of Pages is not valid", btnCreateBook);

        }
    }
    }

