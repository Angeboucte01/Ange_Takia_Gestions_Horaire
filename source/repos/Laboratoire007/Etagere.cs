using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoire007
{
    internal class Etagere
    {
        public  List<Document> ListeDocument { get; set; } = new List<Document>();
        public int NombreMaxDeLivre { get; set; }

        public Etagere(int nombreMaxDeLivre)
        {
            NombreMaxDeLivre = nombreMaxDeLivre;
        }
        
        //EstPleine : permettant de tester si l’étagère est pleine ou non.

        public bool EstPleine()
        {
            return NombreMaxDeLivre == ListeDocument.Count;
        }

        //AddDocument : permettant d’ajouter un document à l’étagère.


       public void AddDocument(Document d) 
       {
             if(!EstPleine())
                ListeDocument.Add(d);
       }

        // DeleteDocument : permettant de supprimer un document de l’étagère.
        public void DeleteDocument(Document d)
        {
            ListeDocument.Remove(d);
        }
        //FindDocument : permettant de retourner un document à partir de son ID.

        public Document FindDocument(int id) 
        {
            /*  foreach(Document d in ListeDocument)
                   if(d.Id == id)
                            return d;  
               return null;*/
            return ListeDocument.Find(d => d.Equals(ListeDocument)); 
        }
        //FindDocument : permettant de retourner une liste de document portant le titre passé comme paramètre
        public List<Document> FindDocument(string type)
        {
            /*  List<Document> list = new List<Document>();
              foreach(Document d in ListeDocument)
              if(type == d.Type)
                     list.Add(d); 
              return list;*/
            return ListeDocument.FindAll(d => type == d.Type);
        }
        //FindLivre : permettant de retourner la liste de tous les livres présents dans l’étagère
        public List <Livre> FindLivre()
        {
            List<Livre> livre = new List<Livre>();
            foreach (Document d in ListeDocument)
                if(d is Livre)
                     livre.Add(d as Livre);
            return livre;
        }
        //FindDictionnaire : permettant de retourner la liste de tous les dictionnaires  présents dans l’étagère
        public List<Dictionnaire> FindDictionnaire()
        { 
            List <Dictionnaire> dictionnaire = new List<Dictionnaire>();
            foreach (Document d in ListeDocument)
             if (d is Dictionnaire)
                     dictionnaire.Add(d as Dictionnaire);
            return dictionnaire;
        }

        //Existe : permettant de tester l’existence d’un document dans l’étagère
        public bool Existe(Document d)
        {
            return ListeDocument.Find(d => d.Equals(d)) != null;
        }

        //Occurrence : permettant de calculer l’occurrence d’un document dans l’étagère.

        public int Occurrence(Document d)
        {
            int occ = 0;
            if(Existe(d))
                occ++;
            return occ;
        }
    }

        


}
