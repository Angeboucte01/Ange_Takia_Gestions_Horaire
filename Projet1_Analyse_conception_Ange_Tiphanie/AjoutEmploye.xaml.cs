
using Projet1_Analyse_conception_Ange_Tiphanie;
using System.Windows.Controls;
using System.Windows;
using System;


public partial class AjoutEmploye : Page
{
    // Déclaration des attributs pour les éléments XAML
    private TextBox txtID;
    private TextBox txtNom;
    private ComboBox cmbLundiDebut;
    private ComboBox cmbLundiFin;
    private ComboBox cmbMardiDebut;
    private ComboBox cmbMardiFin;
    private ComboBox cmbMercrediDebut;
    private ComboBox cmbMercrediFin;
    private ComboBox cmbJeudiDebut;
    private ComboBox cmbJeudiFin;
    private ComboBox cmbVendrediDebut;
    private ComboBox cmbVendrediFin;
    private ComboBox cmbJour;
    private ComboBox cmbHeureDebut;
    private ComboBox cmbHeureFin;

    public AjoutEmploye()
    {
        // Remplir les listes de temps
        RemplirListesTemps();

        txtID = (TextBox)FindName("txtID");
        txtNom = (TextBox)FindName("txtNom");
        cmbLundiDebut = (ComboBox)FindName("cmbLundiDebut");
        cmbLundiFin = (ComboBox)FindName("cmbLundiFin");
        cmbMardiDebut = (ComboBox)FindName("cmbMardiDebut");
        cmbMardiFin = (ComboBox)FindName("cmbMardiFin");
    }

    private void RemplirListesTemps()
    {
        // Remplir les listes de temps pour les heures de début et de fin
        DateTime debut = DateTime.Parse("09:00");
        DateTime fin = DateTime.Parse("18:00");

        while (debut <= fin)
        {
            cmbHeureDebut.Items.Add(debut.ToString("HH:mm"));
            cmbHeureFin.Items.Add(debut.ToString("HH:mm"));
            debut = debut.AddMinutes(15);
        }
    }

    private void btnAjouter_Click(object sender, RoutedEventArgs e)
    {
        // Vérifier que toutes les informations ont été saisies
        if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtNom.Text) || cmbJour.SelectedIndex == -1 ||
            cmbHeureDebut.SelectedIndex == -1 || cmbHeureFin.SelectedIndex == -1)
        {
            MessageBox.Show("Veuillez remplir tous les champs !");
            return;
        }

        // Récupérer les informations saisies
        string id = txtID.Text;
        string nom = txtNom.Text;
        string jour = cmbJour.SelectedItem.ToString();
        string heureDebut = cmbHeureDebut.SelectedItem.ToString();
        string heureFin = cmbHeureFin.SelectedItem.ToString();

        // Ajouter l'employé avec les disponibilités à la liste des employés
       /* Employe nouvelEmploye = new Employe(id, nom);
        nouvelEmploye.AjouterDisponibilite(jour, heureDebut, heureFin);
        ListeEmployes.AjouterEmploye(nouvelEmploye);*/

        MessageBox.Show("Employé ajouté avec succès !");

        // Vider les champs
        txtID.Text = "";
        txtNom.Text = "";
        cmbJour.SelectedIndex = -1;
        cmbHeureDebut.SelectedIndex = -1;
        cmbHeureFin.SelectedIndex = -1;
    }
    private void MaPage(object sender, RoutedEventArgs e)
    {
        NavigationService.Navigate(new AjoutEmploye());
    }


}
