using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboRevisionUA2
{
    internal class Adresse
    {
        private string codePostal;
        private string province;

        public int Numero { get; set; } 
        public string NomRue { get; set; } 
        public string Ville { get; set;} 
        public string CodePostal
        {
            get { return codePostal; }
            set
            => codePostal = value.Length == 6 ? value : "K1K1K1";
        }
        public string Province
        {
            get { return province; }
            set
                => province =  value.Length == 2 ? value.ToUpper() : "QC";
           /* {
                if (value.ToUpper().Length == 6) 
                          province = value.ToUpper();
                else province = "QC";
            }*/

        }

        //Definition des constructeurs 
        public Adresse(int num, string nomRue, string ville, string codePostal, string province)
        {
            this.Numero = num;
            this.NomRue = nomRue;
            this.Ville = ville;
            this.CodePostal = codePostal;
            this.Province = province;
        }
        // Methode egalite Adresse

        public bool Egalite(Adresse ad)
        {
            return this.Numero   == ad.Numero &&
                   this.NomRue   == ad.NomRue && 
                   this.Province == ad.Province  ? true : false;
        }

        public string ToString()
        {
            return Numero+","+NomRue+","+Ville+"," +Province+","+CodePostal.Substring(0, 3)+"-"+ CodePostal.Substring(3, CodePostal.Length - 3);
        }
         
        //Surchage de l'operateur egalite

        public static bool operator  == (Adresse A, Adresse B)
        {
            return (A.Egalite(B));
        }
        
        public static bool operator != (Adresse A, Adresse B)
        {
            return !(A.Egalite(B));
        }
    }
    
}
