using System.Windows.Controls;
using System.Windows;
using System.Windows.Navigation;
using System.Data.SqlClient;
using System.Data;
using Microsoft.VisualBasic.Devices;
using System.Collections.Generic;
using System;

namespace Projet1_Analyse_conception_Ange_Tiphanie
{
    public partial class MainWindow : Window
    {
        //private SqlConnection conBD;
        //private bool test = false;

        public MainWindow()
        {
            InitializeComponent();
            ////Chargement du DataGrid
            RechargerList();
        }

        /// <summary>
        /// Remplir le DataGrid avec les données collectées de la BD
        /// </summary>
        
        private void RechargerList()
        {
            Reponse resultatList = Fonction.RecupererListEmploye();
            dgListe.ItemsSource = resultatList.Data as List<Employe>;
        }

        private void btnAjouter_Click(object sender, RoutedEventArgs e)
        {
            Employe employe = new Employe
            {
                Id = Convert.ToInt32(txtID.Text),
                Nom = txtNom.Text,
                Lundi = new Disponibilite { Debut = tpLundiDebut.Text, Fin=tpLundiFin.Text},
                Mardi = new Disponibilite { Debut = tpMardiDebut.Text, Fin=tpMardiFin.Text},
                Mercredi = new Disponibilite { Debut = tpMercrediDebut.Text, Fin= tpMercrediFin.Text},
                Jeudi = new Disponibilite { Debut = tpJeudiDebut.Text, Fin= tpJeudiFin.Text},
                Vendredi = new Disponibilite { Debut = tpVendrediDebut.Text, Fin= tpVendrediFin.Text},
            };
            Reponse resultat = Fonction.AjouterEmploye(employe); // VerifieOptionRecherche();
            if (resultat.Code == ReponseCode.Succes)
            {
                RechargerList();
            }
                MessageBox.Show(resultat.Message);
        }

        private void btnSupprimer_Click(object sender, RoutedEventArgs e)
        {
            Reponse resultat = Fonction.SupprimerEmploye(txtSupprimer.Text);
            MessageBox.Show(resultat.Message);
            RechargerList();
        }


        private void btnRecherche_Click(object sender, RoutedEventArgs e)
        {
            Reponse resultat = Fonction.RechercheEmployeeParID(txtRecherche.Text); // VerifieOptionRecherche();
            if(resultat.Code == ReponseCode.Erreur)
            {
                MessageBox.Show(resultat.Message);
            }
            else
            {
                dgListe.ItemsSource = resultat.Data as List<Employe>;

            }
        }

        private void btnRetour_Click(object sender, RoutedEventArgs e)
        {
            //Charger_liste_employe();
            //txtRecherche.Clear();
        }


        //private void DisponibiliteEmployes(int duree)
        //{
        //    // Convertir la durée du rendez-vous en minutes
        //    int dureeMinutes = duree;

        //    // Ma requête pour récupérer les employés disponibles
        //    string maRequete = @"SELECT Employes.NomComplet FROM Employes 
        //            INNER JOIN Disponibilites ON Employes.NomComplet = Disponibilites.NomComplet 
        //            WHERE 
        //                (CONVERT(int, SUBSTRING(Lundi, 1, 2)) * 60 + CONVERT(int, SUBSTRING(Lundi, 4, 2))) <= @heureDebut 
        //                AND (CONVERT(int, SUBSTRING(Lundi, 7, 2)) * 60 + CONVERT(int, SUBSTRING(Lundi, 10, 2))) + @duree >= @heureFin
        //                AND (CONVERT(int, SUBSTRING(Mardi, 1, 2)) * 60 + CONVERT(int, SUBSTRING(Mardi, 4, 2))) <= @heureDebut 
        //                AND (CONVERT(int, SUBSTRING(Mardi, 7, 2)) * 60 + CONVERT(int, SUBSTRING(Mardi, 10, 2))) + @duree >= @heureFin
        //                AND (CONVERT(int, SUBSTRING(Mercredi, 1, 2)) * 60 + CONVERT(int, SUBSTRING(Mercredi, 4, 2))) <= @heureDebut 
        //                AND (CONVERT(int, SUBSTRING(Mercredi, 7, 2)) * 60 + CONVERT(int, SUBSTRING(Mercredi, 10, 2))) + @duree >= @heureFin
        //                AND (CONVERT(int, SUBSTRING(Jeudi, 1, 2)) * 60 + CONVERT(int, SUBSTRING(Jeudi, 4, 2))) <= @heureDebut 
        //                AND (CONVERT(int, SUBSTRING(Jeudi, 7, 2)) * 60 + CONVERT(int, SUBSTRING(Jeudi, 10, 2))) + @duree >= @heureFin
        //                AND (CONVERT(int, SUBSTRING(Vendredi, 1, 2)) * 60 + CONVERT(int, SUBSTRING(Vendredi, 4, 2))) <= @heureDebut 
        //                AND (CONVERT(int, SUBSTRING(Vendredi, 7, 2)) * 60 + CONVERT(int, SUBSTRING(Vendredi, 10, 2))) + @duree >= @heureFin";


