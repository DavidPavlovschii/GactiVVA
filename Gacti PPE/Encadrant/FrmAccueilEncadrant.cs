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
    public partial class AccueilEncadrant : Form
    {
        public AccueilEncadrant()
        {
            InitializeComponent();
            lb0NomUtilisateur.Text = Utilisateur.GetNom();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Utilisateur.GetInfos());
        }
    }
}
