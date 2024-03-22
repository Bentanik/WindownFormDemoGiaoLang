using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class BookRepository
    {
        //Class này chơi trực tiếp với SQL Server qua DbContext(Có sẵn cs)
        //Class này sẽ bị gọi bởi class BookService
        //UI <----> BookService <----> BookRespository <----> DbContext <----> TABLE
        //[1]       [2]                [3]                    [4]              [5]
        //UI phải khai báo service
        //                 Service phải khai báo Repo
        //TA Ở ĐÂY BỊ SERVICE GỌI
        //TA Ở ĐÂY ĐI GỌI DBCONTEXT
        private BookManagementDbContext _context;
        //Không new, sẽ new ở từng hàm trong Repo;
        public List<Book>GetBooks()
        {
            _context = new();
            return _context.Books.ToList();
        }

        public void UpdateBook(Book b)
        {
            _context = new();
            _context.Books.Update(b);
            _context.SaveChanges();
        }

        public void CreateBook(Book b)
        {
            _context = new();
            _context.Books.Add(b);
            _context.SaveChanges();
        }

        public void DeleteBook(Book b)
        {
            _context = new();
            _context.Books.Remove(b);
            _context.SaveChanges();
        }
    }
}
