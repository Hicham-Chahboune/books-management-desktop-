
using ENSAS_Book.ModelsDB;
using ENSAS_Book.Repository.interfaces;

namespace BookStore.Repository.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ENSAS_BooksContext _context;
        public IAuthorRepository Authors { get; private set; }

        public IBookRepository Books { get; private set; }

        public ICategoryRepository Categoriess { get; private set; }

        public UnitOfWork(ENSAS_BooksContext context)
        {
            _context = context;
            Authors = new AuthorRepository(_context);
            Books = new BookRepository(_context);
            Categoriess = new CategoryRepository(_context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
