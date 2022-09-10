using ENSAS_Book.ModelsDB;
using ENSAS_Book.Repository.interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Linq;

namespace BookStore.Repository.Implementations
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        public BookRepository(ENSAS_BooksContext context) : base(context)
        {

        }

        public ENSAS_BooksContext ENSAS_BooksContext { get => _context as ENSAS_BooksContext; }

        public IEnumerable BookByAuthor()
        {
            return ENSAS_BooksContext.Books.Include(a => a.Author)
                 .GroupBy(a => a.Author.Name)
                 .Select(grpAuthor => new { Author = grpAuthor.Key, Books = grpAuthor.Count() })
                 .OrderByDescending(a => a.Books)
                 .ToList();
        }

        public IEnumerable BookByCategory()
        {
            return ENSAS_BooksContext.Books.Include(a => a.Category)
             .GroupBy(a => a.Category.Categ)
             .Select(grpCateg => new { Category = grpCateg.Key, Books = grpCateg.Count() })
             .OrderByDescending(a => a.Books)
             .ToList();
        }
    }
}
