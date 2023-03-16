using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;


namespace Moubarak_Boucte_Njakam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      private SqlConnection conBD; 
      private bool test = false;


        public MainWindow()
        {
            InitializeComponent();

            // Configuration de la chaine de connexion
            conBD = new SqlConnection(@"Data Source=LAPTOP-Q5QGQTQU\\SQLEXPRESS08;Initial Catalog=Boucte_Moubarak_Njakam;Integrated Security=True");

            // Chargement des combo box
            charger_taille();
            charger_type();

        }

        private void charger_taille()
        {
            //Ma requete = 
            string maRequete = "select * from taille";

            //Ma commande
            SqlCommand cmd = new SqlCommand(maRequete, conBD);

            //Ouverture de la connexion
            conBD.Open();

            //Lire les enregistrements collectés suite à l'execution de la requete 
            SqlDataReader dr = cmd.ExecuteReader();

            //Chargement du combox avec les données de la BD

            while (dr.Read())
            {
                cbxTaille.Items.Add(dr[1].ToString());
            }

            //Fermer la connexion
            conBD.Close();
        }

        private void charger_type()
        {
            //Ma requete = 
            string maRequete = "select * from type";

            //Ma commande
            SqlCommand cmd = new SqlCommand(maRequete, conBD);

            //Ouverture de la connexion
            conBD.Open();

            //Lire les enregistrements collectés suite à l'execution de la requete 
            SqlDataReader dr = cmd.ExecuteReader();

            //Chargement du combox avec les données de la BD

            while (dr.Read())
            {
                cbxType.Items.Add(dr[1].ToString());
            }

            //Fermer la connexion
            conBD.Close();
        }

    }

  
}
