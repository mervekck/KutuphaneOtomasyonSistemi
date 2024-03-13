using LAS.Context;
using LAS.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAS.Repository.Abstract
{
    public class BaseRepository<T> : IRepository<T> where T : class, new()
    {
        LasDbContext db;
        public BaseRepository(LasDbContext dbcontext)
        {
            db = dbcontext;
        }
        public void Add(T item)
        {
            try
            {
                db.Set<T>().Add(item);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception($"Ekleme işlemi sırasında bir hata meydana geldi... hata mesajı => {ex.Message}");
            }
        }
        public void Edit(T item)
        {
            try
            {
                db.Set<T>().Update(item);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception($"Güncelleme işlemi sırasında bir hata meydana geldi... hata mesajı => {ex.Message}");
            }
        }
        public List<T> GetAll()
        {
            return db.Set<T>().ToList();
        }
        public List<T> GetBy(Func<T, bool> exp)
        {
            return db.Set<T>().Where(exp).ToList();
        }
        public T GetById(int id)
        {
            return db.Set<T>().Find(id);
        }
        public void Remove(T item)
        {
            try
            {
                db.Set<T>().Remove(item);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Silme işlemi sırasında bir hata meydana geldi... hata mesajı => {ex.Message}");
            }
        }
    }
}
