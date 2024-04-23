using DataAccess.Models.Context;
using DataAccess.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class BaseService<T> : IBaseService<T> where T : BaseClass
    {
        MusicLibraryContext context= new MusicLibraryContext();
        public void Create(T entity)
        {
            context.Set<T>().Add(entity);

            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            context.Set<T>().Remove(entity);
            context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return context.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            var updated = context.Set<T>().Find(entity.ID);

            context.Entry(updated).CurrentValues.SetValues(entity);
            context.SaveChanges();
        }
    }
}
