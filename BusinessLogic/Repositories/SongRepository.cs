using BusinessLogic.Services;
using DataAccess.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Repositories
{
    public class SongRepository:BaseService<Song>
    {
        //Song clasına ait işlemlerin yeri
        public void Play() 
        {
            Console.WriteLine("Ring");
        }
    }
}
