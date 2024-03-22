using Microsoft.Identity.Client;
using Repositories;
using Repositories.Entities;

namespace Services
{
    //3-layer Architecture:
    // [1]            [2]                [3]                          SQLSERVER        
    //UI-Forms  ---- Services  ------- Repositories -----------------    DB
    //MainUI    ---- BookService       BookRepository (Book Entity)    Book Table
    //  request/response         <----->      
    //  đưa data xuống DB                chơi trực tiếp DB: lên, xuống
    //  lấy data từ DB show                                 CRUD table thực sự
    //            RAM                             DB ĐĨA CỨNG HDD/SSD 
    public class BookService
    {
        private BookRepository _repo = new();

        public List<Book> GetAllBooks()
        {
            return _repo.GetBooks();
        }

        public void UpdateBook(Book b)
        {
            _repo.UpdateBook(b);
        }

        public void AddBook(Book b)
        {
            _repo.CreateBook(b);
        }

        public void DeleteBook(Book b)
        {
            _repo.DeleteBook(b);
        }
    }
}
