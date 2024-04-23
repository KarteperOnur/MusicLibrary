using DataAccess.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Seeds
{
    public class SongSeed
    {
        public static List<Song> Songs = new List<Song>() 
        { 
         new Song{ID=1,SongName="ASong", ArtistID = 1},
         new Song{ID=2,SongName="BSong", ArtistID = 2},
         new Song{ID=3,SongName="CSong", ArtistID = 3}
        };

    }
}
