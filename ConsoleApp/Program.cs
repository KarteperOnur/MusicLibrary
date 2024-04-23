using BusinessLogic.Repositories;
using DataAccess.Models.Entities;

namespace ConsoleApp 
{
    class Program 
    { 
        public static void Main(string[] args) 
        { 
            ArtistRepository artistRepository = new ArtistRepository();
            SongRepository songRepository = new SongRepository();

            foreach (var song in songRepository.GetAll()) 
            {
                Console.WriteLine(song.SongName);
            }
        
        }
    }
}