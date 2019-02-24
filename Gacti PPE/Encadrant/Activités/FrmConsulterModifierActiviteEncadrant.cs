using Gacti_PPE.Encadrant.Recherche;
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
    public partial class ConsulterModifierActiviteEncadrant : Form
    {
        public ConsulterModifierActiviteEncadrant()
        {
            InitializeComponent();
            
            foreach (Activite uneActivite in Donnees.GetLesActivites())
            {
                if(uneActivite.CodeEtatAct != "AN")
                {
                    uneActivite.DateAct = uneActivite.DateAct; //affiche la date au bon format (vire le hh:mm:ss)
                    DayOfWeek dow = Convert.ToDateTime(uneActivite.DateAct).DayOfWeek; //récupere la date du jours sous forme de string

                    switch (dow)
                    {
                        case DayOfWeek.Monday:
                            listBLundi.Items.Add(uneActivite);
                            break;

                        case DayOfWeek.Tuesday:
                            listBMardi.Items.Add(uneActivite);
                            break;

                        case DayOfWeek.Wednesday:
                            listBMercredi.Items.Add(uneActivite);
                            break;

                        case DayOfWeek.Thursday:
                            listBJeudi.Items.Add(uneActivite);
                            break;

                        case DayOfWeek.Friday:
                            listBVendredi.Items.Add(uneActivite);
                            break;

                        case DayOfWeek.Saturday:
                            listBSamedi.Items.Add(uneActivite);
                            break;

                        case DayOfWeek.Sunday:
                            listBDimanche.Items.Add(uneActivite);
                            break;
                    }
                }
            }
        }
        /// <summary>
        /// Permet (normalement) d'avoir un seul item selectionné à la fois dans les listebox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox thisListBox = sender as ListBox;
            if (thisListBox == null || thisListBox.SelectedIndex == 0)
            {
                return;
            }

            foreach (ListBox loopListBox in this.Controls)
            {
                if (thisListBox != loopListBox)
                {
                    loopListBox.SelectedIndex = -1;
                }
            }
        } //ne fonctionne pas

        private void btnModifierActivite_Click(object sender, EventArgs e)
        {
            int cptListBVide = 0;
            foreach(ListBox uneListB in panJourSemaine.Controls )
            {
                ListBox thisListBox = sender as ListBox;
                if (uneListB.SelectedItem == null)
                {
                    cptListBVide++;
                }
                else
                {
                    Activite activite = (Activite)uneListB.SelectedItem;
                    Modification.SetActivite(activite);
                    ModifierActivite modifAct = new ModifierActivite();
                    modifAct.ShowDialog();
                    this.Close();
                }
            }

            if (cptListBVide == 7)
            {
                MessageBox.Show("Veuillez selectionner une activité à modifier.");
            }
            
        }

        private void btnListerInscritsActivite_Click(object sender, EventArgs e)
        {
            int cptListBVide = 0;
            foreach (ListBox uneListB in panJourSemaine.Controls)
            {
                if (uneListB.SelectedItem == null)
                {
                    cptListBVide++;
                }
                else
                {
                    Modification.SetActivite((Activite)uneListB.SelectedItem);
                    FrmListerInscrits frmListInsc = new FrmListerInscrits();
                    frmListInsc.ShowDialog();
                    uneListB.SelectedIndex = -1;
                }
            }

            if (cptListBVide == 7)
            {
                MessageBox.Show("Veuillez selectionner une animation à annuler.");
            }
        }

        private void btnAnnulerActivite_Click(object sender, EventArgs e)
        {
            int cptListBVide = 0;
            foreach (ListBox uneListB in panJourSemaine.Controls)
            {
                if (uneListB.SelectedItem == null)
                {
                    cptListBVide++;
                }
                else
                {
                    Activite activite = (Activite)uneListB.SelectedItem;
                    Modification.SetActivite(activite);
                    if (Donnees.AnnulerActivite(activite))
                    {
                        ConsulterModifierActiviteEncadrant cmae = new ConsulterModifierActiviteEncadrant();
                        cmae.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Annulation foirée");
                    }
                    
                }
            }

            if (cptListBVide == 7)
            {
                MessageBox.Show("Veuillez selectionner une animation à annuler.");
            }
        }

        private void btnInfoUtilisation_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pour modifier une activité, cliquer sur l'activité de votre choix puis cliquer sur le bouton 'Modifier'. \r" +
                            "\r" +
                            "Pour annuler une activité, cliquer sur l'activité de votre choix puis cliquer sur le bouton 'Annuler'. \r" +
                            "\r" +
                            "Pour lister les vacanciers inscrits à une activité, cliquer sur l'activité de votre choix puis cliquer sur le bouton 'Lister les inscrits'. ");
        }
    }
}
