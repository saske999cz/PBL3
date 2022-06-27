using DoAnPBL3.DAL;
using DoAnPBL3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnPBL3.BLL
{
    // Quản lý bán sách
    class BLL_QLBS
    {
        private static BLL_QLBS _Instance;
        public static BLL_QLBS Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_QLBS();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }

        private BLL_QLBS()
        {

        }

        public List<Book> GetBooks()
        {
            return DAL_QLBS.Instance.GetListBooks();
        }

        public List<Book> GetVietnameseBooks()
        {
            return DAL_QLBS.Instance.GetListVietnameseBooks();
        }

        public List<Book> GetEnglishBooks()
        {
            return DAL_QLBS.Instance.GetListEnglishBooks();
        }

        public List<Book> GetBooksByNameBook(string nameBook)
        {
            return DAL_QLBS.Instance.GetBooksByNameBook(nameBook);
        }

        public List<Book> GetBooksByNameAuthor(string nameAuthor)
        {
            return DAL_QLBS.Instance.GetBooksByNameAuthor(nameAuthor);
        }

        public List<Book> SortByNameBookASC()
        {
            return DAL_QLBS.Instance.SortByNameBookASC();
        }

        public List<Book> SortByNameBookDESC()
        {
            return DAL_QLBS.Instance.SortByNameBookDESC();
        }

        public List<Book> SortByPriceASC()
        {
            return DAL_QLBS.Instance.SortByPriceASC();
        }

        public List<Book> SortByPriceDESC()
        {
            return DAL_QLBS.Instance.SortByPriceDESC();
        }

        public List<Book> SortByQuantityASC()
        {
            return DAL_QLBS.Instance.SortByQuantityASC();
        }

        public List<Book> SortByQuantityDESC()
        {
            return DAL_QLBS.Instance.SortByQuantityDESC();
        }

        public Book GetBookByID(string ID_Book)
        {
            return DAL_QLBS.Instance.GetBookByID(ID_Book);
        }

        public int GetNumberTotalBook()
        {
            return DAL_QLBS.Instance.GetNumberTotalBook();
        }

        public int GetNumberTotalVietnameseBook()
        {
            return DAL_QLBS.Instance.GetNumberTotalVietnameseBook();
        }

        public int GetNumberTotalEnglishBook()
        {
            return DAL_QLBS.Instance.GetNumberTotalEnglishBook();
        }

        public string GetNameLanguageByID(int ID_Language)
        {
            return DAL_QLBS.Instance.GetNameLanguageByID(ID_Language);
        }

        public string GetNamePublisherByID(int ID_Publisher)
        {
            return DAL_QLBS.Instance.GetNamePublisherByID(ID_Publisher);
        }

        public string GetNameGenreByID(int ID_Genre)
        {
            return DAL_QLBS.Instance.GetNameGenreByID(ID_Genre);
        }

        //public bool DeleteBook(string ID_Book)
        //{
        //    return DAL_QLBS.Instance.DeleteBook(ID_Book);
        //}
    }
}
