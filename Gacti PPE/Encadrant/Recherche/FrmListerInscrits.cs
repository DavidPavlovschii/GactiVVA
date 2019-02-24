using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gacti_PPE.Encadrant.Recherche
{
    public partial class FrmListerInscrits : Form
    {
        public FrmListerInscrits()
        {
            InitializeComponent();

            List<Vacanciere> listeInscrits = Donnees.GetLesInscritsAUneActivite(Modification.GetActvite());
            listBListeVacanciers.Items.AddRange(listeInscrits.ToArray());
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAfficherDetail_Click(object sender, EventArgs e)
        {
            if (listBListeVacanciers.SelectedItem == null)
            {
                MessageBox.Show("Veuillez selectionner un vacancier pour en obtenir le détail.");
            }
            else
            {
                Vacanciere uneVacanciere = (Vacanciere) listBListeVacanciers.SelectedItem;
                MessageBox.Show(uneVacanciere.GetInformations());
            }
        }
    }
}
