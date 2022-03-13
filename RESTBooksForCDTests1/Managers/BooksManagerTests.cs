using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using RESTBooksForCD.Models;

namespace RESTBooksForCD.Managers.Tests
{
    [TestClass]
    public class BooksManagerTests
    {
        [TestMethod]
        public void GetAllTest()
        {
            BooksManager manager = new BooksManager();
            List<Book> allBooks = manager.GetAll();
            Assert.AreEqual(2, allBooks.Count);

            Book book = manager.GetById(1);
            Assert.AreEqual("Android Programming", book.Title);

            Assert.IsNull(manager.GetById(-1));
        }

        [TestMethod]
        public void AddTest()
        {
            //Assert.Fail();
        }
    }
}