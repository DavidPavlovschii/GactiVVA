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
    public partial class FrmPlanningActiviteVacancier : Form
    {
        public FrmPlanningActiviteVacancier()
        {
            InitializeComponent();
            foreach (Activite uneActivite in Donnees.GetLesActivitesInscripVacancier())
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
                    Donnees.AnnulerInscriptionActivite(activite);
                    FrmPlanningActiviteVacancier planActVac = new FrmPlanningActiviteVacancier();
                    planActVac.Show();
                    this.Close();
                }
            }

            if (cptListBVide == 7)
            {
                MessageBox.Show("Veuillez selectionner une inscription à annuler.");
            }
        }

        private void btnPlusDInformations_Click(object sender, EventArgs e)
        {

        }
    }
}
