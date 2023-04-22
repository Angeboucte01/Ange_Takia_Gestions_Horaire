using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1_Analyse_conception_Ange_Tiphanie
{
    public static class Fonction
    {
        private static readonly string chaineDeConnexion = @"Data Source=LAPTOP-MMOV298M\SQLEXPRESS;Initial Catalog=gestionHoraires;Integrated Security=True";

        public static Reponse RechercheEmployeeParID(string idEmployee)
        {
            List<Employe> employes = new List<Employe>();
            if (!int.TryParse(idEmployee, out var id))
            {
                return new Reponse(ReponseCode.Erreur, "L'ID doit être un nombre entier.");
            }

            // Ma requête
            string maRequete = "SELECT Employes.ID as Id, Employes.NomComplet as Nom, Disponibilites.Lundi as Lundi, Disponibilites.Mardi as Mardi, Disponibilites.Mercredi as Mercredi, Disponibilites.Jeudi as Jeudi, Disponibilites.Vendredi as Vendredi " +
                               "FROM Employes INNER JOIN Disponibilites ON Employes.NomComplet = Disponibilites.NomComplet" +
                               " WHERE ID = " + idEmployee;

            // Ma commande
            using (SqlConnection connection = new SqlConnection(chaineDeConnexion))
            {
                SqlCommand cmd = new SqlCommand(maRequete, connection);
                cmd.Parameters.AddWithValue("@ID", id);

                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();



                while (reader.Read()) {
                    var disponibiliteLundi = reader.GetString("Lundi").Split('-');
                    var disponibiliteMardi = reader.GetString("Mardi").Split('-');
                    var disponibiliteMercredi = reader.GetString("Mercredi").Split('-');
                    var disponibiliteJeudi = reader.GetString("Jeudi").Split('-');
                    var disponibiliteVendredi = reader.GetString("Vendredi").Split('-');
                    employes.Add(new Employe
                    {
                        Id = reader.GetInt32(0),
                        Nom = reader.GetString(1),
                        Lundi = new Disponibilite { Debut = disponibiliteLundi[0], Fin = disponibiliteLundi[1] },
                        Mardi = new Disponibilite { Debut = disponibiliteMardi[0], Fin = disponibiliteMardi[1] },
                        Mercredi = new Disponibilite { Debut = disponibiliteMercredi[0], Fin = disponibiliteMercredi[1] },
                        Jeudi = new Disponibilite { Debut = disponibiliteJeudi[0], Fin = disponibiliteJeudi[1] },
                        Vendredi = new Disponibilite { Debut = disponibiliteVendredi[0], Fin = disponibiliteVendredi[1] }
                    });
                }
                connection.Close();
            }


            if (!employes.Any()) // il n'y pas d'employe correspondant
            {
                return new Reponse(ReponseCode.Erreur, $"L'employé avec l'ID: {idEmployee} n'existe pas dans la base de données.");
            }
            return new Reponse(ReponseCode.Succes, string.Empty, employes);
        }

        public static  Reponse AjouterEmploye(Employe employe) {
            if (!employe.Id.HasValue || string.IsNullOrWhiteSpace(employe.Nom))
            {
                return new Reponse(ReponseCode.Erreur, "Veuillez remplir tous les champs.");
            }

            // TODO: Verifier la validite des disponiblite


            //Vérifier si l'employé existe déjà

            string maRequete = @"BEGIN TRAN;
 INSERT INTO Employes (ID, NomComplet)
 VALUES (@ID, @NomComplet);
 INSERT INTO Disponibilites (NomComplet, Lundi, Mardi, Mercredi, Jeudi, Vendredi)
 VALUES (@NomComplet, @Lundi, @Mardi, @Mercredi, @Jeudi, @Vendredi);
 COMMIT;"
;
            using (SqlConnection connection = new SqlConnection(chaineDeConnexion))
            {
                SqlCommand cmd = new SqlCommand(maRequete, connection);
                //Récupérer les informations à mettre dans les paramètres
                cmd.Parameters.AddWithValue("@ID", employe.Id);
                cmd.Parameters.AddWithValue("@NomComplet", employe.Nom);
                cmd.Parameters.AddWithValue("@Lundi", employe.Lundi.ToString());
                cmd.Parameters.AddWithValue("@Mardi", employe.Mardi.ToString());
                cmd.Parameters.AddWithValue("@Mercredi", employe.Mercredi.ToString());
                cmd.Parameters.AddWithValue("@Jeudi", employe.Jeudi.ToString());
                cmd.Parameters.AddWithValue("@Vendredi", employe.Vendredi.ToString());


                connection.Open();

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                }
                catch (Exception ex)
                {
                    return new Reponse(ReponseCode.Erreur, ex.Message);
                }
                
                connection.Close();
            }

            return new Reponse(ReponseCode.Succes, "Ajout fait avec succès!");
        }

        public static Reponse RecupererListEmploye()
        {
            List<Employe> employes = new List<Employe>();
            //Ma requête permettant de selectionner tout les etudiants.
            string maRequete = "SELECT Employes.ID as ID, Employes.NomComplet as NomComplet, Disponibilites.Lundi as Lundi, Disponibilites.Mardi as Mardi, Disponibilites.Mercredi as Mercredi, Disponibilites.Jeudi as Jeudi, Disponibilites.Vendredi as Vendredi " +
                               "FROM Employes INNER JOIN Disponibilites ON Employes.NomComplet = Disponibilites.NomComplet;";
            using (SqlConnection connection = new SqlConnection(chaineDeConnexion))
            {
                SqlCommand cmd = new SqlCommand(maRequete, connection);

                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var disponibiliteLundi = reader.GetString("Lundi").Split('-');
                    var disponibiliteMardi = reader.GetString("Mardi").Split('-');
                    var disponibiliteMercredi = reader.GetString("Mercredi").Split('-');
                    var disponibiliteJeudi = reader.GetString("Jeudi").Split('-');
                    var disponibiliteVendredi = reader.GetString("Vendredi").Split('-');
                    employes.Add(new Employe
                    {
                        Id = reader.GetInt32(0),
                        Nom = reader.GetString(1),
                        Lundi = new Disponibilite { Debut = disponibiliteLundi[0], Fin = disponibiliteLundi[1] },
                        Mardi = new Disponibilite { Debut = disponibiliteMardi[0], Fin = disponibiliteMardi[1] },
                        Mercredi = new Disponibilite { Debut = disponibiliteMercredi[0], Fin = disponibiliteMercredi[1] },
                        Jeudi = new Disponibilite { Debut = disponibiliteJeudi[0], Fin = disponibiliteJeudi[1] },
                        Vendredi = new Disponibilite { Debut = disponibiliteVendredi[0], Fin = disponibiliteVendredi[1] }
                    });
                }
                connection.Close();
            }
            return new Reponse(ReponseCode.Succes, string.Empty, employes);
        }


        public static Reponse SupprimerEmploye(string idEmploye)
        {
            if (!int.TryParse(idEmploye, out var id))
            {
                return new Reponse(ReponseCode.Erreur, "Veuillez entrer un ID");
            }

            string maRequete = @"
        BEGIN TRAN;
        DELETE FROM Disponibilites WHERE NomComplet = (SELECT NomComplet FROM Employes WHERE ID = @ID);
        DELETE FROM Employes WHERE ID = @ID;
        COMMIT;
    ";

            ;
            using (SqlConnection connection = new SqlConnection(chaineDeConnexion))
            {
                SqlCommand cmd = new SqlCommand(maRequete, connection);
                //Récupérer les informations à mettre dans les paramètres
                cmd.Parameters.AddWithValue("@ID", id);


                connection.Open();

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                }
                catch (Exception ex)
                {
                    return new Reponse(ReponseCode.Erreur, ex.Message);
                }

                connection.Close();
            }

            return new Reponse(ReponseCode.Succes, "Suppression fait avec succès!");

        }
    }
}
