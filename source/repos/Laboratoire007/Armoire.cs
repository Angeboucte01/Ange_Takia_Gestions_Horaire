using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoire007
{
    internal class Armoire
    {
        public List<Etagere> EtagereList { get; set; } = new List<Etagere>();

        // AddDocument : permettant d’ajouter un document dans la première étagèr libre(non pleine)

       /* public List<Document> AddDocument (Document doc)
        {
            if(doc != null)
                foreach(Document document  in Etageres)
                {
                     return AddDocument (document);  
                }
        }
       */

        public List<Livre> FindLivre()
        {
            List<Livre> livreList = new List<Livre>();
            foreach (Etagere e in EtagereList)
               livreList.AddRange( e.FindLivre());
                return livreList;
        }
    }
}
