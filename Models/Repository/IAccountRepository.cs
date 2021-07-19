using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieBase.Models.Repository
{
    public interface IAccountRepository : IRepository<User>
    {
        public Task<User> GetUserByEmail(string email);
        public Task<User> GetUserByLogIn(string login, string password);
    }
}
