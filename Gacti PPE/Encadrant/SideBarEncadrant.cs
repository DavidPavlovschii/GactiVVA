using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gacti_PPE.Encadrant
{
    public partial class SideBar : UserControl
    {
        public SideBar()
        {
            InitializeComponent();
        }


        //Routes


        //
        // Accueil et profil encadrant
        //
        private void tSBtnAccueilEncadrant_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Hide();
            AccueilEncadrant accEnc = new AccueilEncadrant();
            accEnc.ShowDialog();
        }

        private void tSBProfilEncadrant_Click_1(object sender, EventArgs e)
        {
            Form.ActiveForm.Hide();
            FrmProfilEncadrant profEnc = new FrmProfilEncadrant();
            profEnc.ShowDialog();
        }

        //
        // Animations Encadrant
        //
        private void consulterLesAnimationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Hide();
            ConsulterModifierAnimationEncadrant consuModifAnimEnc = new ConsulterModifierAnimationEncadrant();
            consuModifAnimEnc.ShowDialog();
        }

        private void enregistrerUneAnimationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Hide();
            EnregistrerAnimationEncadrant enregiAnimEnc = new EnregistrerAnimationEncadrant();
            enregiAnimEnc.ShowDialog();
        }

        //
        // Activités Encadrant
        //
        private void consulterLesActivitésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Hide();
            ConsulterModifierActiviteEncadrant consuModifActiEnc = new ConsulterModifierActiviteEncadrant();
            consuModifActiEnc.ShowDialog();
        }

        private void créerUneActivitéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Hide();
            EnregistrerActiviteEncadrant enregiActiEnc = new EnregistrerActiviteEncadrant();
            enregiActiEnc.ShowDialog();
        }

        private void tSBtnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Hide();
            FrmRecherche frmRech = new FrmRecherche();
            frmRech.ShowDialog();
        }
    }
}
