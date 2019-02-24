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
    public partial class PlanningDesActivitesPourUneSeuleAnimation : Form
    {
        public PlanningDesActivitesPourUneSeuleAnimation()
        {
            InitializeComponent();
            Animation tmpAnimation = Modification.GetAnimation();
            lbNomAnimation.Text = tmpAnimation.Nom;
            List<Activite> listeActivites = Donnees.GetLesActivitesPourUneAnimation(tmpAnimation);
            listBPlanningActivitesPourUneAnimation.Items.AddRange(listeActivites.ToArray());
            if(listBPlanningActivitesPourUneAnimation.Items.Count == 0)
            {
                string msg = "Aucune activité n'existe pour l'animation " + tmpAnimation.Code;
                listBPlanningActivitesPourUneAnimation.Items.Add(msg);
            }

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