        //    // Ma commande
        //    SqlCommand cmd = new SqlCommand(maRequete, conBD);

        //    // Ajouter les paramètres à la commande
        //    cmd.Parameters.AddWithValue("@heureDebut", 0);
        //    cmd.Parameters.AddWithValue("@heureFin", 24 * 60);
        //    cmd.Parameters.AddWithValue("@duree", dureeMinutes);

        //    SqlDataAdapter sda = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    sda.Fill(dt);

        //    if (dt.Rows.Count == 0)
        //    {
        //        MessageBox.Show("Aucun employé n'est disponible pour ce rendez-vous.", "Erreur");
        //        return;
        //    }

        //    // Afficher les noms des employés disponibles
        //    string message = "Les employés suivants sont disponibles pour prendre ce rendez-vous :\n";
        //    foreach (DataRow row in dt.Rows)
        //    {
        //        message += row["NomComplet"].ToString() + "\n";
        //    }
        //    MessageBox.Show(message, "Disponibilité des employés");
        //}

        //private void btnDisponible_Click(object sender, RoutedEventArgs e)
        //{
        //    int duree = Convert.ToInt32(txtVoir.Text); // Récupérer la durée du rendez-vous à partir d'un champ texte nommé txtDuree

        //    DisponibiliteEmployes(duree);
        //}
        
     









        //public  bool VerifiOptionAjoutEmployer( )
        //{

        //    int id;
        //    if (string.IsNullOrWhiteSpace(txtID.Text) || string.IsNullOrWhiteSpace(txtNom.Text))
        //    {
        //        MessageBox.Show("Veuillez remplir tous les champs.");
        //        return false;
        //    }

           
        //    if (!int.TryParse(txtID.Text, out id))
        //    {
        //        MessageBox.Show("L'ID doit être un entier.");
        //        return false;
        //    }

        //    // Vérifier si l'employé existe déjà
        //    string maRequeteVerification = "SELECT COUNT(*) FROM Employes WHERE  NomComplet = @nom";


        //    SqlCommand cmdVerification = new SqlCommand(maRequeteVerification, conBD);
        //    cmdVerification.Parameters.AddWithValue("@nom", txtNom.Text);
        //    conBD.Open();
        //    int count = (int)cmdVerification.ExecuteScalar();
        //    conBD.Close();

        //    if (count > 0)
        //    {
        //        MessageBox.Show("Cet enregistrement existe déjà dans la base de données.");
        //    }
        //    else
        //    {
        //        // Vérifier l'heure de début et de fin pour chaque jour
        //        if (tpLundiDebut.Value >= tpLundiFin.Value)
        //        {
        //            MessageBox.Show("L'heure de début doit être inférieure à l'heure de fin pour le lundi.");
        //            return false;
        //        }

        //        if (tpMardiDebut.Value >= tpMardiFin.Value)
        //        {
        //            MessageBox.Show("L'heure de début doit être inférieure à l'heure de fin pour le mardi.");
        //            return false;
        //        }

        //        if (tpMercrediDebut.Value >= tpMercrediFin.Value)
        //        {
        //            MessageBox.Show("L'heure de début doit être inférieure à l'heure de fin pour le mercredi.");
        //            return false;
        //        }

        //        if (tpJeudiDebut.Value >= tpJeudiFin.Value)
        //        {
        //            MessageBox.Show("L'heure de début doit être inférieure à l'heure de fin pour le jeudi.");
        //            return false;
        //        }

