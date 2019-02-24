namespace Gacti_PPE
{
    partial class ModifierActivite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifierActivite));
            this.lbEnregistrerActivite = new System.Windows.Forms.Label();
            this.dtPickerHrDebut = new System.Windows.Forms.DateTimePicker();
            this.dtPickerHrFin = new System.Windows.Forms.DateTimePicker();
            this.dtPickerHrRdv = new System.Windows.Forms.DateTimePicker();
            this.dtPickerAnnulActivite = new System.Windows.Forms.DateTimePicker();
            this.cmbBoxResponsable = new System.Windows.Forms.ComboBox();
            this.comboBCodeAnimation = new System.Windows.Forms.ComboBox();
            this.comboBCodeEtatAct = new System.Windows.Forms.ComboBox();
            this.lbCodeEtatAct = new System.Windows.Forms.Label();
            this.lbDateAnnuleAct = new System.Windows.Forms.Label();
            this.lbPrenomResponsable = new System.Windows.Forms.Label();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.dtPickerDateAct = new System.Windows.Forms.DateTimePicker();
            this.numUpDwnPrixAct = new System.Windows.Forms.NumericUpDown();
            this.lbHrFinAct = new System.Windows.Forms.Label();
            this.lbHrDebutAct = new System.Windows.Forms.Label();
            this.lbDateAct = new System.Windows.Forms.Label();
            this.lbHrRdvAct = new System.Windows.Forms.Label();
            this.lbCodeAnim = new System.Windows.Forms.Label();
            this.lbPrixAct = new System.Windows.Forms.Label();
            this.btnRetour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnPrixAct)).BeginInit();
            this.SuspendLayout();
            // 
            // lbEnregistrerActivite
            // 
            this.lbEnregistrerActivite.AutoSize = true;
            this.lbEnregistrerActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lbEnregistrerActivite.Location = new System.Drawing.Point(12, 9);
            this.lbEnregistrerActivite.Name = "lbEnregistrerActivite";
            this.lbEnregistrerActivite.Size = new System.Drawing.Size(140, 20);
            this.lbEnregistrerActivite.TabIndex = 26;
            this.lbEnregistrerActivite.Text = "Modifier l\'activité ";
            // 
            // dtPickerHrDebut
            // 
            this.dtPickerHrDebut.CustomFormat = "HH:mm";
            this.dtPickerHrDebut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPickerHrDebut.Location = new System.Drawing.Point(128, 224);
            this.dtPickerHrDebut.Margin = new System.Windows.Forms.Padding(2);
            this.dtPickerHrDebut.Name = "dtPickerHrDebut";
            this.dtPickerHrDebut.ShowUpDown = true;
            this.dtPickerHrDebut.Size = new System.Drawing.Size(63, 20);
            this.dtPickerHrDebut.TabIndex = 46;
            // 
            // dtPickerHrFin
            // 
            this.dtPickerHrFin.CustomFormat = "HH:mm";
            this.dtPickerHrFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPickerHrFin.Location = new System.Drawing.Point(128, 257);
            this.dtPickerHrFin.Margin = new System.Windows.Forms.Padding(2);
            this.dtPickerHrFin.Name = "dtPickerHrFin";
            this.dtPickerHrFin.ShowUpDown = true;
            this.dtPickerHrFin.Size = new System.Drawing.Size(63, 20);
            this.dtPickerHrFin.TabIndex = 45;
            // 
            // dtPickerHrRdv
            // 
            this.dtPickerHrRdv.CustomFormat = "HH:mm";
            this.dtPickerHrRdv.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPickerHrRdv.Location = new System.Drawing.Point(128, 160);
            this.dtPickerHrRdv.Margin = new System.Windows.Forms.Padding(2);
            this.dtPickerHrRdv.Name = "dtPickerHrRdv";
            this.dtPickerHrRdv.ShowUpDown = true;
            this.dtPickerHrRdv.Size = new System.Drawing.Size(121, 20);
            this.dtPickerHrRdv.TabIndex = 44;
            // 
            // dtPickerAnnulActivite
            // 
            this.dtPickerAnnulActivite.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerAnnulActivite.Location = new System.Drawing.Point(387, 128);
            this.dtPickerAnnulActivite.Margin = new System.Windows.Forms.Padding(2);
            this.dtPickerAnnulActivite.Name = "dtPickerAnnulActivite";
            this.dtPickerAnnulActivite.Size = new System.Drawing.Size(121, 20);
            this.dtPickerAnnulActivite.TabIndex = 43;
            // 
            // cmbBoxResponsable
            // 
            this.cmbBoxResponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxResponsable.FormattingEnabled = true;
            this.cmbBoxResponsable.Location = new System.Drawing.Point(387, 87);
            this.cmbBoxResponsable.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBoxResponsable.Name = "cmbBoxResponsable";
            this.cmbBoxResponsable.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxResponsable.TabIndex = 42;
            // 
            // comboBCodeAnimation
            // 
            this.comboBCodeAnimation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBCodeAnimation.FormattingEnabled = true;
            this.comboBCodeAnimation.Location = new System.Drawing.Point(128, 87);
            this.comboBCodeAnimation.Name = "comboBCodeAnimation";
            this.comboBCodeAnimation.Size = new System.Drawing.Size(121, 21);
            this.comboBCodeAnimation.TabIndex = 41;
            // 
            // comboBCodeEtatAct
            // 
            this.comboBCodeEtatAct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBCodeEtatAct.FormattingEnabled = true;
            this.comboBCodeEtatAct.Location = new System.Drawing.Point(387, 167);
            this.comboBCodeEtatAct.Name = "comboBCodeEtatAct";
            this.comboBCodeEtatAct.Size = new System.Drawing.Size(121, 21);
            this.comboBCodeEtatAct.TabIndex = 40;
            // 
            // lbCodeEtatAct
            // 
            this.lbCodeEtatAct.AutoSize = true;
            this.lbCodeEtatAct.Location = new System.Drawing.Point(282, 167);
            this.lbCodeEtatAct.Name = "lbCodeEtatAct";
            this.lbCodeEtatAct.Size = new System.Drawing.Size(99, 13);
            this.lbCodeEtatAct.TabIndex = 33;
            this.lbCodeEtatAct.Text = "Code état activité : ";
            // 
            // lbDateAnnuleAct
            // 
            this.lbDateAnnuleAct.AutoSize = true;
            this.lbDateAnnuleAct.Location = new System.Drawing.Point(282, 135);
            this.lbDateAnnuleAct.Name = "lbDateAnnuleAct";
            this.lbDateAnnuleAct.Size = new System.Drawing.Size(96, 13);
            this.lbDateAnnuleAct.TabIndex = 30;
            this.lbDateAnnuleAct.Text = "Date d\'annulation :";
            // 
            // lbPrenomResponsable
            // 
            this.lbPrenomResponsable.AutoSize = true;
            this.lbPrenomResponsable.Location = new System.Drawing.Point(282, 90);
            this.lbPrenomResponsable.Name = "lbPrenomResponsable";
            this.lbPrenomResponsable.Size = new System.Drawing.Size(78, 13);
            this.lbPrenomResponsable.TabIndex = 28;
            this.lbPrenomResponsable.Text = "Responsable : ";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(19, 296);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrer.TabIndex = 39;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // dtPickerDateAct
            // 
            this.dtPickerDateAct.CustomFormat = "";
            this.dtPickerDateAct.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerDateAct.Location = new System.Drawing.Point(128, 128);
            this.dtPickerDateAct.Name = "dtPickerDateAct";
            this.dtPickerDateAct.Size = new System.Drawing.Size(121, 20);
            this.dtPickerDateAct.TabIndex = 38;
            // 
            // numUpDwnPrixAct
            // 
            this.numUpDwnPrixAct.Location = new System.Drawing.Point(128, 195);
            this.numUpDwnPrixAct.Name = "numUpDwnPrixAct";
            this.numUpDwnPrixAct.Size = new System.Drawing.Size(63, 20);
            this.numUpDwnPrixAct.TabIndex = 37;
            // 
            // lbHrFinAct
            // 
            this.lbHrFinAct.AutoSize = true;
            this.lbHrFinAct.Location = new System.Drawing.Point(16, 257);
            this.lbHrFinAct.Name = "lbHrFinAct";
            this.lbHrFinAct.Size = new System.Drawing.Size(56, 13);
            this.lbHrFinAct.TabIndex = 35;
            this.lbHrFinAct.Text = "Heure fin :";
            // 
            // lbHrDebutAct
            // 
            this.lbHrDebutAct.AutoSize = true;
            this.lbHrDebutAct.Location = new System.Drawing.Point(16, 224);
            this.lbHrDebutAct.Name = "lbHrDebutAct";
            this.lbHrDebutAct.Size = new System.Drawing.Size(72, 13);
            this.lbHrDebutAct.TabIndex = 34;
            this.lbHrDebutAct.Text = "Heure début :";
            // 
            // lbDateAct
            // 
            this.lbDateAct.AutoSize = true;
            this.lbDateAct.Location = new System.Drawing.Point(16, 128);
            this.lbDateAct.Name = "lbDateAct";
            this.lbDateAct.Size = new System.Drawing.Size(39, 13);
            this.lbDateAct.TabIndex = 32;
            this.lbDateAct.Text = "Date : ";
            // 
            // lbHrRdvAct
            // 
            this.lbHrRdvAct.AutoSize = true;
            this.lbHrRdvAct.Location = new System.Drawing.Point(16, 160);
            this.lbHrRdvAct.Name = "lbHrRdvAct";
            this.lbHrRdvAct.Size = new System.Drawing.Size(106, 13);
            this.lbHrRdvAct.TabIndex = 31;
            this.lbHrRdvAct.Text = "Heure rendez-vous : ";
            // 
            // lbCodeAnim
            // 
            this.lbCodeAnim.AutoSize = true;
            this.lbCodeAnim.Location = new System.Drawing.Point(16, 90);
            this.lbCodeAnim.Name = "lbCodeAnim";
            this.lbCodeAnim.Size = new System.Drawing.Size(86, 13);
            this.lbCodeAnim.TabIndex = 29;
            this.lbCodeAnim.Text = "Code animation :";
            // 
            // lbPrixAct
            // 
            this.lbPrixAct.AutoSize = true;
            this.lbPrixAct.Location = new System.Drawing.Point(16, 197);
            this.lbPrixAct.Name = "lbPrixAct";
            this.lbPrixAct.Size = new System.Drawing.Size(33, 13);
            this.lbPrixAct.TabIndex = 27;
            this.lbPrixAct.Text = "Prix : ";
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(486, 296);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 47;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // ModifierActivite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 351);
            this.ControlBox = false;
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.dtPickerHrDebut);
            this.Controls.Add(this.dtPickerHrFin);
            this.Controls.Add(this.dtPickerHrRdv);
            this.Controls.Add(this.dtPickerAnnulActivite);
            this.Controls.Add(this.cmbBoxResponsable);
            this.Controls.Add(this.comboBCodeAnimation);
            this.Controls.Add(this.comboBCodeEtatAct);
            this.Controls.Add(this.lbCodeEtatAct);
            this.Controls.Add(this.lbDateAnnuleAct);
            this.Controls.Add(this.lbPrenomResponsable);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.dtPickerDateAct);
            this.Controls.Add(this.numUpDwnPrixAct);
            this.Controls.Add(this.lbHrFinAct);
            this.Controls.Add(this.lbHrDebutAct);
            this.Controls.Add(this.lbDateAct);
            this.Controls.Add(this.lbHrRdvAct);
            this.Controls.Add(this.lbCodeAnim);
            this.Controls.Add(this.lbPrixAct);
            this.Controls.Add(this.lbEnregistrerActivite);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModifierActivite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifier Activité";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnPrixAct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbEnregistrerActivite;
        private System.Windows.Forms.DateTimePicker dtPickerHrDebut;
        private System.Windows.Forms.DateTimePicker dtPickerHrFin;
        private System.Windows.Forms.DateTimePicker dtPickerHrRdv;
        private System.Windows.Forms.DateTimePicker dtPickerAnnulActivite;
        private System.Windows.Forms.ComboBox cmbBoxResponsable;
        private System.Windows.Forms.ComboBox comboBCodeAnimation;
        private System.Windows.Forms.ComboBox comboBCodeEtatAct;
        private System.Windows.Forms.Label lbCodeEtatAct;
        private System.Windows.Forms.Label lbDateAnnuleAct;
        private System.Windows.Forms.Label lbPrenomResponsable;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.DateTimePicker dtPickerDateAct;
        private System.Windows.Forms.NumericUpDown numUpDwnPrixAct;
        private System.Windows.Forms.Label lbHrFinAct;
        private System.Windows.Forms.Label lbHrDebutAct;
        private System.Windows.Forms.Label lbDateAct;
        private System.Windows.Forms.Label lbHrRdvAct;
        private System.Windows.Forms.Label lbCodeAnim;
        private System.Windows.Forms.Label lbPrixAct;
        private System.Windows.Forms.Button btnRetour;
    }
}