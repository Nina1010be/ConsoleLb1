using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLb1
{
    [TestFixture]
    public class TestBooks
    {
        BookMain book;
        BookLibraryModel bookModel;

        [SetUp]
        public void InitTest()
        {
            book = new BookMain();
            bookModel = new BookLibraryModel();

            List<BookLibraryModel> books = new List<BookLibraryModel>();

            bookModel.id = 1;
            bookModel.BookName = "Марсианские хроники";
            bookModel.AuthorName = "Бредбери";
            bookModel.Date = "1934.02.10";
            bookModel.Description = "Описание";

            books.Add(bookModel);
            bookModel = new BookLibraryModel();


            bookModel.id = 2;
            bookModel.BookName = "Отныне и во век";
            bookModel.AuthorName = "Бредбери";
            bookModel.Date = "1967.02.10";
            bookModel.Description = "Описание";

            books.Add(bookModel);
            book.Init(books);
        }
        [Test]
        public void TestAdd()
        {
            bookModel = new BookLibraryModel()
            {
                BookName = "Отныне и во век",
                AuthorName = "Бредбери",
                Date = "1967.02.10",
                Description = "Описание",
            };

            Assert.IsNull(book.GetBook(bookModel.id));
            book.AddBook(bookModel);
            Assert.IsNotNull(book.GetBook(bookModel.id));

            var findedEmployee = book.books.Find(e => e.id == bookModel.id);

            Assert.IsNotNull(findedEmployee);
            findedEmployee = book.books.Find(e => e.id == bookModel.id);

            Assert.IsNotNull(findedEmployee);
            findedEmployee = book.books.Find(e => e.id == bookModel.id);

            Assert.IsNotNull(findedEmployee);
        }
        [Test]
        public void TestDelete()
        {
            var isRemoved = book.DeleteBook(1);

            Assert.IsNull(book.GetBook(1));

            Assert.IsTrue(isRemoved);
        }
    }

}
