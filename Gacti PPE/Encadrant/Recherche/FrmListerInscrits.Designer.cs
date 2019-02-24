namespace Gacti_PPE.Encadrant.Recherche
{
    partial class FrmListerInscrits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListerInscrits));
            this.listBListeVacanciers = new System.Windows.Forms.ListBox();
            this.lbListeDesInscritsPourLActivite = new System.Windows.Forms.Label();
            this.lbListeVacanciers = new System.Windows.Forms.Label();
            this.btnAfficherDetail = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.lbTmpActivite = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBListeVacanciers
            // 
            this.listBListeVacanciers.FormattingEnabled = true;
            this.listBListeVacanciers.Location = new System.Drawing.Point(148, 84);
            this.listBListeVacanciers.Name = "listBListeVacanciers";
            this.listBListeVacanciers.Size = new System.Drawing.Size(320, 199);
            this.listBListeVacanciers.TabIndex = 0;
            // 
            // lbListeDesInscritsPourLActivite
            // 
            this.lbListeDesInscritsPourLActivite.AutoSize = true;
            this.lbListeDesInscritsPourLActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListeDesInscritsPourLActivite.Location = new System.Drawing.Point(19, 17);
            this.lbListeDesInscritsPourLActivite.Name = "lbListeDesInscritsPourLActivite";
            this.lbListeDesInscritsPourLActivite.Size = new System.Drawing.Size(260, 20);
            this.lbListeDesInscritsPourLActivite.TabIndex = 1;
            this.lbListeDesInscritsPourLActivite.Text = "Liste des inscrits pour l\'activité ";
            // 
            // lbListeVacanciers
            // 
            this.lbListeVacanciers.AutoSize = true;
            this.lbListeVacanciers.Location = new System.Drawing.Point(35, 84);
            this.lbListeVacanciers.Name = "lbListeVacanciers";
            this.lbListeVacanciers.Size = new System.Drawing.Size(107, 13);
            this.lbListeVacanciers.TabIndex = 2;
            this.lbListeVacanciers.Text = "Liste des vacanciers:";
            // 
            // btnAfficherDetail
            // 
            this.btnAfficherDetail.Location = new System.Drawing.Point(148, 298);
            this.btnAfficherDetail.Name = "btnAfficherDetail";
            this.btnAfficherDetail.Size = new System.Drawing.Size(98, 23);
            this.btnAfficherDetail.TabIndex = 3;
            this.btnAfficherDetail.Text = "Afficher le détail";
            this.btnAfficherDetail.UseVisualStyleBackColor = true;
            this.btnAfficherDetail.Click += new System.EventHandler(this.btnAfficherDetail_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(393, 298);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 4;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // lbTmpActivite
            // 
            this.lbTmpActivite.AutoSize = true;
            this.lbTmpActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTmpActivite.Location = new System.Drawing.Point(276, 17);
            this.lbTmpActivite.Name = "lbTmpActivite";
            this.lbTmpActivite.Size = new System.Drawing.Size(116, 20);
            this.lbTmpActivite.TabIndex = 5;
            this.lbTmpActivite.Text = "lbTmpActivite";
            // 
            // FrmListerInscrits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 400);
            this.ControlBox = false;
            this.Controls.Add(this.lbTmpActivite);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnAfficherDetail);
            this.Controls.Add(this.lbListeVacanciers);
            this.Controls.Add(this.lbListeDesInscritsPourLActivite);
            this.Controls.Add(this.listBListeVacanciers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmListerInscrits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste des inscrits pour une activité";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBListeVacanciers;
        private System.Windows.Forms.Label lbListeDesInscritsPourLActivite;
        private System.Windows.Forms.Label lbListeVacanciers;
        private System.Windows.Forms.Button btnAfficherDetail;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Label lbTmpActivite;
    }
}