using BusinessLogic.Services;
using DataAccess.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Repositories
{
    public class ArtistRepository:BaseService<Artist>
    {
        //Artist classına ait işlemlerin tanımlanma yeri
        public void GetArtistDetail() 
        {
            Console.WriteLine("Detail of Artist..");
        }
    }
}
