using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MovieBase.Models.Repository
{
    public class MsSqlAccountRepository : MsSqlRepository<User>, IAccountRepository
    {
        public MsSqlAccountRepository(ApplicationDbContext context) : base(context) { }
        public async Task<User> GetUserByEmail(string email)
        {
            return await db.Users.FirstOrDefaultAsync(x => x.Email == email);
        }

        public async Task<User> GetUserByLogIn(string login, string password)
        {
            return await db.Users.FirstOrDefaultAsync(x => (x.Login == login || x.Email==login) && x.Password==password);
        }

    }
}
