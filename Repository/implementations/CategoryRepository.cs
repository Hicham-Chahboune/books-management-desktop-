using ENSAS_Book.ModelsDB;
using ENSAS_Book.Repository.interfaces;

namespace BookStore.Repository.Implementations
{
    public class CategoryRepository : Repository<Category> , ICategoryRepository
    {
        public CategoryRepository(ENSAS_BooksContext context) : base(context)
        {

        }
    }
}
