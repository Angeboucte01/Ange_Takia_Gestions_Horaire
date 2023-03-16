using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoire007
{
    internal class Document
    {
        //Un document est caractérisé par un id (entier), un titre (string) et un nombre de page (int). L’id s’incrémente d’une façon automatique à la création d’un nouveau document.

        public  static int Nbre = 0; 
        public int Id { get; private  set; }

        public string Type { get;  set; }

        public int NbreDePage { get; set; }


        public Document(  string type, int nbreDePage)
         {
            Type = type;
            NbreDePage = nbreDePage;
            Id = Nbre++;

        }
        //Redéfinition la méthode ToString

        public override string ToString()
        {
            return  $"Titre : {Type}  \n" +
                    $"Nombres de pages: {NbreDePage} \n "+
                    $"Id :{Id}";
        }

        //Redéfinir la méthode Equals.
       
        public override bool Equals(object obj)
        {
            //Tester si l'objet est null, dans ce cas il n'y a pas de
            //comparaison
            if (obj == null) return false;
            //Tester si obj est de meme type que la classe courante,
            //sinon il n'y a pas de comparaion
            if (obj.GetType() != this.GetType()) return false;
            //Convertir obj vers un objet de type la classe courante
            Document maClasse = (Document)obj;
             return base.Equals(obj) && 
                    Id == maClasse.Id &&
                    NbreDePage== maClasse.NbreDePage &&
                   Type== maClasse.Type;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

