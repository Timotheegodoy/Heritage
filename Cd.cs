using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_media
{
    class Cd:Media
    {

        private string artiste;
        private int nombreDePistes;
        public Cd(string titre,int duree,bool enStock,string commentaire,string pArtiste,int pNbPiste) : base(titre, duree, enStock, commentaire)
        {
            artiste = pArtiste;
            nombreDePistes = pNbPiste;
        }
        public override string Afficher()
        {

            return "Le Titre : " + titre + "\n" +
                "La Duree : " + duree + "\n" +
                "En Stock ? : " + enStock + "\n" +
                "commentaire: " + commentaire+"\n" +
                "l'artiste est : "+artiste+"\n" +
                "il y'a : " +nombreDePistes+" nombre de pistes";

        }
    }
}
