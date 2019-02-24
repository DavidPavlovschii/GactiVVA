namespace Gacti_PPE.Vacancier
{
    partial class SideBarVacancier
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SideBarVacancier));
            this.tSEncadrant = new System.Windows.Forms.ToolStrip();
            this.tSBtnAccueilVacancier = new System.Windows.Forms.ToolStripButton();
            this.tSBProfilVacancier = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tSBAnimationsVacancier = new System.Windows.Forms.ToolStripButton();
            this.tSBPlanningActivitVacancier = new System.Windows.Forms.ToolStripButton();
            this.tSBtnQuitter = new System.Windows.Forms.ToolStripButton();
            this.tSEncadrant.SuspendLayout();
            this.SuspendLayout();
            // 
            // tSEncadrant
            // 
            this.tSEncadrant.Dock = System.Windows.Forms.DockStyle.Left;
            this.tSEncadrant.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tSEncadrant.ImageScalingSize = new System.Drawing.Size(60, 60);
            this.tSEncadrant.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSBtnAccueilVacancier,
            this.tSBProfilVacancier,
            this.toolStripSeparator1,
            this.tSBAnimationsVacancier,
            this.tSBPlanningActivitVacancier,
            this.tSBtnQuitter});
            this.tSEncadrant.Location = new System.Drawing.Point(0, 0);
            this.tSEncadrant.Name = "tSEncadrant";
            this.tSEncadrant.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tSEncadrant.Size = new System.Drawing.Size(65, 546);
            this.tSEncadrant.TabIndex = 2;
            this.tSEncadrant.Text = "Activités";
            // 
            // tSBtnAccueilVacancier
            // 
            this.tSBtnAccueilVacancier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBtnAccueilVacancier.Image = ((System.Drawing.Image)(resources.GetObject("tSBtnAccueilVacancier.Image")));
            this.tSBtnAccueilVacancier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnAccueilVacancier.Name = "tSBtnAccueilVacancier";
            this.tSBtnAccueilVacancier.Size = new System.Drawing.Size(62, 64);
            this.tSBtnAccueilVacancier.Text = "Accueil";
            this.tSBtnAccueilVacancier.Click += new System.EventHandler(this.tSBtnAccueilVacancier_Click);
            // 
            // tSBProfilVacancier
            // 
            this.tSBProfilVacancier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBProfilVacancier.Image = global::Gacti_PPE.Properties.Resources.user;
            this.tSBProfilVacancier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBProfilVacancier.Name = "tSBProfilVacancier";
            this.tSBProfilVacancier.Size = new System.Drawing.Size(62, 64);
            this.tSBProfilVacancier.Text = "Profil";
            this.tSBProfilVacancier.Click += new System.EventHandler(this.tSBProfilVacancier_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(62, 6);
            // 
            // tSBAnimationsVacancier
            // 
            this.tSBAnimationsVacancier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBAnimationsVacancier.Image = global::Gacti_PPE.Properties.Resources.Alpine_Skiing_icon;
            this.tSBAnimationsVacancier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBAnimationsVacancier.Name = "tSBAnimationsVacancier";
            this.tSBAnimationsVacancier.Size = new System.Drawing.Size(62, 64);
            this.tSBAnimationsVacancier.Text = "Animations";
            this.tSBAnimationsVacancier.Click += new System.EventHandler(this.tSBAnimationsVacancier_Click);
            // 
            // tSBPlanningActivitVacancier
            // 
            this.tSBPlanningActivitVacancier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBPlanningActivitVacancier.Image = global::Gacti_PPE.Properties.Resources.Calendar_icon1;
            this.tSBPlanningActivitVacancier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBPlanningActivitVacancier.Name = "tSBPlanningActivitVacancier";
            this.tSBPlanningActivitVacancier.Size = new System.Drawing.Size(62, 64);
            this.tSBPlanningActivitVacancier.Text = "Mon planning";
            this.tSBPlanningActivitVacancier.Click += new System.EventHandler(this.tSBInscActivitVacancier_Click);
            // 
            // tSBtnQuitter
            // 
            this.tSBtnQuitter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBtnQuitter.Image = global::Gacti_PPE.Properties.Resources.icons8_sortie_48;
            this.tSBtnQuitter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnQuitter.Name = "tSBtnQuitter";
            this.tSBtnQuitter.Size = new System.Drawing.Size(62, 64);
            this.tSBtnQuitter.Text = "Quitter";
            this.tSBtnQuitter.Click += new System.EventHandler(this.tSBtnQuitter_Click);
            // 
            // SideBarVacancier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tSEncadrant);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SideBarVacancier";
            this.Size = new System.Drawing.Size(99, 546);
            this.tSEncadrant.ResumeLayout(false);
            this.tSEncadrant.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tSEncadrant;
        private System.Windows.Forms.ToolStripButton tSBtnAccueilVacancier;
        private System.Windows.Forms.ToolStripButton tSBProfilVacancier;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tSBAnimationsVacancier;
        private System.Windows.Forms.ToolStripButton tSBPlanningActivitVacancier;
        private System.Windows.Forms.ToolStripButton tSBtnQuitter;
    }
}
