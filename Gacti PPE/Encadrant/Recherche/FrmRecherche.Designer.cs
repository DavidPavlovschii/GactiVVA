namespace Gacti_PPE.Encadrant
{
    partial class FrmRecherche
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRecherche));
            this.sideBar1 = new Gacti_PPE.Encadrant.SideBar();
            this.textBRechercher = new System.Windows.Forms.TextBox();
            this.lbRechercher = new System.Windows.Forms.Label();
            this.listBListeActivites = new System.Windows.Forms.ListBox();
            this.lbListeDesActivites = new System.Windows.Forms.Label();
            this.btnListerLesInscrits = new System.Windows.Forms.Button();
            this.lbTitre = new System.Windows.Forms.Label();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sideBar1
            // 
            this.sideBar1.Location = new System.Drawing.Point(0, -1);
            this.sideBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sideBar1.Name = "sideBar1";
            this.sideBar1.Size = new System.Drawing.Size(129, 559);
            this.sideBar1.TabIndex = 0;
            // 
            // textBRechercher
            // 
            this.textBRechercher.Location = new System.Drawing.Point(465, 95);
            this.textBRechercher.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBRechercher.Name = "textBRechercher";
            this.textBRechercher.Size = new System.Drawing.Size(132, 22);
            this.textBRechercher.TabIndex = 1;
            // 
            // lbRechercher
            // 
            this.lbRechercher.AutoSize = true;
            this.lbRechercher.Location = new System.Drawing.Point(276, 98);
            this.lbRechercher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRechercher.Name = "lbRechercher";
            this.lbRechercher.Size = new System.Drawing.Size(182, 17);
            this.lbRechercher.TabIndex = 2;
            this.lbRechercher.Text = "Saisir un code d\'animation :";
            // 
            // listBListeActivites
            // 
            this.listBListeActivites.FormattingEnabled = true;
            this.listBListeActivites.ItemHeight = 16;
            this.listBListeActivites.Location = new System.Drawing.Point(325, 175);
            this.listBListeActivites.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBListeActivites.Name = "listBListeActivites";
            this.listBListeActivites.Size = new System.Drawing.Size(365, 244);
            this.listBListeActivites.TabIndex = 3;
            // 
            // lbListeDesActivites
            // 
            this.lbListeDesActivites.AutoSize = true;
            this.lbListeDesActivites.Location = new System.Drawing.Point(180, 175);
            this.lbListeDesActivites.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbListeDesActivites.Name = "lbListeDesActivites";
            this.lbListeDesActivites.Size = new System.Drawing.Size(128, 17);
            this.lbListeDesActivites.TabIndex = 4;
            this.lbListeDesActivites.Text = "Liste des activités :";
            // 
            // btnListerLesInscrits
            // 
            this.btnListerLesInscrits.Location = new System.Drawing.Point(325, 427);
            this.btnListerLesInscrits.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnListerLesInscrits.Name = "btnListerLesInscrits";
            this.btnListerLesInscrits.Size = new System.Drawing.Size(143, 28);
            this.btnListerLesInscrits.TabIndex = 5;
            this.btnListerLesInscrits.Text = "Lister les inscrits";
            this.btnListerLesInscrits.UseVisualStyleBackColor = true;
            this.btnListerLesInscrits.Click += new System.EventHandler(this.btnListerLesInscrits_Click);
            // 
            // lbTitre
            // 
            this.lbTitre.AutoSize = true;
            this.lbTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitre.Location = new System.Drawing.Point(136, 22);
            this.lbTitre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitre.Name = "lbTitre";
            this.lbTitre.Size = new System.Drawing.Size(530, 25);
            this.lbTitre.TabIndex = 6;
            this.lbTitre.Text = "Recherche des activités d\'une animation au planning :";
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(607, 92);
            this.btnRechercher.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(100, 28);
            this.btnRechercher.TabIndex = 7;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // FrmRecherche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.ControlBox = false;
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.lbTitre);
            this.Controls.Add(this.btnListerLesInscrits);
            this.Controls.Add(this.lbListeDesActivites);
            this.Controls.Add(this.listBListeActivites);
            this.Controls.Add(this.lbRechercher);
            this.Controls.Add(this.textBRechercher);
            this.Controls.Add(this.sideBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmRecherche";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recherche";
            this.Load += new System.EventHandler(this.FrmRecherche_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SideBar sideBar1;
        private System.Windows.Forms.TextBox textBRechercher;
        private System.Windows.Forms.Label lbRechercher;
        private System.Windows.Forms.ListBox listBListeActivites;
        private System.Windows.Forms.Label lbListeDesActivites;
        private System.Windows.Forms.Button btnListerLesInscrits;
        private System.Windows.Forms.Label lbTitre;
        private System.Windows.Forms.Button btnRechercher;
    }
}