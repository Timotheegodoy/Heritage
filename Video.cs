using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_media
{
    class Video:Media
    {
        private string metteurEnScene;
        public Video(string titre, int duree, bool enStock, string commentaire,string pMetteurEnScene) : base(titre, duree, enStock, commentaire)
        {
            metteurEnScene = pMetteurEnScene;
        }
        public override string Afficher()
        {

            return "Le Titre : " + titre + "\n" +
                "La Duree : " + duree + "\n" +
                "En Stock ? : " + enStock + "\n" +
                "commentaire: " + commentaire + "\n" +
                "le metteur En Scene  est : " + metteurEnScene + "\n";
              

        }
    }
}
