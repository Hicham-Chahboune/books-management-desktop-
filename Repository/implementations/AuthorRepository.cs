
using ENSAS_Book.ModelsDB;
using ENSAS_Book.Repository.interfaces;
using System;
using System.Collections;

namespace BookStore.Repository.Implementations
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        public AuthorRepository(ENSAS_BooksContext context):base(context)
        {

        }
        public IEnumerable TopAuthor(int count)
        {
            throw new NotImplementedException();
        }
    }
}
