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
    public partial class ProfilVacancier : Form
    {
        public ProfilVacancier()
        {
            InitializeComponent();
            lb0NomUtilisateur.Text = Utilisateur.GetPseudo();
            lbUser.Text = Utilisateur.GetPseudo();
            lbNomCompte.Text = Utilisateur.GetNom();
            lbPrenomCompte.Text = Utilisateur.GetPrenom();
            lbDateInscrip.Text = Convert.ToString(Utilisateur.GetDateInsc()).Substring(0,10);
            lbDateNaisCompte.Text = Convert.ToString(Utilisateur.GetDateNaiss()).Substring(0,10);
            lbDateFerme.Text = Convert.ToString(Utilisateur.GetDateFerme()).Substring(0, 10);
            lbAdrMailCompte.Text = Utilisateur.GetAdresseMail();
            lbNoTelCompte.Text = Utilisateur.GetNoTelCompte();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Utilisateur.GetInfos());
        }
    }
}
