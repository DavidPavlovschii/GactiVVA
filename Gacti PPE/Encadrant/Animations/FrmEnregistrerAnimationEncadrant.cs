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
    public partial class EnregistrerAnimationEncadrant : Form
    {
        public EnregistrerAnimationEncadrant()
        {
            InitializeComponent();
            comboBoxCodeDuTypeAnimation.Items.AddRange(Donnees.GetLesTypesDAnimations().ToArray());
        }

        private void btnEnregistrerAnim_Click(object sender, EventArgs e)
        {
            if(rTextBCommentaire.Text == "" || rTextBDescriptif.Text == "" || textBCodeAnim.Text == "" || textBNomAnim.Text == "" || comboBoxCodeDuTypeAnimation.Text =="" )
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

                Animation uneAnimation = new Animation(textBCodeAnim.Text, comboBoxCodeDuTypeAnimation.Text, textBNomAnim.Text, dateCreationAnim, dateValiditeAnim, (double)numUpDwnDureeAnim.Value
                    , (int)numUpDwnLimiteAge.Value, numUpDwnTarif.Value, (int)numUpDwnNbrePlaceAnim.Value, rTextBDescriptif.Text, rTextBCommentaire.Text, cmbBoxDifficulteAnim.Text);
        

                if (Donnees.ExisteAnimation(uneAnimation) == false)
                {
                    if(Donnees.AjouterAnimation(uneAnimation) == true)
                    {
                        MessageBox.Show("L'animation " + uneAnimation.Code + " est bien enregistrée.");
                        this.Hide();
                        ConsulterModifierAnimationEncadrant cmae = new ConsulterModifierAnimationEncadrant();
                        cmae.ShowDialog();
                    }   
                }
                else
                {
                    MessageBox.Show("Une animation ayant pour code " + uneAnimation.Code + " existe déjà, veuillez saisir un nouveau code.");
                } 
            }
        }
    }
}
