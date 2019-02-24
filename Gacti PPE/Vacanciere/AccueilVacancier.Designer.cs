namespace Gacti_PPE
{
    partial class AccueilVacancier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccueilVacancier));
            this.sideBarVacancier1 = new Gacti_PPE.Vacancier.SideBarVacancier();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sideBarVacancier1
            // 
            this.sideBarVacancier1.Location = new System.Drawing.Point(1, 2);
            this.sideBarVacancier1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sideBarVacancier1.Name = "sideBarVacancier1";
            this.sideBarVacancier1.Size = new System.Drawing.Size(99, 525);
            this.sideBarVacancier1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(558, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bienvenu sur l\'application de gestion des activités de VVA ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(644, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cette application vous permet de consulter les activités actuellement proposées e" +
    "t de vous y inscrire.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(627, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vous pouvez également consulter les activités auxquelles vous êtes inscrit(e) dan" +
    "s vôtre planning.";
            // 
            // AccueilVacancier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 519);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sideBarVacancier1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AccueilVacancier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Vacancier.SideBarVacancier sideBarVacancier1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}