using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class UserAccountRepository
    {
        //Lại phải sử dụng DbContext
        private BookManagementDbContext _context = new();
        
        //Viết hàm trả về một account theo email, không theo password vì mình muốn chửi chi tiết từng trường 
        //hợp login

        public UserAccount? GetAccount(string email)
        {
            //LINQ, delegate, Lambda
            //.where() trả về nhiều
            //.select trả về nhiều
            //.FirstOrDefault() trả về duy nhất 1, hoặc null
            //_context.UserAccounts.FirstOrDefault( delegate (UserAccount x) {
            //        if (x.Email == email) return true;
            //        return false;
            //});
            return _context.UserAccounts.FirstOrDefault(x => x.Email == email);
        }


    }
}
