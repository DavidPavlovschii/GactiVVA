namespace Gacti_PPE
{
    partial class AccueilEncadrant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccueilEncadrant));
            this.sideBar1 = new Gacti_PPE.Encadrant.SideBar();
            this.lb0BienvenueSurVotrePageDeProfil = new System.Windows.Forms.Label();
            this.lb0NomUtilisateur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sideBar1
            // 
            this.sideBar1.Location = new System.Drawing.Point(1, 2);
            this.sideBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sideBar1.Name = "sideBar1";
            this.sideBar1.Size = new System.Drawing.Size(97, 551);
            this.sideBar1.TabIndex = 0;
            // 
            // lb0BienvenueSurVotrePageDeProfil
            // 
            this.lb0BienvenueSurVotrePageDeProfil.AutoSize = true;
            this.lb0BienvenueSurVotrePageDeProfil.Location = new System.Drawing.Point(139, 11);
            this.lb0BienvenueSurVotrePageDeProfil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb0BienvenueSurVotrePageDeProfil.Name = "lb0BienvenueSurVotrePageDeProfil";
            this.lb0BienvenueSurVotrePageDeProfil.Size = new System.Drawing.Size(226, 17);
            this.lb0BienvenueSurVotrePageDeProfil.TabIndex = 2;
            this.lb0BienvenueSurVotrePageDeProfil.Text = "Bienvenu sur votre page de profil  ";
            // 
            // lb0NomUtilisateur
            // 
            this.lb0NomUtilisateur.AutoSize = true;
            this.lb0NomUtilisateur.Location = new System.Drawing.Point(372, 11);
            this.lb0NomUtilisateur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb0NomUtilisateur.Name = "lb0NomUtilisateur";
            this.lb0NomUtilisateur.Size = new System.Drawing.Size(129, 17);
            this.lb0NomUtilisateur.TabIndex = 3;
            this.lb0NomUtilisateur.Text = "{{nom d\'utilisateur]]";
            // 
            // AccueilEncadrant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 507);
            this.ControlBox = false;
            this.Controls.Add(this.lb0NomUtilisateur);
            this.Controls.Add(this.lb0BienvenueSurVotrePageDeProfil);
            this.Controls.Add(this.sideBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AccueilEncadrant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Encadrant.SideBar sideBar1;
        private System.Windows.Forms.Label lb0BienvenueSurVotrePageDeProfil;
        private System.Windows.Forms.Label lb0NomUtilisateur;
    }
}