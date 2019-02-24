using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gacti_PPE.Encadrant
{
    public partial class EnregistrerActiviteEncadrant : Form
    {
        public EnregistrerActiviteEncadrant()
        {
            InitializeComponent();
            comboBCodeEtatAct.Items.AddRange(Donnees.GetLesEtatsDActivite().ToArray());
            List<Animation> listeAnimations = Donnees.GetLesAnimations();
            foreach (Animation uneAnimation in Donnees.GetLesAnimations())
            {
                comboBCodeAnimation.Items.Add(uneAnimation.Code);
            }
            foreach (Encadran unEncadrant in Donnees.GetListeEncadrant())
            {
                cmbBoxResponsable.Items.Add(unEncadrant);
            }
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            Animation animationTest = null;
            string codeAnimTest = null;

            if (comboBCodeAnimation.SelectedItem == null || comboBCodeEtatAct.SelectedItem == null || cmbBoxResponsable.SelectedItem == null)
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
            }
            else
            {
                #region Controle de validité
                //Controle de validité, récupere l'animation a partir du code anim dans la combobox
                codeAnimTest = comboBCodeAnimation.SelectedItem.ToString();
                foreach (Animation uneAnimation in Donnees.GetLesAnimations())
                {
                    if (uneAnimation.Code == codeAnimTest)
                    {
                        animationTest = uneAnimation;
                    }
                }

                if (Convert.ToDateTime(animationTest.DateValidite) < dtPickerDateAct.Value) //test si la date d'activité choisie est bien inferieur a la date de validité de l'animation
                {
                    MessageBox.Show("L'activité créée ne peut pas avoir lieu après la date de validité de l'animation (" + animationTest.DateValidite.Substring(0, 10) + ").");
                }
                else
                if (Convert.ToDateTime(animationTest.DateCreation) > dtPickerDateAct.Value)
                {
                    MessageBox.Show("L'activité créée ne peut pas avoir lieu avant la date de validité de l'animation (" + animationTest.DateCreation.Substring(0, 10) + ").");
                }
                else
                if (dtPickerHrDebut.Value > dtPickerHrFin.Value  )
                {
                    MessageBox.Show("L'activité ne peut pas démarrer après avoir terminé.");
                }
                else 
                if (dtPickerAnnulActivite.Value > dtPickerDateAct.Value)
                {
                    MessageBox.Show("La date d'annulation de l'activité ne peut pas avoir lieu après le début de l'activité");
                }

                #endregion
                else
                {
                    #region Conversion des dates au bon format
                    String dateAct = dtPickerDateAct.Value.ToString("yyyy:MM:dd");
                    String dateAnnulAct = dtPickerAnnulActivite.Value.ToString("yyyy:MM:dd");
                    string codeAnim = comboBCodeAnimation.SelectedItem.ToString();
                    string codeEtatAct = comboBCodeEtatAct.SelectedItem.ToString();

                    string hrRdvAct = dtPickerHrRdv.Value.ToString("HH:mm:ss");
                    Decimal prixActe = numUpDwnPrixAct.Value;

                    //Récupere l'heure du datetimepicker
                    string hrDebutAct = dtPickerHrDebut.Value.ToString("HH:mm:ss"); ;
                    string hrFinAct = dtPickerHrFin.Value.ToString("HH:mm:ss");
                    #endregion

                    //split du nom en tableau de string apres l'espace puis récuperation du nom et prenom (indice 1 = nom, indice 0 = prénom)
                    string[] tmp = cmbBoxResponsable.Text.Split(' ');
                    string nomResp = tmp[1];
                    string prenomRes = tmp[0];

                    Activite uneActivite = new Activite(codeAnim, dateAct, codeEtatAct, hrRdvAct, prixActe, hrDebutAct, hrFinAct, dateAnnulAct, nomResp, prenomRes);
                    bool existeActivite = Donnees.ExisteActivite(uneActivite);

                    if (existeActivite == false)
                    {
                        if (Donnees.AjouterActivite(uneActivite) == true)
                        {
                            MessageBox.Show("L'activité " + uneActivite.ToString() + " à bien été enregistrée");
                            ConsulterModifierActiviteEncadrant cmActE = new ConsulterModifierActiviteEncadrant();
                            cmActE.Show();
                            this.Close();
                        }
                        else
                            MessageBox.Show("Erreur lors de l'ajout de l'activité");
                    }
                    else
                    {
                        MessageBox.Show("L'activité " + uneActivite.CodeAnim + " existe déjà à la date " + uneActivite.DateAct + ", impossible de la créer.");
                    }
                }  
            }
        }
    }
}
