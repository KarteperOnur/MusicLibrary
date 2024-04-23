using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Entities
{
    public class Artist:BaseClass
    {
        public string ArtistName { get; set; }

        public List<Song> Songs { get; set; }
    }
}
