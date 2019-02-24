using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gacti_PPE
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            if (Donnees.Connexion())
            {
                InitializeComponent();
                textBMotDePasse.UseSystemPasswordChar = true;
               
            }
            else
            {
                MessageBox.Show("La connexion à la base de données ne fonctionne pas, veuillez consulter le manuel.");
            }
            
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            
            string pseudo = textBNomUtilisateur.Text;
            string mdp = textBMotDePasse.Text;
            if (Donnees.RecupererUtilisateur(pseudo, mdp) != false)
            {
                Donnees.RecupererUtilisateur(pseudo, mdp);
                if(Utilisateur.EstVacancier() == true)
                {
                    Connexion.ActiveForm.Hide();
                    AccueilVacancier accueilVacancier = new AccueilVacancier();
                    accueilVacancier.ShowDialog();
                }
                else
                    if (Utilisateur.EstEncadrant() == true)
                    {
                        Connexion.ActiveForm.Hide();
                        AccueilEncadrant activitesEncadrant = new AccueilEncadrant();
                        activitesEncadrant.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Vous avez tout cassé !");
                    }
            }
            else
            {
                MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect ou inexistant.");
            }
            
        }

        private void Connexion_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnConnexion;
        }

        private void chkBoxVoirMdp_CheckedChanged(object sender, EventArgs e)
        {
            if(chkBoxVoirMdp.Checked == true)
            {
                textBMotDePasse.UseSystemPasswordChar = false;
            }
            else
            {
                textBMotDePasse.UseSystemPasswordChar = true;
            }
        }
    }
}
