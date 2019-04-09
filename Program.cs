using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_media
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new Database();
            database.AddMedia(new Video("seigneur des  anneaux", 200, true, "Mon precieuuuux", "Peter Jackson"));
            database.AddMedia(new Video("dragon ball", 23,true, "manga", "sangoku"));
            database.AddMedia(new Cd("Sombre",2,false,"aucun commentaire","la fouine",3));

            database.Editer();
            Console.ReadKey(true);
        }
    }
}
