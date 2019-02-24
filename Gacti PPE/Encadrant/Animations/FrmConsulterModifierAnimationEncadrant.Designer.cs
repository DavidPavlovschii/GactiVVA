namespace Gacti_PPE.Encadrant
{
    partial class ConsulterModifierAnimationEncadrant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsulterModifierAnimationEncadrant));
            this.lbListeAnimations = new System.Windows.Forms.Label();
            this.lbConsulterModifierUneAnimation = new System.Windows.Forms.Label();
            this.btnAfficherInfoAnimation = new System.Windows.Forms.Button();
            this.btnModifierAnimation = new System.Windows.Forms.Button();
            this.lbInfosUtilisateur = new System.Windows.Forms.Label();
            this.btnPlanningAnimation = new System.Windows.Forms.Button();
            this.listBAnimation = new System.Windows.Forms.ListBox();
            this.sideBar1 = new Gacti_PPE.Encadrant.SideBar();
            this.SuspendLayout();
            // 
            // lbListeAnimations
            // 
            this.lbListeAnimations.AutoSize = true;
            this.lbListeAnimations.Location = new System.Drawing.Point(144, 105);
            this.lbListeAnimations.Name = "lbListeAnimations";
            this.lbListeAnimations.Size = new System.Drawing.Size(111, 13);
            this.lbListeAnimations.TabIndex = 2;
            this.lbListeAnimations.Text = "Liste des animations : ";
            // 
            // lbConsulterModifierUneAnimation
            // 
            this.lbConsulterModifierUneAnimation.AutoSize = true;
            this.lbConsulterModifierUneAnimation.Location = new System.Drawing.Point(131, 11);
            this.lbConsulterModifierUneAnimation.Name = "lbConsulterModifierUneAnimation";
            this.lbConsulterModifierUneAnimation.Size = new System.Drawing.Size(167, 13);
            this.lbConsulterModifierUneAnimation.TabIndex = 3;
            this.lbConsulterModifierUneAnimation.Text = "Consulter / modifier une animation";
            // 
            // btnAfficherInfoAnimation
            // 
            this.btnAfficherInfoAnimation.Location = new System.Drawing.Point(544, 104);
            this.btnAfficherInfoAnimation.Name = "btnAfficherInfoAnimation";
            this.btnAfficherInfoAnimation.Size = new System.Drawing.Size(108, 38);
            this.btnAfficherInfoAnimation.TabIndex = 4;
            this.btnAfficherInfoAnimation.Text = "Afficher informations ";
            this.btnAfficherInfoAnimation.UseVisualStyleBackColor = true;
            this.btnAfficherInfoAnimation.Click += new System.EventHandler(this.btnAfficherInfoAnimation_Click);
            // 
            // btnModifierAnimation
            // 
            this.btnModifierAnimation.Location = new System.Drawing.Point(544, 148);
            this.btnModifierAnimation.Name = "btnModifierAnimation";
            this.btnModifierAnimation.Size = new System.Drawing.Size(108, 38);
            this.btnModifierAnimation.TabIndex = 5;
            this.btnModifierAnimation.Text = "Modifier";
            this.btnModifierAnimation.UseVisualStyleBackColor = true;
            this.btnModifierAnimation.Click += new System.EventHandler(this.btnModifierAnimation_Click);
            // 
            // lbInfosUtilisateur
            // 
            this.lbInfosUtilisateur.AutoSize = true;
            this.lbInfosUtilisateur.Location = new System.Drawing.Point(131, 48);
            this.lbInfosUtilisateur.Name = "lbInfosUtilisateur";
            this.lbInfosUtilisateur.Size = new System.Drawing.Size(599, 13);
            this.lbInfosUtilisateur.TabIndex = 6;
            this.lbInfosUtilisateur.Text = "Cliquez sur une animation puis cliquez sur un des boutons pour modifier ou affich" +
    "er les informations de l\'animation sélectionnée";
            // 
            // btnPlanningAnimation
            // 
            this.btnPlanningAnimation.Location = new System.Drawing.Point(544, 192);
            this.btnPlanningAnimation.Name = "btnPlanningAnimation";
            this.btnPlanningAnimation.Size = new System.Drawing.Size(108, 38);
            this.btnPlanningAnimation.TabIndex = 7;
            this.btnPlanningAnimation.Text = "Planning des activités";
            this.btnPlanningAnimation.UseVisualStyleBackColor = true;
            this.btnPlanningAnimation.Click += new System.EventHandler(this.btnPlanningAnimation_Click);
            // 
            // listBAnimation
            // 
            this.listBAnimation.FormattingEnabled = true;
            this.listBAnimation.Location = new System.Drawing.Point(270, 104);
            this.listBAnimation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBAnimation.Name = "listBAnimation";
            this.listBAnimation.Size = new System.Drawing.Size(227, 264);
            this.listBAnimation.TabIndex = 8;
            // 
            // sideBar1
            // 
            this.sideBar1.Location = new System.Drawing.Point(1, 0);
            this.sideBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sideBar1.Name = "sideBar1";
            this.sideBar1.Size = new System.Drawing.Size(95, 439);
            this.sideBar1.TabIndex = 0;
            // 
            // ConsulterModifierAnimationEncadrant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.listBAnimation);
            this.Controls.Add(this.btnPlanningAnimation);
            this.Controls.Add(this.lbInfosUtilisateur);
            this.Controls.Add(this.btnModifierAnimation);
            this.Controls.Add(this.btnAfficherInfoAnimation);
            this.Controls.Add(this.lbConsulterModifierUneAnimation);
            this.Controls.Add(this.lbListeAnimations);
            this.Controls.Add(this.sideBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsulterModifierAnimationEncadrant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulter / modifier une animation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SideBar sideBar1;
        private System.Windows.Forms.Label lbListeAnimations;
        private System.Windows.Forms.Label lbConsulterModifierUneAnimation;
        private System.Windows.Forms.Button btnAfficherInfoAnimation;
        private System.Windows.Forms.Button btnModifierAnimation;
        private System.Windows.Forms.Label lbInfosUtilisateur;
        private System.Windows.Forms.Button btnPlanningAnimation;
        private System.Windows.Forms.ListBox listBAnimation;
    }
}