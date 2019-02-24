namespace Gacti_PPE
{
    partial class Connexion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connexion));
            this.btnConnexion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkBoxVoirMdp = new System.Windows.Forms.CheckBox();
            this.lbNomUtilisateur = new System.Windows.Forms.Label();
            this.lbMotDePasse = new System.Windows.Forms.Label();
            this.textBMotDePasse = new System.Windows.Forms.TextBox();
            this.textBNomUtilisateur = new System.Windows.Forms.TextBox();
            this.lbPresGacti = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(262, 117);
            this.btnConnexion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(89, 33);
            this.btnConnexion.TabIndex = 0;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkBoxVoirMdp);
            this.panel1.Controls.Add(this.lbNomUtilisateur);
            this.panel1.Controls.Add(this.lbMotDePasse);
            this.panel1.Controls.Add(this.textBMotDePasse);
            this.panel1.Controls.Add(this.textBNomUtilisateur);
            this.panel1.Controls.Add(this.btnConnexion);
            this.panel1.Location = new System.Drawing.Point(12, 119);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 219);
            this.panel1.TabIndex = 1;
            // 
            // chkBoxVoirMdp
            // 
            this.chkBoxVoirMdp.AutoSize = true;
            this.chkBoxVoirMdp.Location = new System.Drawing.Point(12, 175);
            this.chkBoxVoirMdp.Margin = new System.Windows.Forms.Padding(4);
            this.chkBoxVoirMdp.Name = "chkBoxVoirMdp";
            this.chkBoxVoirMdp.Size = new System.Drawing.Size(144, 21);
            this.chkBoxVoirMdp.TabIndex = 5;
            this.chkBoxVoirMdp.Text = "Voir mot de passe";
            this.chkBoxVoirMdp.UseVisualStyleBackColor = true;
            this.chkBoxVoirMdp.CheckedChanged += new System.EventHandler(this.chkBoxVoirMdp_CheckedChanged);
            // 
            // lbNomUtilisateur
            // 
            this.lbNomUtilisateur.AutoSize = true;
            this.lbNomUtilisateur.Location = new System.Drawing.Point(8, 70);
            this.lbNomUtilisateur.Name = "lbNomUtilisateur";
            this.lbNomUtilisateur.Size = new System.Drawing.Size(121, 17);
            this.lbNomUtilisateur.TabIndex = 3;
            this.lbNomUtilisateur.Text = "Nom d\'utilisateur :";
            // 
            // lbMotDePasse
            // 
            this.lbMotDePasse.AutoSize = true;
            this.lbMotDePasse.Location = new System.Drawing.Point(8, 122);
            this.lbMotDePasse.Name = "lbMotDePasse";
            this.lbMotDePasse.Size = new System.Drawing.Size(101, 17);
            this.lbMotDePasse.TabIndex = 4;
            this.lbMotDePasse.Text = "Mot de passe :";
            // 
            // textBMotDePasse
            // 
            this.textBMotDePasse.Location = new System.Drawing.Point(135, 122);
            this.textBMotDePasse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBMotDePasse.Name = "textBMotDePasse";
            this.textBMotDePasse.Size = new System.Drawing.Size(100, 22);
            this.textBMotDePasse.TabIndex = 2;
            // 
            // textBNomUtilisateur
            // 
            this.textBNomUtilisateur.Location = new System.Drawing.Point(135, 70);
            this.textBNomUtilisateur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBNomUtilisateur.Name = "textBNomUtilisateur";
            this.textBNomUtilisateur.Size = new System.Drawing.Size(100, 22);
            this.textBNomUtilisateur.TabIndex = 1;
            // 
            // lbPresGacti
            // 
            this.lbPresGacti.AutoSize = true;
            this.lbPresGacti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPresGacti.Location = new System.Drawing.Point(142, 41);
            this.lbPresGacti.Name = "lbPresGacti";
            this.lbPresGacti.Size = new System.Drawing.Size(235, 25);
            this.lbPresGacti.TabIndex = 2;
            this.lbPresGacti.Text = "Bienvenue chez Gacti !";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 350);
            this.Controls.Add(this.lbPresGacti);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Connexion";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Connexion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbNomUtilisateur;
        private System.Windows.Forms.Label lbMotDePasse;
        private System.Windows.Forms.TextBox textBMotDePasse;
        private System.Windows.Forms.TextBox textBNomUtilisateur;
        private System.Windows.Forms.Label lbPresGacti;
        private System.Windows.Forms.CheckBox chkBoxVoirMdp;
        private System.Windows.Forms.ImageList imageList1;
    }
}

