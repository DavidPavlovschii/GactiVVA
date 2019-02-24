using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gacti_PPE.Vacancier
{
    public partial class ActivitesVacancier : Form
    {
        private Animation tmpAnimation = Modification.GetAnimation();
        public ActivitesVacancier()
        {
            InitializeComponent();
            richTBDescAnimation.ReadOnly = true;
            lbNomAnim.Text = tmpAnimation.Nom;
            richTBDescAnimation.Text = tmpAnimation.Description;
            listBActivites.Text = tmpAnimation.Description;
            List<Activite> listeActivites = Donnees.GetLesActivitesPourUneAnimation(tmpAnimation);
            listBActivites.Items.AddRange(listeActivites.ToArray());
            if (listBActivites.Items.Count == 0)
            {
                string msg = "Aucune activité n'existe pour l'animation " + tmpAnimation.Code;
                listBActivites.Items.Add(msg);
            }
        }

        private void btnPlusDInfos_Click(object sender, EventArgs e)
        {
            if (listBActivites.SelectedItem == null)
            {
                MessageBox.Show("Veuillez selectionner une activité pour avoir plus d'informations.");
            }
            else
            {
                Activite uneActivite = (Activite)listBActivites.SelectedItem;
                MessageBox.Show("L'activité aura lieu avec l'animateur : " + uneActivite.NomResp + " " + uneActivite.PrenomRes + "\n Coût de l'animation : " + tmpAnimation.Tarif + "€" + "\n Difficulté de l'animation : " + tmpAnimation.Difficulte 
                                + "\n Date limite avant cloturation des inscriptions : " + tmpAnimation.DateValidite.Substring(0,10) + "\n Pour y participer vous devez avoir au minimum " + tmpAnimation.LimiteAge + " ans.");
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInscriptionActi_Click(object sender, EventArgs e)
        {
            if (listBActivites.SelectedItem == null)
            {
                MessageBox.Show("Veuillez selectionner une animation pour pouvoir vous y inscrire.");
            }
            else
            {
                Activite uneActivite = (Activite)listBActivites.SelectedItem;
                DateTime dateActivite = Convert.ToDateTime(uneActivite.DateAct);
                int ageVacancier = DateTime.Now.Year - Utilisateur.GetDateNaiss().Year;
                int nbPlaces = Donnees.GetNbPlaceDispo(uneActivite);
                bool estDejaInscrit = Donnees.VerifierInscription(uneActivite);
                bool estCreneauValide = Donnees.estCreneauValide(uneActivite);

                if (dateActivite < Utilisateur.GetDateDebSejour() || dateActivite > Utilisateur.GetDateFinSejour())
                {
                    MessageBox.Show("Vos dates de vacances ne correspondent pas aux dates de validité de l'activité, l'inscription est impossible.");
                }
                else
                    if(ageVacancier < tmpAnimation.LimiteAge)
                {
                    MessageBox.Show("Vous n'avez pas l'âge minimum requis pour participer à l'activité (age minimum = " +tmpAnimation.LimiteAge+ ")");
                }
                else
                    if(Utilisateur.GetDateFerme() < dateActivite)
                {
                    MessageBox.Show("Votre compte est malheuresement cloturé à la date de l'activité (date de cloturation : " +Utilisateur.GetDateFerme().ToString().Substring(0, 10) + ") ");
                }
                else
                    if ( nbPlaces - 1 < 0)
                    {
                        MessageBox.Show("Il n'y a plus de places disponible pour cette activité.");
                    }
                else 
                    if (estDejaInscrit)
                    {
                        MessageBox.Show("Vous êtes déjà inscrit(e) à cette activité à la date "+ uneActivite.DateAct.Substring(0,10) +" . " +
                                        "\rUne seule inscription est admise par jour et par activité.");
                    }
                else 
                    if (estCreneauValide == false)
                    {
                        MessageBox.Show("Vous ne pouvez pas avoir 2 activités sur le même créneaux horaire");
                    }
                else
                {
                    Donnees.InscriptionVacancier((Activite)listBActivites.SelectedItem);
                    MessageBox.Show("L'inscription est bien prise en compte, " +
                                    "\rVoici votre numéro d'inscription : " + Donnees.GetNoInscrip(uneActivite));
                }
            }
        }
    }
}
