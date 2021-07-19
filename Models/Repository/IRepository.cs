using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieBase.Models.Repository
{
    public interface IRepository<T>
    {
        public Task<IEnumerable<T>> GetAll();
        public T Get(int id);
        public Task Add(T Entity);
        public void Update(T Entity);
        public void Remove(T Entity);
        public Task Save();
    }
}
