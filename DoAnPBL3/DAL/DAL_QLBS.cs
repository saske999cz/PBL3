using DoAnPBL3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnPBL3.DAL
{
    // Quản lý bán sách
    class DAL_QLBS
    {
        private static DAL_QLBS _Instance;
        public static DAL_QLBS Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_QLBS();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }

        private DAL_QLBS()
        {

        }

        public List<Book> GetListBooks()
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                List<Book> listBooks = new List<Book>();

                listBooks = db.Books
                    .Select(book => book)
                    .ToList();
                if (listBooks.Count > 0)
                    return listBooks;
                else
                    return null;
            }
        }

        public List<Book> GetListVietnameseBooks()
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                List<Book> listVietnameseBooks = new List<Book>();
                int ID_Language = db.Languages
                    .Where(language => language.NameLanguage == "Tiếng Việt")
                    .Select(language => new { language.ID_Language })
                    .FirstOrDefault()
                    .ID_Language;
                listVietnameseBooks = db.Books
                    .Where(book => book.ID_Language == ID_Language)
                    .Select(book => book)
                    .ToList();
                if (listVietnameseBooks.Count > 0)
                    return listVietnameseBooks;
                else
                    return null;
            }
        }

        public List<Book> GetListEnglishBooks()
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                List<Book> listEnglishBooks = new List<Book>();
                int ID_Language = db.Languages
                    .Where(language => language.NameLanguage == "Tiếng Anh")
                    .Select(language => new { language.ID_Language })
                    .FirstOrDefault()
                    .ID_Language;
                listEnglishBooks = db.Books
                    .Where(book => book.ID_Language == ID_Language)
                    .Select(book => book)
                    .ToList();
                if (listEnglishBooks.Count > 0)
                    return listEnglishBooks;
                else
                    return null;
            }
        }

        public List<Book> GetBooksByNameBook(string nameBook)
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                List<Book> listBooks = new List<Book>();

                listBooks = db.Books
                    .Where(book => book.NameBook.Contains(nameBook))
                    .Select(book => book)
                    .ToList();
                if (listBooks.Count > 0)
                    return listBooks;
                else
                    return null;
            }
        }

        public List<Book> GetBooksByNameAuthor(string nameAuthor)
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                List<Book> listBooks = new List<Book>();

                listBooks = db.Books
                    .Where(book => book.NameAuthor.Contains(nameAuthor))
                    .Select(book => book)
                    .ToList();
                if (listBooks.Count > 0)
                    return listBooks;
                else
                    return null;
            }
        }

        public List<Book> SortByNameBookASC()
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                List<Book> listBooks = new List<Book>();
                listBooks = db.Books
                    .Select(book => book)
                    .OrderBy(book => book.NameBook)
                    .ToList();
                if (listBooks.Count > 0)
                    return listBooks;
                else
                    return null;
            }
        }

        public List<Book> SortByNameBookDESC()
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                List<Book> listBooks = new List<Book>();
                listBooks = db.Books
                    .Select(book => book)
                    .OrderByDescending(book => book.NameBook)
                    .ToList();
                if (listBooks.Count > 0)
                    return listBooks;
                else
                    return null;
            }
        }

        public List<Book> SortByPriceASC()
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                List<Book> listBooks = new List<Book>();
                listBooks = db.Books
                    .Select(book => book)
                    .OrderBy(book => book.Price)
                    .ToList();
                if (listBooks.Count > 0)
                    return listBooks;
                else
                    return null;
            }
        }

        public List<Book> SortByPriceDESC()
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                List<Book> listBooks = new List<Book>();
                listBooks = db.Books
                    .Select(book => book)
                    .OrderByDescending(book => book.Price)
                    .ToList();
                if (listBooks.Count > 0)
                    return listBooks;
                else
                    return null;
            }
        }

        public List<Book> SortByQuantityASC()
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                List<Book> listBooks = new List<Book>();
                listBooks = db.Books
                    .Select(book => book)
                    .OrderBy(book => book.Quantity)
                    .ToList();
                if (listBooks.Count > 0)
                    return listBooks;
                else
                    return null;
            }
        }

        public List<Book> SortByQuantityDESC()
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                List<Book> listBooks = new List<Book>();
                listBooks = db.Books
                    .Select(book => book)
                    .OrderByDescending(book => book.Quantity)
                    .ToList();
                if (listBooks.Count > 0)
                    return listBooks;
                else
                    return null;
            }
        }

        public Book GetBookByID(string ID_Book)
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                return db.Books
                    .Where(book => book.ID_Book == ID_Book)
                    .Select(book => book)
                    .FirstOrDefault();
            }
        }

        public int GetNumberTotalBook()
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                return db.Books.Count();
            }
        }

        public int GetNumberTotalVietnameseBook()
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                return db.Books
                    .Join(
                        db.Languages,
                        book => book.ID_Language,
                        lang => lang.ID_Language,
                        (book, lang) => new { book.ID_Book, lang.NameLanguage })
                    .Where(book => book.NameLanguage == "Tiếng Việt")
                    .Count();
            }
        }

        public int GetNumberTotalEnglishBook()
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                return db.Books
                    .Join(
                        db.Languages,
                        book => book.ID_Language,
                        lang => lang.ID_Language,
                        (book, lang) => new { book.ID_Book, lang.NameLanguage })
                    .Where(book => book.NameLanguage == "Tiếng Anh")
                    .Count();
            }
        }

        public string GetNameLanguageByID(int ID_Language)
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                return db.Languages
                    .Where(language => language.ID_Language == ID_Language)
                    .Select(language => new { language.NameLanguage })
                    .FirstOrDefault()
                    .NameLanguage;
            }
        }

        public string GetNamePublisherByID(int ID_Publisher)
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                return db.Publishers
                    .Where(publisher => publisher.ID_Publisher == ID_Publisher)
                    .Select(publisher => new { publisher.NamePublisher })
                    .FirstOrDefault()
                    .NamePublisher;
            }
        }

        public string GetNameGenreByID(int ID_Genre)
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                return db.Genres
                    .Where(genre => genre.ID_Genre == ID_Genre)
                    .Select(genre => new { genre.NameGenre })
                    .FirstOrDefault()
                    .NameGenre;
            }
        }
    }
}
