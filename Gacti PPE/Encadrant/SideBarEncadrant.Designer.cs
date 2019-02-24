namespace Gacti_PPE.Encadrant
{
    partial class SideBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SideBar));
            this.tSEncadrant = new System.Windows.Forms.ToolStrip();
            this.tSBtnAccueilEncadrant = new System.Windows.Forms.ToolStripButton();
            this.tSBProfilEncadrant = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tSBDrpDwnBtnAnimationsEncadrant = new System.Windows.Forms.ToolStripDropDownButton();
            this.consulterLesAnimationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerUneAnimationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tSBDrpDwnBtnActivitesEncadrant = new System.Windows.Forms.ToolStripDropDownButton();
            this.consulterLesActivitésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créerUneActivitéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tSBtnQuitter = new System.Windows.Forms.ToolStripButton();
            this.tSEncadrant.SuspendLayout();
            this.SuspendLayout();
            // 
            // tSEncadrant
            // 
            this.tSEncadrant.Dock = System.Windows.Forms.DockStyle.Left;
            this.tSEncadrant.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tSEncadrant.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tSEncadrant.ImageScalingSize = new System.Drawing.Size(60, 60);
            this.tSEncadrant.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSBtnAccueilEncadrant,
            this.tSBProfilEncadrant,
            this.toolStripSeparator1,
            this.tSBDrpDwnBtnAnimationsEncadrant,
            this.tSBDrpDwnBtnActivitesEncadrant,
            this.toolStripButton1,
            this.tSBtnQuitter});
            this.tSEncadrant.Location = new System.Drawing.Point(0, 0);
            this.tSEncadrant.Name = "tSEncadrant";
            this.tSEncadrant.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tSEncadrant.Size = new System.Drawing.Size(74, 443);
            this.tSEncadrant.TabIndex = 2;
            this.tSEncadrant.Text = "Activités";
            // 
            // tSBtnAccueilEncadrant
            // 
            this.tSBtnAccueilEncadrant.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBtnAccueilEncadrant.Image = ((System.Drawing.Image)(resources.GetObject("tSBtnAccueilEncadrant.Image")));
            this.tSBtnAccueilEncadrant.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnAccueilEncadrant.Name = "tSBtnAccueilEncadrant";
            this.tSBtnAccueilEncadrant.Size = new System.Drawing.Size(71, 64);
            this.tSBtnAccueilEncadrant.Text = "Accueil";
            this.tSBtnAccueilEncadrant.Click += new System.EventHandler(this.tSBtnAccueilEncadrant_Click);
            // 
            // tSBProfilEncadrant
            // 
            this.tSBProfilEncadrant.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBProfilEncadrant.Image = global::Gacti_PPE.Properties.Resources.user;
            this.tSBProfilEncadrant.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBProfilEncadrant.Name = "tSBProfilEncadrant";
            this.tSBProfilEncadrant.Size = new System.Drawing.Size(71, 64);
            this.tSBProfilEncadrant.Text = "Profil";
            this.tSBProfilEncadrant.Click += new System.EventHandler(this.tSBProfilEncadrant_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(71, 6);
            // 
            // tSBDrpDwnBtnAnimationsEncadrant
            // 
            this.tSBDrpDwnBtnAnimationsEncadrant.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBDrpDwnBtnAnimationsEncadrant.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consulterLesAnimationsToolStripMenuItem,
            this.enregistrerUneAnimationToolStripMenuItem});
            this.tSBDrpDwnBtnAnimationsEncadrant.Image = global::Gacti_PPE.Properties.Resources.Alpine_Skiing_icon1;
            this.tSBDrpDwnBtnAnimationsEncadrant.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBDrpDwnBtnAnimationsEncadrant.Name = "tSBDrpDwnBtnAnimationsEncadrant";
            this.tSBDrpDwnBtnAnimationsEncadrant.Size = new System.Drawing.Size(71, 64);
            this.tSBDrpDwnBtnAnimationsEncadrant.Text = "Animations";
            this.tSBDrpDwnBtnAnimationsEncadrant.ToolTipText = "Animations";
            // 
            // consulterLesAnimationsToolStripMenuItem
            // 
            this.consulterLesAnimationsToolStripMenuItem.Name = "consulterLesAnimationsToolStripMenuItem";
            this.consulterLesAnimationsToolStripMenuItem.Size = new System.Drawing.Size(291, 24);
            this.consulterLesAnimationsToolStripMenuItem.Text = "Consulter / modifier les animations";
            this.consulterLesAnimationsToolStripMenuItem.Click += new System.EventHandler(this.consulterLesAnimationsToolStripMenuItem_Click);
            // 
            // enregistrerUneAnimationToolStripMenuItem
            // 
            this.enregistrerUneAnimationToolStripMenuItem.Name = "enregistrerUneAnimationToolStripMenuItem";
            this.enregistrerUneAnimationToolStripMenuItem.Size = new System.Drawing.Size(291, 24);
            this.enregistrerUneAnimationToolStripMenuItem.Text = "Enregistrer une animation";
            this.enregistrerUneAnimationToolStripMenuItem.Click += new System.EventHandler(this.enregistrerUneAnimationToolStripMenuItem_Click);
            // 
            // tSBDrpDwnBtnActivitesEncadrant
            // 
            this.tSBDrpDwnBtnActivitesEncadrant.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBDrpDwnBtnActivitesEncadrant.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consulterLesActivitésToolStripMenuItem,
            this.créerUneActivitéToolStripMenuItem});
            this.tSBDrpDwnBtnActivitesEncadrant.Image = global::Gacti_PPE.Properties.Resources.activitess;
            this.tSBDrpDwnBtnActivitesEncadrant.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBDrpDwnBtnActivitesEncadrant.Name = "tSBDrpDwnBtnActivitesEncadrant";
            this.tSBDrpDwnBtnActivitesEncadrant.Size = new System.Drawing.Size(71, 64);
            this.tSBDrpDwnBtnActivitesEncadrant.Text = "Activités";
            // 
            // consulterLesActivitésToolStripMenuItem
            // 
            this.consulterLesActivitésToolStripMenuItem.Name = "consulterLesActivitésToolStripMenuItem";
            this.consulterLesActivitésToolStripMenuItem.Size = new System.Drawing.Size(273, 24);
            this.consulterLesActivitésToolStripMenuItem.Text = "Consulter / modifier les activités";
            this.consulterLesActivitésToolStripMenuItem.Click += new System.EventHandler(this.consulterLesActivitésToolStripMenuItem_Click);
            // 
            // créerUneActivitéToolStripMenuItem
            // 
            this.créerUneActivitéToolStripMenuItem.Name = "créerUneActivitéToolStripMenuItem";
            this.créerUneActivitéToolStripMenuItem.Size = new System.Drawing.Size(273, 24);
            this.créerUneActivitéToolStripMenuItem.Text = "Enregistrer une activité";
            this.créerUneActivitéToolStripMenuItem.Click += new System.EventHandler(this.créerUneActivitéToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(71, 64);
            this.toolStripButton1.Text = "Recherche";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tSBtnQuitter
            // 
            this.tSBtnQuitter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBtnQuitter.Image = global::Gacti_PPE.Properties.Resources.icons8_sortie_48;
            this.tSBtnQuitter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnQuitter.Name = "tSBtnQuitter";
            this.tSBtnQuitter.Size = new System.Drawing.Size(71, 64);
            this.tSBtnQuitter.Text = "Quitter";
            this.tSBtnQuitter.Click += new System.EventHandler(this.tSBtnQuitter_Click);
            // 
            // SideBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tSEncadrant);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SideBar";
            this.Size = new System.Drawing.Size(97, 443);
            this.tSEncadrant.ResumeLayout(false);
            this.tSEncadrant.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tSEncadrant;
        private System.Windows.Forms.ToolStripButton tSBtnAccueilEncadrant;
        private System.Windows.Forms.ToolStripButton tSBProfilEncadrant;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton tSBDrpDwnBtnAnimationsEncadrant;
        private System.Windows.Forms.ToolStripMenuItem consulterLesAnimationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerUneAnimationToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton tSBDrpDwnBtnActivitesEncadrant;
        private System.Windows.Forms.ToolStripMenuItem consulterLesActivitésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créerUneActivitéToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tSBtnQuitter;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}
