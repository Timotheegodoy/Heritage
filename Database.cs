using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_media
{
    class Database
    {
        private List<Media> lstMedia;
        public Database()
        {
            lstMedia = new List<Media>();
        }
        public List<Media> GetLstMedia()
        {
            return lstMedia;
        }
        public void  AddMedia(Media media)
        {
            lstMedia.Add(media);                                   
        }
        public void Editer()
        {
            for(int i = 0; i < lstMedia.Count; i++)
            {
                if(lstMedia[i] is Video)
                {
                    Console.WriteLine(lstMedia[i].Afficher());
                }
            }
            for (int i = 0; i < lstMedia.Count; i++)
            {
                if (lstMedia[i] is Cd)
                {
                   Console.WriteLine( lstMedia[i].Afficher())
                        ;
                }
            }
        }
    }
}
