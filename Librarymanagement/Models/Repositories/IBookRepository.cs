using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Librarymanagement.Models.Repositories
{
    interface IBookRepository
    {
        Book GetBook(int Id);
        IEnumerable<Book> GetAllBook();
        Book Add(Book book);
        Book Update(Book bookChanges);
        Book Delete(int Id);
    }
}
