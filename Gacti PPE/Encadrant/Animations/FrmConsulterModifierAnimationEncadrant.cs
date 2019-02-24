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
    public partial class ConsulterModifierAnimationEncadrant : Form
    {
        public ConsulterModifierAnimationEncadrant()
        {
            InitializeComponent();
            List<Animation> listeAnimations = Donnees.GetLesAnimations();
            listBAnimation.Items.AddRange(listeAnimations.ToArray());
        }

        private void btnPlanningAnimation_Click(object sender, EventArgs e)
        {
            //voir si le planning affiché sera le meme que le planning de toutes les activités, ou bien si on doit afficher juste
            //les activités pour l'animation ciblée, dans ce cas on fera simplement un messagebox.show() avec les activités et leurs dates
            // prévuent pour cette animation
            if (listBAnimation.SelectedItem == null)
            {
                MessageBox.Show("Veuillez selectionner une animation pour consulter la liste des activités qui y sont liées.");
            }
            else
            {
                Animation animation = (Animation)listBAnimation.SelectedItem;
                Modification.SetAnimation(animation);
                PlanningDesActivitesPourUneSeuleAnimation planAnimEnc = new PlanningDesActivitesPourUneSeuleAnimation();
                planAnimEnc.ShowDialog();
            }
        }

        private void btnModifierAnimation_Click(object sender, EventArgs e)
        {
            if(listBAnimation.SelectedItem == null)
            {
                MessageBox.Show("Veuillez selectionner une animation à modifier.");
            }
            else
            {
                Animation animation = (Animation)listBAnimation.SelectedItem;
                Modification.SetAnimation(animation);
                ModifierAnimationEncadrant modifAnimEnc = new ModifierAnimationEncadrant();
                modifAnimEnc.ShowDialog();
                this.Close();
                
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
                                "\rTarif: " + animation.Tarif.ToString() + " € " +
                                "\r " +
                                "\rNombre de places maximum : " + animation.NbrePlace.ToString() +
                                "\r " +
                                "\rAge minimum : " + animation.LimiteAge.ToString() +
                                "\r " +
                                "\rDurée : " + animation.Duree.ToString() +
                                "\r " +
                                "\rDate de création : " + animation.DateCreation.Substring(0, 10) +
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
