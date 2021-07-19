using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieBase.Models.Repository
{
    public class MsSqlRepository<T> : IRepository<T> where T : class
    {
        protected ApplicationDbContext db;
        public MsSqlRepository(ApplicationDbContext context)
        {
            db = context;
        }

        public async Task Add(T Entity)
        {
            await db.Set<T>().AddAsync(Entity);
        }

        public void Remove(T Entity)
        {
            db.Set<T>().Remove(Entity);
        }
        public void Update(T Entity)
        {
            db.Set<T>().Update(Entity);
        }
        public T Get(int id)
        {
            return db.Set<T>().Find(id);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await db.Set<T>().ToListAsync();
        }

        public async Task Save()
        {
            await db.SaveChangesAsync();
        }
    }
}
