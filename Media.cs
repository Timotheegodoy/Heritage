using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_media
{
   abstract class  Media
    {
        protected string titre;
        protected int duree;
        protected bool enStock;
        protected string commentaire;
        public Media(string pTitre,int pDuree,bool pEnStock,string pCommentaire)
        {
            titre = pTitre;
            duree = pDuree;
            enStock = pEnStock;
            commentaire = pCommentaire;
            
        }
        public void SetCommentaire(string pCommentaire)
        {
            commentaire = pCommentaire;
        }
        public string GetCommentaire()
        {
            return commentaire;
        }
        public string GetTitre()
        {
            return titre;
        }
        public int GetDuree()
        {
            return duree;
        }
        public void SetEnStock(bool pEnStock)
        {
            enStock = pEnStock;
        }
        public bool GetStock()
        {
            return enStock;
        }
        public abstract string Afficher();
       
    }
}
