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
    public partial class ModifierAnimationEncadrant : Form
    {
        private Animation uneAnimation = Modification.GetAnimation();

        public ModifierAnimationEncadrant() //voir pq l'objet est NULL au moment de l'initialisation
        {
            InitializeComponent();
            comboBoxCodeDuTypeAnimation.Items.AddRange(Donnees.GetLesTypesDAnimations().ToArray());
            textBCodeAnim.Text = uneAnimation.Code;
            textBNomAnim.Text = uneAnimation.Nom;
            dtTimePickerDateValiditeAnim.Text = uneAnimation.DateValidite.ToString();
            numUpDwnDureeAnim.Value = (decimal)uneAnimation.Duree;
            numUpDwnTarif.Value = (decimal)uneAnimation.Tarif;
            numUpDwnLimiteAge.Value = (decimal)uneAnimation.LimiteAge;
            numUpDwnNbrePlaceAnim.Value = (decimal)uneAnimation.NbrePlace;
            cmbBoxDifficulteAnim.Text = uneAnimation.Difficulte;
            rTextBDescriptif.Text = uneAnimation.Description;
            rTextBCommentaire.Text = uneAnimation.Comment;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            ConsulterModifierAnimationEncadrant caem = new ConsulterModifierAnimationEncadrant();
            caem.Show();
            this.Close();
        }

        private void btnEnregistrerModifAnim_Click(object sender, EventArgs e) 
        {
            if (rTextBCommentaire.Text == "" || rTextBDescriptif.Text == "" || textBCodeAnim.Text == "" || textBNomAnim.Text == "" || comboBoxCodeDuTypeAnimation.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
            }
            else
            {
                DateTime datevalue = DateTime.Now;

                String jourActuelle = datevalue.Day.ToString();
                String moisActuelle = datevalue.Month.ToString();
                String anneeActuelle = datevalue.Year.ToString();

                String dateCreationAnim = anneeActuelle + "-" + moisActuelle + "-" + jourActuelle;

                String jourValiditeAnim = Convert.ToString(dtTimePickerDateValiditeAnim.Value.Day);
                String moisValiditeAnim = Convert.ToString(dtTimePickerDateValiditeAnim.Value.Month);
                String anneeValiditeAnim = Convert.ToString(dtTimePickerDateValiditeAnim.Value.Year);

                String dateValiditeAnim = anneeValiditeAnim + "-" + moisValiditeAnim + "-" + jourValiditeAnim;

                Animation modifAnimation = new Animation(textBCodeAnim.Text, comboBoxCodeDuTypeAnimation.Text, textBNomAnim.Text, dateCreationAnim, dateValiditeAnim, (double)numUpDwnDureeAnim.Value
                    , (int)numUpDwnLimiteAge.Value, numUpDwnTarif.Value, (int)numUpDwnNbrePlaceAnim.Value, rTextBDescriptif.Text, rTextBCommentaire.Text, cmbBoxDifficulteAnim.Text);

                if (Donnees.ExisteAnimation(modifAnimation) == false)
                {
                    if (Donnees.ModifierAnimation(modifAnimation) == true)
                    {
                        MessageBox.Show("L'animation " + modifAnimation.Code + " est bien modifiée.");
                        ConsulterModifierAnimationEncadrant caem = new ConsulterModifierAnimationEncadrant();
                        caem.Show();
                        this.Close();
                    }     
                     else
                        MessageBox.Show("Erreur " + modifAnimation.Code + " veuillez réessayer.");
                }
                else
                {
                    MessageBox.Show("Une animation ayant pour code " + modifAnimation.Code + " existe déjà, veuillez saisir un nouveau code.");
                }
            }
        }
    }
}
