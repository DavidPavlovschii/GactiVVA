using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gacti_PPE.Vacancier
{
    public partial class SideBarVacancier : UserControl
    {
        public SideBarVacancier()
        {
            InitializeComponent();
        }

        private void tSBtnAccueilVacancier_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Hide();
            AccueilVacancier accVac = new AccueilVacancier();
            accVac.ShowDialog();
        }

        private void tSBProfilVacancier_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Hide();
            ProfilVacancier profilVac = new ProfilVacancier();
            profilVac.ShowDialog();
        }

        private void tSBtnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tSBAnimationsVacancier_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Hide();
            AnimationsVacancier aniVac = new AnimationsVacancier();
            aniVac.ShowDialog();
        }

        private void tSBInscActivitVacancier_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Hide();
            FrmPlanningActiviteVacancier planActVac = new FrmPlanningActiviteVacancier();
            planActVac.ShowDialog();
        }
    }
}