        //        if (tpVendrediDebut.Value >= tpVendrediFin.Value)
        //        {
        //            MessageBox.Show("L'heure de début doit être inférieure à l'heure de fin pour le vendredi.");
        //            return false;
        //        }

        //        // Ma requete
        //        string maRequete = @"BEGIN TRAN;
        //         INSERT INTO Employes (ID, NomComplet)
        //         VALUES (@ID, @NomComplet);
        //         INSERT INTO Disponibilites (NomComplet, Lundi, Mardi, Mercredi, Jeudi, Vendredi)
        //         VALUES (@NomComplet, @Lundi, @Mardi, @Mercredi, @Jeudi, @Vendredi);
        //         COMMIT;"
        //        ;

        //        //Ma commande
        //        SqlCommand cmd = new SqlCommand(maRequete, conBD);

        //        cmd.CommandType = CommandType.Text; //Comment exécuter ma requête



        //        //Récupérer les informations à mettre dans les paramètres
        //        cmd.Parameters.AddWithValue("@ID", txtID.Text);
        //        cmd.Parameters.AddWithValue("@NomComplet", txtNom.Text);
        //        cmd.Parameters.AddWithValue("@Lundi", tpLundiDebut.Text + " - " + tpLundiFin.Text);
        //        cmd.Parameters.AddWithValue("@Mardi", tpMardiDebut.Text + " - " + tpMardiFin.Text);
        //        cmd.Parameters.AddWithValue("@Mercredi", tpMercrediDebut.Text + " - " + tpMercrediFin.Text);
        //        cmd.Parameters.AddWithValue("@Jeudi", tpJeudiDebut.Text + " - " + tpJeudiFin.Text);
        //        cmd.Parameters.AddWithValue("@Vendredi", tpVendrediDebut.Text + " - " + tpVendrediFin.Text);


        //        conBD.Open(); //Ouvrir la connexion
        //        cmd.ExecuteNonQuery(); //Exécuter la requête
        //        conBD.Close(); //Fermer la connexion



        //        //Afficher un message de confirmation
        //        MessageBox.Show("Ajout fait avec succès!", "Confirmation");

        //        //Recharger le DataGrid
        //        Charger_liste_employe();

        //        //Vider les composants
        //        txtID.Clear();
        //        txtNom.Clear();
        //        tpLundiDebut.Value = null;
        //        tpLundiFin.Value = null;
        //        tpMardiDebut.Value = null;
        //        tpMardiFin.Value = null;
        //        tpMercrediDebut.Value = null;
        //        tpMercrediFin.Value = null;
        //        tpJeudiDebut.Value = null;
        //        tpJeudiFin.Value = null;
        //        tpVendrediDebut.Value = null;
        //        tpVendrediFin.Value = null;
        //    }
        //    return true;
        //}





        



        //public bool  VerifieOptionRecherche(string idEmployee)
        //{

        //    // Vérifier si l'ID est valide
        //    int id;
        //    if (!int.TryParse(idEmployee, out id))
        //    {
        //        MessageBox.Show("L'ID doit être un nombre entier.", "Erreur de saisie");
        //        return false;
        //    }

        //    // Ma requête
        //    string maRequete = "SELECT Employes.ID as ID, Employes.NomComplet as NomComplet, Disponibilites.Lundi as Lundi, Disponibilites.Mardi as Mardi, Disponibilites.Mercredi as Mercredi, Disponibilites.Jeudi as Jeudi, Disponibilites.Vendredi as Vendredi " +
        //                       "FROM Employes INNER JOIN Disponibilites ON Employes.NomComplet = Disponibilites.NomComplet" +
        //                       " WHERE ID = " + idEmployee;

        //    // Ma commande
        //    SqlCommand cmd = new SqlCommand(maRequete, conBD);
        //    cmd.Parameters.AddWithValue("@ID", id);

        //    SqlDataAdapter sda = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    sda.Fill(dt);

        //    if (dt.Rows.Count == 0)
        //    {
        //        MessageBox.Show("L'employé avec l'ID " + id + " n'existe pas dans la base de données.", "Erreur");
        //        return false;
        //    }

        //    // Afficher les résultats dans le DataGrid
        //    dgListe.ItemsSource = dt.DefaultView;
        //    return true;
        //}
        
        
    }
}
