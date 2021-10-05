using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RESTBooksForCD.Models;

namespace RESTBooksForCD.Managers
{
    public class BooksManager
    {
        private static int _nextId = 1;

        private static readonly List<Book> Data = new List<Book>
        {
            new Book {Id = _nextId++, Title = "Android Programming"},
            new Book {Id=_nextId++, Title = "C# Development"}
        };

        public List<Book> GetAll()
        {
            return Data;
        }

        public Book GetById(int id)
        {
            return Data.FirstOrDefault(book => book.Id == id);
        }

    }
}
