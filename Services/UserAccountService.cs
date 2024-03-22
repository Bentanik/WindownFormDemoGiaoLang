using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UserAccountService
    {
        private UserAccountRepository _repo = new();

        public UserAccount CheckLogin(string email, string password)
        {
            //Hàm trả về account tử tế nếu trùng email và pass
            //Hàm trả về account độ - account giả nếu đúng email nhưng sai pass

            UserAccount acc = _repo.GetAccount(email);
            if(acc == null) return null;
            if (acc.Password == password) return acc;
            return new UserAccount(){ Role = -1};
        }

    }
}
