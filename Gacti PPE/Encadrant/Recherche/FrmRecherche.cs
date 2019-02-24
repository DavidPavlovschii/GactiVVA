using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gacti_PPE.Encadrant.Recherche;

namespace Gacti_PPE.Encadrant
{
    public partial class FrmRecherche : Form
    {
        public FrmRecherche()
        {
            InitializeComponent();
        }

        private void btnListerLesInscrits_Click(object sender, EventArgs e)
        {
            if (listBListeActivites.SelectedItem == null)
            {
                MessageBox.Show("Veuillez selectionner une activité pour avoir la liste des inscrits.");
            }
            else
            {
                Modification.SetActivite((Activite)listBListeActivites.SelectedItem);
                FrmListerInscrits frmListInsc = new FrmListerInscrits();
                frmListInsc.ShowDialog();
                listBListeActivites.SelectedIndex = -1;
            }
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            if (textBRechercher.Text == "")
            {
                MessageBox.Show("Veuillez saisir un code d'animation pour rechercher les activités associées ");
            }
            else 
            if (Donnees.GetLesActivitesCible(textBRechercher.Text.ToUpper()).Count() == 0 )
            {
                MessageBox.Show("Aucune activité n'est associée au code d'animation saisi, veuillez verifier que l'animation saisie existe.");
            }
            else
            {
                listBListeActivites.Items.Clear();
                listBListeActivites.Items.AddRange(Donnees.GetLesActivitesCible(textBRechercher.Text.ToUpper()).ToArray());
            }
            
        }

        private void FrmRecherche_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnRechercher;
        }
    }
}
