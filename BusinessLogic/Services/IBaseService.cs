using DataAccess.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public interface IBaseService<T> where T : BaseClass
    {
        List<T> GetAll();

        //Create
        void Create(T entity);


        //Read
        T GetById(int id);

        //Update
        void Update(T entity);

        //Delete
        void Delete(T entity);

    }
}
