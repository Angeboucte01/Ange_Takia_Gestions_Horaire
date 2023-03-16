using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

/// <summary>
/// Classe principale de l'application qui hérite de la classe Window.
/// Elle contient les boutons permettant d'ajouter, de supprimer et de voir la disponibilité des employés.
/// </summary>
public class MainWindow : Window
{
    // Attributs
    /// <summary>
    /// Liste des employés stockés sous forme de chaînes de caractères.
    /// </summary>
    private List<string> liste_employer = new List<string>();

    /// <summary>
    /// Bouton permettant d'ajouter un employé.
    /// </summary>
    private Button buttonAjouter;

    /// <summary>
    /// Bouton permettant de supprimer un employé.
    /// </summary>
    private Button buttonSupprimer;

    /// <summary>
    /// Bouton permettant de voir la disponibilité d'un employé.
    /// </summary>
    private Button buttonVoirDisponibilite;

    // Initialisation des boutons
    /// <summary>
    /// Initialise une nouvelle instance de la classe MainWindow et initialise les boutons.
    /// </summary>
    public MainWindow()
    {
        InitializeComponent();
        buttonAjouter = new Button();
        buttonSupprimer = new Button();
        buttonVoirDisponibilite = new Button();
    }

    /// <summary>
    /// Initialise la fenetre de composant
    /// </summary>
    /// <exception cref="NotImplementedException">Lance une exception NotImplementedException car cette méthode n'a pas été implémentée.</exception>
    private void InitializeComponent()
    {
        throw new NotImplementedException();
    }

    // Propriétés
    /// <summary>
    /// Liste des employés
    /// </summary>
    public List<string> Employer
    {
        get { return liste_employer; }
    }

    /// <summary>
    /// Bouton d'ajout d'un employé
    /// </summary>
    public Button ButtonAjouter
    {
        get { return buttonAjouter; }
    }

    /// <summary>
    /// Bouton de suppression d'un employé
    /// </summary>
    public Button ButtonSupprimer
    {
        get { return buttonSupprimer; }
    }

    /// <summary>
    /// Bouton de visualisation des disponibilités d'un employé
    /// </summary>
    public Button ButtonVoirDisponibilite
    {
        get { return buttonVoirDisponibilite; }
    }

    // Méthodes

    /// <summary>
    /// Ajoute un employé à la liste des employés
    /// </summary>
    /// <param name="employer">Nom de l'employé à ajouter</param>
    public void AjouterEmployer(string employer)
    {
        
        liste_employer.Add(employer);
    }

    /// <summary>
    /// Supprime un employé de la liste des employés
    /// </summary>
    /// <param name="employer">Nom de l'employé à supprimer</param>
    public void SupprimerEmployer(string employer)
    {
        
        liste_employer.Remove(employer);
    }

    /// <summary>
    /// Affiche les disponibilités d'un employé sélectionné
    /// </summary>
    /// <param name="employer">Nom de l'employé sélectionné</param>
    public void VoirDisponibilite(string employer)
    {
        
    }
}
