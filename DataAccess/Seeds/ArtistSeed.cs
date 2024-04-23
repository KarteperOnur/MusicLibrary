using DataAccess.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Seeds
{
    public class ArtistSeed
    {
        public static List<Artist> Artists = new List<Artist>() 
        { 
         new Artist{ID=1,ArtistName="Artist1"},
         new Artist{ID=2,ArtistName="Artist2"},
         new Artist{ID=3,ArtistName="Artist3"}
        };

    }
}
