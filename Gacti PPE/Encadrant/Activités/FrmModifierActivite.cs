using Gacti_PPE.Encadrant;
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
    public partial class ModifierActivite : Form
    {
        public ModifierActivite()
        {
            InitializeComponent();
            comboBCodeAnimation.Items.AddRange(Donnees.GetLesAnimations().ToArray());
            dtPickerDateAct.Text = Modification.GetActvite().DateAct;
            dtPickerHrRdv.Text = Modification.GetActvite().HrRdvAct;
            numUpDwnPrixAct.Value = Modification.GetActvite().PrixActe;
            dtPickerHrDebut.Text = Modification.GetActvite().HrDebutAct;
            dtPickerHrFin.Text = Modification.GetActvite().HrFinAct;
            cmbBoxResponsable.Items.AddRange(Donnees.GetListeEncadrant().ToArray());
            dtPickerAnnulActivite.Text = Modification.GetActvite().DateAnnuleAct;
            comboBCodeEtatAct.Items.AddRange(Donnees.GetLesEtatsDActivite().ToArray());
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
                if (dtPickerHrDebut.Value > dtPickerHrFin.Value)
                {
                    MessageBox.Show("L'activité ne peut pas démarrer après avoir terminé.");
                }
                else 
                if (dtPickerAnnulActivite.Value > dtPickerDateAct.Value)
                {
                    MessageBox.Show("La date d'annulation doit avoir lieu après la date de l'activité ");
                }

                #endregion

                else
                {
                    String dateAct = dtPickerDateAct.Value.ToString("yyyy:MM:dd").Replace(":", "-");
                    String dateAnnulAct = dtPickerAnnulActivite.Value.ToString("yyyy:MM:dd").Replace(":", "-");
                    string codeAnim = comboBCodeAnimation.SelectedItem.ToString();
                    string codeEtatAct = comboBCodeEtatAct.SelectedItem.ToString();

                    string hrRdvAct = dtPickerHrRdv.Value.ToString("HH:mm:ss");
                    Decimal prixActe = numUpDwnPrixAct.Value;

                    //Récupere l'heure du datetimepicker
                    string hrDebutAct = dtPickerHrDebut.Value.ToString("HH:mm:ss"); ;
                    string hrFinAct = dtPickerHrFin.Value.ToString("HH:mm:ss");

                    //split du nom en tableau de string puis récuperation de chaque champ
                    string[] tmp = cmbBoxResponsable.Text.Split(' ');
                    string nomResp = tmp[1];
                    string prenomRes = tmp[0];

                    Activite uneActivite = new Activite(codeAnim, dateAct, codeEtatAct, hrRdvAct, prixActe, hrDebutAct, hrFinAct, dateAnnulAct, nomResp, prenomRes);
                    if (uneActivite.CodeAnim != Modification.GetActvite().CodeAnim)
                    {
                        if (Donnees.ExisteActivite(uneActivite) == false)
                        {
                            if (Donnees.ModifierActivite(uneActivite) == true)
                            {
                                MessageBox.Show("L'activité " + Modification.GetActvite().ToString() + " à bien été modifiée en :\n " + uneActivite.ToString());
                                ConsulterModifierActiviteEncadrant cmActE = new ConsulterModifierActiviteEncadrant();
                                cmActE.Show();
                                this.Close();

                            }

                            else
                            {
                                MessageBox.Show("Une erreur est survenue lors de la modification.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("L'activité " + uneActivite.CodeAnim + " existe déjà à la date " + uneActivite.DateAct + " veuillez en choisir une autre.");
                        }

                    }

                    else
                    {
                        if (Donnees.ModifierActivite(uneActivite) == true)
                        {
                            MessageBox.Show("L'activité " + Modification.GetActvite().ToString() + " à bien été modifiée en :\n " + uneActivite.ToString());
                            ConsulterModifierActiviteEncadrant cmActE = new ConsulterModifierActiviteEncadrant();
                            cmActE.ShowDialog();
                            this.Hide();
                        }

                        else
                        {
                            MessageBox.Show("Une erreur est survenue lors de la modification.");
                        }
                    }
                }
                 
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            ConsulterModifierActiviteEncadrant cmActE = new ConsulterModifierActiviteEncadrant();
            cmActE.Show();
            this.Close();
        }
    }
}
