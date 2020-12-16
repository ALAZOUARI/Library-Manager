using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Librarymanagement.Models.Repositories
{
    public class SQLBookRepository : IBookRepository
    {
        private readonly BookDbContext bookDbContext; 

        public SQLBookRepository(BookDbContext bookDbContext)
        {
            this.bookDbContext = bookDbContext; 
        }
        public Book Add(Book book)
        {
            bookDbContext.Books.Add(book);
            bookDbContext.SaveChanges();
            return book; 
        }

        public Book Delete(int Id)
        {
            Book book = bookDbContext.Books.Find(Id);
            if (book != null)
            {
                bookDbContext.Books.Remove(book);
                bookDbContext.SaveChanges();
            }
            return book;
        }

        public IEnumerable<Book> GetAllBook()
        {
            return bookDbContext.Books; 
        }

        public Book GetBook(int Id)
        {
            return bookDbContext.Books.Find(Id); 
        }

        public Book Update(Book bookChanges)
        {
            var book = bookDbContext.Books.Attach(bookChanges);
            book.State = EntityState.Modified;
            bookDbContext.SaveChanges();
            return bookChanges; 
        }
    }
}
