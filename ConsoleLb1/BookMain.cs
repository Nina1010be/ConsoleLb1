using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLb1
{
    class BookMain
    {
        public List<BookLibraryModel> books = new List<BookLibraryModel>();

        public void Init(List<BookLibraryModel> books)
        {
            this.books = books;
        }
        public void AddBook(BookLibraryModel book)
        {
            book.id = 0;
            if (books.Count > 0)
            {
                book.id = books.Last().id + 1;
            }
            books.Add(book);
        }
        public bool DeleteBook(int id)
        {
            return books.Remove(GetBook(id));
        }
        public List<BookLibraryModel> GetAllBook()
        {
            return books;
        }
        public BookLibraryModel GetBook(int id)
        {
            return books.Find(e => e.id == id);
        }
        public IEnumerable<BookLibraryModel> GetAllBookByBookName(string name)
        {
            return books.Where(e => e.BookName == name);
        }
        public IEnumerable<BookLibraryModel> GetAllBookByAuthorName(string author)
        {
            return books.Where(e => e.AuthorName == author);
        }

    }
}
