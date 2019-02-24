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
    public partial class FrmProfilEncadrant : Form
    {
        public FrmProfilEncadrant()
        {
            InitializeComponent();
            lbUser.Text = Utilisateur.GetPseudo();
            lbNomCompte.Text = Utilisateur.GetNom();
            lbPrenomCompte.Text = Utilisateur.GetPrenom();
            lbDateInscrip.Text = Convert.ToString(Utilisateur.GetDateInsc());
            lbDateNaisCompte.Text = Convert.ToString(Utilisateur.GetDateNaiss());
            lbAdrMailCompte.Text = Utilisateur.GetAdresseMail();
            lbNoTelCompte.Text = Utilisateur.GetNoTelCompte();
        }
    }
}
