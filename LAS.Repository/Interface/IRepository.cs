using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace LAS.Repository.Interface
{
    public interface IRepository<T> where T : class, new()
    {
        void Add(T item);
        void Edit(T item);
        void Remove(T item);
        List<T> GetAll();
        List<T> GetBy(Func<T, bool> exp);
        T GetById(int id);
    }
}
