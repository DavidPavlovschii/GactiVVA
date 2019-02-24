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
    public partial class AnimationsVacancier : Form
    {
        public AnimationsVacancier()
        {
            InitializeComponent();
            List<Animation> listeAnimations = Donnees.GetLesAnimations();
            listBAnimation.Items.AddRange(listeAnimations.ToArray());
        }

        private void btnPlanningAnimation_Click(object sender, EventArgs e)
        {
            if (listBAnimation.SelectedItem == null)
            {
                MessageBox.Show("Veuillez selectionner une animation pour consulter la liste des activités qui y sont liées.");
            }
            else
            {
                Animation animation = (Animation)listBAnimation.SelectedItem;
                Modification.SetAnimation(animation);
                ActivitesVacancier activac = new ActivitesVacancier();
                activac.ShowDialog();
            }
            
        }

        private void btnAfficherInfoAnimation_Click(object sender, EventArgs e)
        {
            if (listBAnimation.SelectedItem == null)
            {
                MessageBox.Show("Veuillez selectionner une animation pour avoir le détail de ses informations.");
            }
            else
            {
                Animation animation = (Animation)listBAnimation.SelectedItem;

                MessageBox.Show(" Code : " + animation.Code +
                                "\r " +
                                "\rCode type :  " + animation.CodeType +
                                "\r " +
                                "\rNom : " + animation.Nom +
                                "\r " +
                                "\rTarif: " + animation.Tarif.ToString() + " €" +
                                "\r " +
                                "\rNombre de places : " + animation.NbrePlace.ToString() +
                                "\r " +
                                "\rAge minimum : " + animation.LimiteAge.ToString() +
                                "\r " +
                                "\rDuree : " + animation.Duree.ToString() +
                                "\r " +
                                "\rDate de création : " + animation.DateCreation.Substring(0,10) +
                                "\r " +
                                "\rValide jusqu'à la date : " + animation.DateValidite.Substring(0, 10) +
                                "\r " +
                                "\rDescription : " + animation.Description +
                                "\r " +
                                "\rCommentaire : " + animation.Comment
                                );
            }
        }
    }
}
