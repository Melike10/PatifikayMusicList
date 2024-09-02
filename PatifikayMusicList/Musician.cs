using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatifikayMusicList
{
    public class Musician 
    {
        public string Name { get; set; }
        public string MusicType { get; set; }
        public int Year { get; set; }
        public int SalesAlbum { get; set; }


        public static void Print(List<Musician> musicians)
        {
            foreach (Musician musician in musicians)
            {
                Console.WriteLine("Sanatçı Adı: " + musician.Name + " ,Müzik Türü: " + musician.MusicType + " ,Albüm Satışı : Yaklaşık " + (musician.SalesAlbum / 1000000) + " Milyon");
            }
        }

       
    }



}
