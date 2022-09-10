using ENSAS_Book.ModelsDB;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENSAS_Book.Repository.interfaces
{
    public interface IAuthorRepository:IRepository<Author>
    {
        IEnumerable TopAuthor(int count);
    }
}
