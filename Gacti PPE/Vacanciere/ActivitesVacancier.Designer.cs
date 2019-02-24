namespace Gacti_PPE.Vacancier
{
    partial class ActivitesVacancier
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
            this.listBActivites = new System.Windows.Forms.ListBox();
            this.btnInscriptionActi = new System.Windows.Forms.Button();
            this.lbNomAnim = new System.Windows.Forms.Label();
            this.lbDescAnim = new System.Windows.Forms.Label();
            this.btnPlusDInfos = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.richTBDescAnimation = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // listBActivites
            // 
            this.listBActivites.FormattingEnabled = true;
            this.listBActivites.ItemHeight = 16;
            this.listBActivites.Location = new System.Drawing.Point(13, 119);
            this.listBActivites.Margin = new System.Windows.Forms.Padding(4);
            this.listBActivites.Name = "listBActivites";
            this.listBActivites.Size = new System.Drawing.Size(817, 244);
            this.listBActivites.TabIndex = 0;
            // 
            // btnInscriptionActi
            // 
            this.btnInscriptionActi.Location = new System.Drawing.Point(13, 385);
            this.btnInscriptionActi.Margin = new System.Windows.Forms.Padding(4);
            this.btnInscriptionActi.Name = "btnInscriptionActi";
            this.btnInscriptionActi.Size = new System.Drawing.Size(100, 28);
            this.btnInscriptionActi.TabIndex = 1;
            this.btnInscriptionActi.Text = "M\'inscrire";
            this.btnInscriptionActi.UseVisualStyleBackColor = true;
            this.btnInscriptionActi.Click += new System.EventHandler(this.btnInscriptionActi_Click);
            // 
            // lbNomAnim
            // 
            this.lbNomAnim.AutoSize = true;
            this.lbNomAnim.Location = new System.Drawing.Point(139, 11);
            this.lbNomAnim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNomAnim.Name = "lbNomAnim";
            this.lbNomAnim.Size = new System.Drawing.Size(58, 17);
            this.lbNomAnim.TabIndex = 2;
            this.lbNomAnim.Text = "nmAnim";
            // 
            // lbDescAnim
            // 
            this.lbDescAnim.AutoSize = true;
            this.lbDescAnim.Location = new System.Drawing.Point(235, 12);
            this.lbDescAnim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDescAnim.Name = "lbDescAnim";
            this.lbDescAnim.Size = new System.Drawing.Size(178, 17);
            this.lbDescAnim.TabIndex = 3;
            this.lbDescAnim.Text = "Description de l\'animation :";
            // 
            // btnPlusDInfos
            // 
            this.btnPlusDInfos.Location = new System.Drawing.Point(142, 385);
            this.btnPlusDInfos.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlusDInfos.Name = "btnPlusDInfos";
            this.btnPlusDInfos.Size = new System.Drawing.Size(145, 28);
            this.btnPlusDInfos.TabIndex = 4;
            this.btnPlusDInfos.Text = "Plus d\'informations";
            this.btnPlusDInfos.UseVisualStyleBackColor = true;
            this.btnPlusDInfos.Click += new System.EventHandler(this.btnPlusDInfos_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(730, 385);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(4);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(100, 28);
            this.btnFermer.TabIndex = 5;
            this.btnFermer.Text = "Fermer ";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nom de l\'activité :";
            // 
            // richTBDescAnimation
            // 
            this.richTBDescAnimation.Location = new System.Drawing.Point(420, 11);
            this.richTBDescAnimation.Name = "richTBDescAnimation";
            this.richTBDescAnimation.Size = new System.Drawing.Size(410, 101);
            this.richTBDescAnimation.TabIndex = 8;
            this.richTBDescAnimation.Text = "";
            // 
            // ActivitesVacancier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 432);
            this.ControlBox = false;
            this.Controls.Add(this.richTBDescAnimation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnPlusDInfos);
            this.Controls.Add(this.lbDescAnim);
            this.Controls.Add(this.lbNomAnim);
            this.Controls.Add(this.btnInscriptionActi);
            this.Controls.Add(this.listBActivites);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ActivitesVacancier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste des Activités";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBActivites;
        private System.Windows.Forms.Button btnInscriptionActi;
        private System.Windows.Forms.Label lbNomAnim;
        private System.Windows.Forms.Label lbDescAnim;
        private System.Windows.Forms.Button btnPlusDInfos;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTBDescAnimation;
    }
}