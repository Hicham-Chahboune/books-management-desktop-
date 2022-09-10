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
   
    public partial class StatisticsForm : UserControl
    {
        

        public StatisticsForm()
        {
            InitializeComponent();
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            using (UnitOfWork uow = new UnitOfWork(new ENSAS_BooksContext()))
            {
                dgvBooksByAuthor.DataSource = uow.Books.BookByAuthor();
                dgvBooksByAuthor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                dgvBooksByAuthor.RowHeadersVisible = false;
                dgvBooksByAuthor.Columns[0].Width = 300;
                dgvBooksByAuthor.Columns[1].Width = 200;



                dgvBooksByCategorie.DataSource = uow.Books.BookByCategory();
                dgvBooksByCategorie.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                dgvBooksByCategorie.RowHeadersVisible = false;
                dgvBooksByCategorie.Columns[0].Width = 300;
                dgvBooksByCategorie.Columns[1].Width = 200;
            }
        }
    }
}
