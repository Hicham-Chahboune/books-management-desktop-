using System;

namespace ENSAS_Book.Repository.interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IAuthorRepository Authors { get; }
        IBookRepository Books { get; }
        ICategoryRepository Categoriess { get; }
        int Complete();

    }
}
