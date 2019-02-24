namespace Gacti_PPE.Vacancier
{
    partial class AnimationsVacancier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimationsVacancier));
            this.sideBarVacancier1 = new Gacti_PPE.Vacancier.SideBarVacancier();
            this.listBAnimation = new System.Windows.Forms.ListBox();
            this.btnPlanningAnimation = new System.Windows.Forms.Button();
            this.btnAfficherInfoAnimation = new System.Windows.Forms.Button();
            this.lbConsulterModifierUneAnimation = new System.Windows.Forms.Label();
            this.lbListeAnimations = new System.Windows.Forms.Label();
            this.lbInfosUtilisateur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sideBarVacancier1
            // 
            this.sideBarVacancier1.Location = new System.Drawing.Point(-1, 2);
            this.sideBarVacancier1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sideBarVacancier1.Name = "sideBarVacancier1";
            this.sideBarVacancier1.Size = new System.Drawing.Size(74, 453);
            this.sideBarVacancier1.TabIndex = 1;
            // 
            // listBAnimation
            // 
            this.listBAnimation.FormattingEnabled = true;
            this.listBAnimation.Location = new System.Drawing.Point(218, 103);
            this.listBAnimation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBAnimation.Name = "listBAnimation";
            this.listBAnimation.Size = new System.Drawing.Size(227, 264);
            this.listBAnimation.TabIndex = 15;
            // 
            // btnPlanningAnimation
            // 
            this.btnPlanningAnimation.Location = new System.Drawing.Point(492, 147);
            this.btnPlanningAnimation.Name = "btnPlanningAnimation";
            this.btnPlanningAnimation.Size = new System.Drawing.Size(108, 38);
            this.btnPlanningAnimation.TabIndex = 14;
            this.btnPlanningAnimation.Text = "Planning des activités";
            this.btnPlanningAnimation.UseVisualStyleBackColor = true;
            this.btnPlanningAnimation.Click += new System.EventHandler(this.btnPlanningAnimation_Click);
            // 
            // btnAfficherInfoAnimation
            // 
            this.btnAfficherInfoAnimation.Location = new System.Drawing.Point(492, 103);
            this.btnAfficherInfoAnimation.Name = "btnAfficherInfoAnimation";
            this.btnAfficherInfoAnimation.Size = new System.Drawing.Size(108, 38);
            this.btnAfficherInfoAnimation.TabIndex = 11;
            this.btnAfficherInfoAnimation.Text = "Afficher informations ";
            this.btnAfficherInfoAnimation.UseVisualStyleBackColor = true;
            this.btnAfficherInfoAnimation.Click += new System.EventHandler(this.btnAfficherInfoAnimation_Click);
            // 
            // lbConsulterModifierUneAnimation
            // 
            this.lbConsulterModifierUneAnimation.AutoSize = true;
            this.lbConsulterModifierUneAnimation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsulterModifierUneAnimation.Location = new System.Drawing.Point(79, 10);
            this.lbConsulterModifierUneAnimation.Name = "lbConsulterModifierUneAnimation";
            this.lbConsulterModifierUneAnimation.Size = new System.Drawing.Size(174, 20);
            this.lbConsulterModifierUneAnimation.TabIndex = 10;
            this.lbConsulterModifierUneAnimation.Text = "Liste des animations";
            // 
            // lbListeAnimations
            // 
            this.lbListeAnimations.AutoSize = true;
            this.lbListeAnimations.Location = new System.Drawing.Point(92, 104);
            this.lbListeAnimations.Name = "lbListeAnimations";
            this.lbListeAnimations.Size = new System.Drawing.Size(111, 13);
            this.lbListeAnimations.TabIndex = 9;
            this.lbListeAnimations.Text = "Liste des animations : ";
            // 
            // lbInfosUtilisateur
            // 
            this.lbInfosUtilisateur.AutoSize = true;
            this.lbInfosUtilisateur.Location = new System.Drawing.Point(79, 47);
            this.lbInfosUtilisateur.Name = "lbInfosUtilisateur";
            this.lbInfosUtilisateur.Size = new System.Drawing.Size(599, 13);
            this.lbInfosUtilisateur.TabIndex = 13;
            this.lbInfosUtilisateur.Text = "Cliquez sur une animation puis cliquez sur un des boutons pour modifier ou affich" +
    "er les informations de l\'animation sélectionnée";
            // 
            // AnimationsVacancier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 416);
            this.ControlBox = false;
            this.Controls.Add(this.listBAnimation);
            this.Controls.Add(this.btnPlanningAnimation);
            this.Controls.Add(this.lbInfosUtilisateur);
            this.Controls.Add(this.btnAfficherInfoAnimation);
            this.Controls.Add(this.lbConsulterModifierUneAnimation);
            this.Controls.Add(this.lbListeAnimations);
            this.Controls.Add(this.sideBarVacancier1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnimationsVacancier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Animations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SideBarVacancier sideBarVacancier1;
        private System.Windows.Forms.ListBox listBAnimation;
        private System.Windows.Forms.Button btnPlanningAnimation;
        private System.Windows.Forms.Button btnAfficherInfoAnimation;
        private System.Windows.Forms.Label lbConsulterModifierUneAnimation;
        private System.Windows.Forms.Label lbListeAnimations;
        private System.Windows.Forms.Label lbInfosUtilisateur;
    }
}