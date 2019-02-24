namespace Gacti_PPE.Encadrant
{
    partial class EnregistrerActiviteEncadrant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnregistrerActiviteEncadrant));
            this.lbEnregistrerActivite = new System.Windows.Forms.Label();
            this.sideBar1 = new Gacti_PPE.Encadrant.SideBar();
            this.dtPickerHrFin = new System.Windows.Forms.DateTimePicker();
            this.lbHrFinAct = new System.Windows.Forms.Label();
            this.comboBCodeAnimation = new System.Windows.Forms.ComboBox();
            this.cmbBoxResponsable = new System.Windows.Forms.ComboBox();
            this.lbCodeEtatAct = new System.Windows.Forms.Label();
            this.lbPrenomResponsable = new System.Windows.Forms.Label();
            this.lbDateAct = new System.Windows.Forms.Label();
            this.lbHrRdvAct = new System.Windows.Forms.Label();
            this.comboBCodeEtatAct = new System.Windows.Forms.ComboBox();
            this.lbCodeAnim = new System.Windows.Forms.Label();
            this.lbDateAnnuleAct = new System.Windows.Forms.Label();
            this.dtPickerHrRdv = new System.Windows.Forms.DateTimePicker();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.dtPickerAnnulActivite = new System.Windows.Forms.DateTimePicker();
            this.numUpDwnPrixAct = new System.Windows.Forms.NumericUpDown();
            this.lbPrixAct = new System.Windows.Forms.Label();
            this.dtPickerDateAct = new System.Windows.Forms.DateTimePicker();
            this.lbHrDebutAct = new System.Windows.Forms.Label();
            this.dtPickerHrDebut = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnPrixAct)).BeginInit();
            this.SuspendLayout();
            // 
            // lbEnregistrerActivite
            // 
            this.lbEnregistrerActivite.AutoSize = true;
            this.lbEnregistrerActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lbEnregistrerActivite.Location = new System.Drawing.Point(139, 22);
            this.lbEnregistrerActivite.Name = "lbEnregistrerActivite";
            this.lbEnregistrerActivite.Size = new System.Drawing.Size(258, 20);
            this.lbEnregistrerActivite.TabIndex = 11;
            this.lbEnregistrerActivite.Text = "Enregistrer une nouvelle activité :";
            // 
            // sideBar1
            // 
            this.sideBar1.Location = new System.Drawing.Point(-1, 1);
            this.sideBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sideBar1.Name = "sideBar1";
            this.sideBar1.Size = new System.Drawing.Size(97, 445);
            this.sideBar1.TabIndex = 0;
            // 
            // dtPickerHrFin
            // 
            this.dtPickerHrFin.CustomFormat = "HH:mm";
            this.dtPickerHrFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPickerHrFin.Location = new System.Drawing.Point(252, 272);
            this.dtPickerHrFin.Margin = new System.Windows.Forms.Padding(2);
            this.dtPickerHrFin.Name = "dtPickerHrFin";
            this.dtPickerHrFin.ShowUpDown = true;
            this.dtPickerHrFin.Size = new System.Drawing.Size(62, 20);
            this.dtPickerHrFin.TabIndex = 24;
            // 
            // lbHrFinAct
            // 
            this.lbHrFinAct.AutoSize = true;
            this.lbHrFinAct.Location = new System.Drawing.Point(150, 278);
            this.lbHrFinAct.Name = "lbHrFinAct";
            this.lbHrFinAct.Size = new System.Drawing.Size(56, 13);
            this.lbHrFinAct.TabIndex = 9;
            this.lbHrFinAct.Text = "Heure fin :";
            // 
            // comboBCodeAnimation
            // 
            this.comboBCodeAnimation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBCodeAnimation.FormattingEnabled = true;
            this.comboBCodeAnimation.Location = new System.Drawing.Point(252, 104);
            this.comboBCodeAnimation.Name = "comboBCodeAnimation";
            this.comboBCodeAnimation.Size = new System.Drawing.Size(121, 21);
            this.comboBCodeAnimation.TabIndex = 20;
            // 
            // cmbBoxResponsable
            // 
            this.cmbBoxResponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxResponsable.FormattingEnabled = true;
            this.cmbBoxResponsable.Location = new System.Drawing.Point(523, 104);
            this.cmbBoxResponsable.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBoxResponsable.Name = "cmbBoxResponsable";
            this.cmbBoxResponsable.Size = new System.Drawing.Size(170, 21);
            this.cmbBoxResponsable.TabIndex = 21;
            // 
            // lbCodeEtatAct
            // 
            this.lbCodeEtatAct.AutoSize = true;
            this.lbCodeEtatAct.Location = new System.Drawing.Point(418, 187);
            this.lbCodeEtatAct.Name = "lbCodeEtatAct";
            this.lbCodeEtatAct.Size = new System.Drawing.Size(99, 13);
            this.lbCodeEtatAct.TabIndex = 7;
            this.lbCodeEtatAct.Text = "Code état activité : ";
            // 
            // lbPrenomResponsable
            // 
            this.lbPrenomResponsable.AutoSize = true;
            this.lbPrenomResponsable.Location = new System.Drawing.Point(418, 107);
            this.lbPrenomResponsable.Name = "lbPrenomResponsable";
            this.lbPrenomResponsable.Size = new System.Drawing.Size(78, 13);
            this.lbPrenomResponsable.TabIndex = 2;
            this.lbPrenomResponsable.Text = "Responsable : ";
            // 
            // lbDateAct
            // 
            this.lbDateAct.AutoSize = true;
            this.lbDateAct.Location = new System.Drawing.Point(150, 149);
            this.lbDateAct.Name = "lbDateAct";
            this.lbDateAct.Size = new System.Drawing.Size(39, 13);
            this.lbDateAct.TabIndex = 6;
            this.lbDateAct.Text = "Date : ";
            // 
            // lbHrRdvAct
            // 
            this.lbHrRdvAct.AutoSize = true;
            this.lbHrRdvAct.Location = new System.Drawing.Point(150, 181);
            this.lbHrRdvAct.Name = "lbHrRdvAct";
            this.lbHrRdvAct.Size = new System.Drawing.Size(106, 13);
            this.lbHrRdvAct.TabIndex = 5;
            this.lbHrRdvAct.Text = "Heure rendez-vous : ";
            // 
            // comboBCodeEtatAct
            // 
            this.comboBCodeEtatAct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBCodeEtatAct.FormattingEnabled = true;
            this.comboBCodeEtatAct.Location = new System.Drawing.Point(523, 184);
            this.comboBCodeEtatAct.Name = "comboBCodeEtatAct";
            this.comboBCodeEtatAct.Size = new System.Drawing.Size(170, 21);
            this.comboBCodeEtatAct.TabIndex = 19;
            // 
            // lbCodeAnim
            // 
            this.lbCodeAnim.AutoSize = true;
            this.lbCodeAnim.Location = new System.Drawing.Point(150, 111);
            this.lbCodeAnim.Name = "lbCodeAnim";
            this.lbCodeAnim.Size = new System.Drawing.Size(86, 13);
            this.lbCodeAnim.TabIndex = 3;
            this.lbCodeAnim.Text = "Code animation :";
            // 
            // lbDateAnnuleAct
            // 
            this.lbDateAnnuleAct.AutoSize = true;
            this.lbDateAnnuleAct.Location = new System.Drawing.Point(418, 149);
            this.lbDateAnnuleAct.Name = "lbDateAnnuleAct";
            this.lbDateAnnuleAct.Size = new System.Drawing.Size(96, 13);
            this.lbDateAnnuleAct.TabIndex = 4;
            this.lbDateAnnuleAct.Text = "Date d\'annulation :";
            // 
            // dtPickerHrRdv
            // 
            this.dtPickerHrRdv.CustomFormat = "HH:mm";
            this.dtPickerHrRdv.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPickerHrRdv.Location = new System.Drawing.Point(251, 181);
            this.dtPickerHrRdv.Margin = new System.Windows.Forms.Padding(2);
            this.dtPickerHrRdv.Name = "dtPickerHrRdv";
            this.dtPickerHrRdv.ShowUpDown = true;
            this.dtPickerHrRdv.Size = new System.Drawing.Size(62, 20);
            this.dtPickerHrRdv.TabIndex = 23;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(153, 317);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrer.TabIndex = 18;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // dtPickerAnnulActivite
            // 
            this.dtPickerAnnulActivite.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerAnnulActivite.Location = new System.Drawing.Point(523, 143);
            this.dtPickerAnnulActivite.Margin = new System.Windows.Forms.Padding(2);
            this.dtPickerAnnulActivite.Name = "dtPickerAnnulActivite";
            this.dtPickerAnnulActivite.Size = new System.Drawing.Size(170, 20);
            this.dtPickerAnnulActivite.TabIndex = 22;
            // 
            // numUpDwnPrixAct
            // 
            this.numUpDwnPrixAct.Location = new System.Drawing.Point(252, 211);
            this.numUpDwnPrixAct.Name = "numUpDwnPrixAct";
            this.numUpDwnPrixAct.Size = new System.Drawing.Size(62, 20);
            this.numUpDwnPrixAct.TabIndex = 13;
            // 
            // lbPrixAct
            // 
            this.lbPrixAct.AutoSize = true;
            this.lbPrixAct.Location = new System.Drawing.Point(150, 218);
            this.lbPrixAct.Name = "lbPrixAct";
            this.lbPrixAct.Size = new System.Drawing.Size(33, 13);
            this.lbPrixAct.TabIndex = 1;
            this.lbPrixAct.Text = "Prix : ";
            // 
            // dtPickerDateAct
            // 
            this.dtPickerDateAct.CustomFormat = "";
            this.dtPickerDateAct.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerDateAct.Location = new System.Drawing.Point(252, 143);
            this.dtPickerDateAct.Name = "dtPickerDateAct";
            this.dtPickerDateAct.Size = new System.Drawing.Size(121, 20);
            this.dtPickerDateAct.TabIndex = 16;
            // 
            // lbHrDebutAct
            // 
            this.lbHrDebutAct.AutoSize = true;
            this.lbHrDebutAct.Location = new System.Drawing.Point(150, 245);
            this.lbHrDebutAct.Name = "lbHrDebutAct";
            this.lbHrDebutAct.Size = new System.Drawing.Size(72, 13);
            this.lbHrDebutAct.TabIndex = 8;
            this.lbHrDebutAct.Text = "Heure début :";
            // 
            // dtPickerHrDebut
            // 
            this.dtPickerHrDebut.CustomFormat = "HH:mm";
            this.dtPickerHrDebut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPickerHrDebut.Location = new System.Drawing.Point(251, 239);
            this.dtPickerHrDebut.Margin = new System.Windows.Forms.Padding(2);
            this.dtPickerHrDebut.Name = "dtPickerHrDebut";
            this.dtPickerHrDebut.ShowUpDown = true;
            this.dtPickerHrDebut.Size = new System.Drawing.Size(62, 20);
            this.dtPickerHrDebut.TabIndex = 25;
            // 
            // EnregistrerActiviteEncadrant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
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
            this.Controls.Add(this.lbEnregistrerActivite);
            this.Controls.Add(this.lbHrFinAct);
            this.Controls.Add(this.lbHrDebutAct);
            this.Controls.Add(this.lbDateAct);
            this.Controls.Add(this.lbHrRdvAct);
            this.Controls.Add(this.lbCodeAnim);
            this.Controls.Add(this.lbPrixAct);
            this.Controls.Add(this.sideBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EnregistrerActiviteEncadrant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enregistrer une activité";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnPrixAct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SideBar sideBar1;
        private System.Windows.Forms.Label lbEnregistrerActivite;
        private System.Windows.Forms.DateTimePicker dtPickerHrFin;
        private System.Windows.Forms.Label lbHrFinAct;
        private System.Windows.Forms.ComboBox comboBCodeAnimation;
        private System.Windows.Forms.ComboBox cmbBoxResponsable;
        private System.Windows.Forms.Label lbCodeEtatAct;
        private System.Windows.Forms.Label lbPrenomResponsable;
        private System.Windows.Forms.Label lbDateAct;
        private System.Windows.Forms.Label lbHrRdvAct;
        private System.Windows.Forms.ComboBox comboBCodeEtatAct;
        private System.Windows.Forms.Label lbCodeAnim;
        private System.Windows.Forms.Label lbDateAnnuleAct;
        private System.Windows.Forms.DateTimePicker dtPickerHrRdv;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.DateTimePicker dtPickerAnnulActivite;
        private System.Windows.Forms.NumericUpDown numUpDwnPrixAct;
        private System.Windows.Forms.Label lbPrixAct;
        private System.Windows.Forms.DateTimePicker dtPickerDateAct;
        private System.Windows.Forms.Label lbHrDebutAct;
        private System.Windows.Forms.DateTimePicker dtPickerHrDebut;
    }
}