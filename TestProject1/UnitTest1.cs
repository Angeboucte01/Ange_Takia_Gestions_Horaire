using NUnit.Framework;
using  Projet1_Analyse_conception_Ange_Tiphanie;
using System.Collections.Generic;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        
        [Test]
        public void TestRechercheEmployeeParID()
        {
            Reponse resultat = Fonction.RechercheEmployeeParID("12");
            bool resultTest = resultat.Code == ReponseCode.Erreur ? false : true;
            Assert.AreEqual(true, resultTest);
        }

        [Test]
        public void TestAjouterEmploye()
        {
            Employe employe = new Employe
            {
                Id = 41,
                Nom = "michelle ",
                Lundi = new Disponibilite { Debut = "10:00", Fin = "11:00" },
                Mardi = new Disponibilite { Debut = "10:00", Fin = "11:00" },
                Mercredi = new Disponibilite { Debut = "10:00", Fin = "11:00" },
                Jeudi = new Disponibilite { Debut = "10:00", Fin = "11:00" },
                Vendredi = new Disponibilite { Debut = "10:00", Fin = "11:00" },
            };
            Reponse resultat = Fonction.AjouterEmploye(employe);
            bool resultTest = resultat.Code == ReponseCode.Erreur ? false : true;
            Assert.AreEqual(true, resultTest);
        }


        [Test]
        public void TestRecupererListEmploye()
        {
            Reponse resultat = Fonction.RecupererListEmploye();
            Assert.AreEqual(true, (resultat.Data as List<Employe>).Count > 0);
        }


        [Test]
        public void TestSupprimerEmploye()
        {
            Reponse resultat = Fonction.SupprimerEmploye("1");
            bool resultTest = resultat.Code == ReponseCode.Erreur ? false : true;
            Assert.AreEqual(true, resultTest);
        }





    }
}
