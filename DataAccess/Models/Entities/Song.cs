using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Entities
{
    public class Song : BaseClass
    {
        public string SongName { get; set; }
        public virtual Artist Artist { get; set; } //Neden Virtual?
        public int ArtistID { get; set; }
    }
}
