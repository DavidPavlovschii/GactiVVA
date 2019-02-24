namespace Gacti_PPE.Encadrant
{
    partial class EnregistrerAnimationEncadrant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnregistrerAnimationEncadrant));
            this.btnEnregistrerAnim = new System.Windows.Forms.Button();
            this.lbCdAnim = new System.Windows.Forms.Label();
            this.lbCdTypeAnim = new System.Windows.Forms.Label();
            this.lbNomAnim = new System.Windows.Forms.Label();
            this.lbDtValiditeAnim = new System.Windows.Forms.Label();
            this.lbDureeAnim = new System.Windows.Forms.Label();
            this.lbLimiteAge = new System.Windows.Forms.Label();
            this.lbTarifAnim = new System.Windows.Forms.Label();
            this.lbNbrePlaceAnim = new System.Windows.Forms.Label();
            this.lbDescriptionAnim = new System.Windows.Forms.Label();
            this.lbCommentAnim = new System.Windows.Forms.Label();
            this.lbDifficulteAnim = new System.Windows.Forms.Label();
            this.lbEnregistrementDUneNouvelleActivite = new System.Windows.Forms.Label();
            this.rTextBDescriptif = new System.Windows.Forms.RichTextBox();
            this.rTextBCommentaire = new System.Windows.Forms.RichTextBox();
            this.textBCodeAnim = new System.Windows.Forms.TextBox();
            this.textBNomAnim = new System.Windows.Forms.TextBox();
            this.numUpDwnTarif = new System.Windows.Forms.NumericUpDown();
            this.numUpDwnDureeAnim = new System.Windows.Forms.NumericUpDown();
            this.numUpDwnLimiteAge = new System.Windows.Forms.NumericUpDown();
            this.numUpDwnNbrePlaceAnim = new System.Windows.Forms.NumericUpDown();
            this.cmbBoxDifficulteAnim = new System.Windows.Forms.ComboBox();
            this.dtTimePickerDateValiditeAnim = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCodeDuTypeAnimation = new System.Windows.Forms.ComboBox();
            this.sideBar1 = new Gacti_PPE.Encadrant.SideBar();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnTarif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnDureeAnim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnLimiteAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnNbrePlaceAnim)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnregistrerAnim
            // 
            this.btnEnregistrerAnim.Location = new System.Drawing.Point(113, 368);
            this.btnEnregistrerAnim.Name = "btnEnregistrerAnim";
            this.btnEnregistrerAnim.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrerAnim.TabIndex = 1;
            this.btnEnregistrerAnim.Text = "Enregistrer";
            this.btnEnregistrerAnim.UseVisualStyleBackColor = true;
            this.btnEnregistrerAnim.Click += new System.EventHandler(this.btnEnregistrerAnim_Click);
            // 
            // lbCdAnim
            // 
            this.lbCdAnim.AutoSize = true;
            this.lbCdAnim.Location = new System.Drawing.Point(113, 82);
            this.lbCdAnim.Name = "lbCdAnim";
            this.lbCdAnim.Size = new System.Drawing.Size(38, 13);
            this.lbCdAnim.TabIndex = 2;
            this.lbCdAnim.Text = "Code :";
            // 
            // lbCdTypeAnim
            // 
            this.lbCdTypeAnim.AutoSize = true;
            this.lbCdTypeAnim.Location = new System.Drawing.Point(438, 85);
            this.lbCdTypeAnim.Name = "lbCdTypeAnim";
            this.lbCdTypeAnim.Size = new System.Drawing.Size(76, 13);
            this.lbCdTypeAnim.TabIndex = 3;
            this.lbCdTypeAnim.Text = "Code du type :";
            // 
            // lbNomAnim
            // 
            this.lbNomAnim.AutoSize = true;
            this.lbNomAnim.Location = new System.Drawing.Point(110, 114);
            this.lbNomAnim.Name = "lbNomAnim";
            this.lbNomAnim.Size = new System.Drawing.Size(35, 13);
            this.lbNomAnim.TabIndex = 4;
            this.lbNomAnim.Text = "Nom :";
            // 
            // lbDtValiditeAnim
            // 
            this.lbDtValiditeAnim.AutoSize = true;
            this.lbDtValiditeAnim.Location = new System.Drawing.Point(111, 152);
            this.lbDtValiditeAnim.Name = "lbDtValiditeAnim";
            this.lbDtValiditeAnim.Size = new System.Drawing.Size(87, 13);
            this.lbDtValiditeAnim.TabIndex = 6;
            this.lbDtValiditeAnim.Text = "Date de validité :";
            // 
            // lbDureeAnim
            // 
            this.lbDureeAnim.AutoSize = true;
            this.lbDureeAnim.Location = new System.Drawing.Point(114, 187);
            this.lbDureeAnim.Name = "lbDureeAnim";
            this.lbDureeAnim.Size = new System.Drawing.Size(90, 13);
            this.lbDureeAnim.TabIndex = 7;
            this.lbDureeAnim.Text = "Durée (minutes) : ";
            // 
            // lbLimiteAge
            // 
            this.lbLimiteAge.AutoSize = true;
            this.lbLimiteAge.Location = new System.Drawing.Point(113, 215);
            this.lbLimiteAge.Name = "lbLimiteAge";
            this.lbLimiteAge.Size = new System.Drawing.Size(142, 13);
            this.lbLimiteAge.TabIndex = 8;
            this.lbLimiteAge.Text = "Age minimum (limite d\'age)  : ";
            // 
            // lbTarifAnim
            // 
            this.lbTarifAnim.AutoSize = true;
            this.lbTarifAnim.Location = new System.Drawing.Point(113, 243);
            this.lbTarifAnim.Name = "lbTarifAnim";
            this.lbTarifAnim.Size = new System.Drawing.Size(49, 13);
            this.lbTarifAnim.TabIndex = 9;
            this.lbTarifAnim.Text = "Tarif (€) :";
            // 
            // lbNbrePlaceAnim
            // 
            this.lbNbrePlaceAnim.AutoSize = true;
            this.lbNbrePlaceAnim.Location = new System.Drawing.Point(113, 267);
            this.lbNbrePlaceAnim.Name = "lbNbrePlaceAnim";
            this.lbNbrePlaceAnim.Size = new System.Drawing.Size(102, 13);
            this.lbNbrePlaceAnim.TabIndex = 10;
            this.lbNbrePlaceAnim.Text = "Nombre de places : ";
            // 
            // lbDescriptionAnim
            // 
            this.lbDescriptionAnim.AutoSize = true;
            this.lbDescriptionAnim.Location = new System.Drawing.Point(446, 140);
            this.lbDescriptionAnim.Name = "lbDescriptionAnim";
            this.lbDescriptionAnim.Size = new System.Drawing.Size(66, 13);
            this.lbDescriptionAnim.TabIndex = 11;
            this.lbDescriptionAnim.Text = "Description :";
            // 
            // lbCommentAnim
            // 
            this.lbCommentAnim.AutoSize = true;
            this.lbCommentAnim.Location = new System.Drawing.Point(435, 250);
            this.lbCommentAnim.Name = "lbCommentAnim";
            this.lbCommentAnim.Size = new System.Drawing.Size(77, 13);
            this.lbCommentAnim.TabIndex = 12;
            this.lbCommentAnim.Text = "Commentaire : ";
            // 
            // lbDifficulteAnim
            // 
            this.lbDifficulteAnim.AutoSize = true;
            this.lbDifficulteAnim.Location = new System.Drawing.Point(113, 294);
            this.lbDifficulteAnim.Name = "lbDifficulteAnim";
            this.lbDifficulteAnim.Size = new System.Drawing.Size(57, 13);
            this.lbDifficulteAnim.TabIndex = 13;
            this.lbDifficulteAnim.Text = "Difficulté : ";
            // 
            // lbEnregistrementDUneNouvelleActivite
            // 
            this.lbEnregistrementDUneNouvelleActivite.AutoSize = true;
            this.lbEnregistrementDUneNouvelleActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lbEnregistrementDUneNouvelleActivite.Location = new System.Drawing.Point(113, 20);
            this.lbEnregistrementDUneNouvelleActivite.Name = "lbEnregistrementDUneNouvelleActivite";
            this.lbEnregistrementDUneNouvelleActivite.Size = new System.Drawing.Size(282, 20);
            this.lbEnregistrementDUneNouvelleActivite.TabIndex = 15;
            this.lbEnregistrementDUneNouvelleActivite.Text = "Enregistrer une nouvelle animation : ";
            // 
            // rTextBDescriptif
            // 
            this.rTextBDescriptif.Location = new System.Drawing.Point(518, 137);
            this.rTextBDescriptif.MaxLength = 240;
            this.rTextBDescriptif.Name = "rTextBDescriptif";
            this.rTextBDescriptif.Size = new System.Drawing.Size(259, 96);
            this.rTextBDescriptif.TabIndex = 16;
            this.rTextBDescriptif.Text = "";
            // 
            // rTextBCommentaire
            // 
            this.rTextBCommentaire.Location = new System.Drawing.Point(518, 247);
            this.rTextBCommentaire.MaxLength = 240;
            this.rTextBCommentaire.Name = "rTextBCommentaire";
            this.rTextBCommentaire.Size = new System.Drawing.Size(259, 96);
            this.rTextBCommentaire.TabIndex = 17;
            this.rTextBCommentaire.Text = "";
            // 
            // textBCodeAnim
            // 
            this.textBCodeAnim.Location = new System.Drawing.Point(156, 82);
            this.textBCodeAnim.MaxLength = 8;
            this.textBCodeAnim.Name = "textBCodeAnim";
            this.textBCodeAnim.Size = new System.Drawing.Size(100, 20);
            this.textBCodeAnim.TabIndex = 18;
            // 
            // textBNomAnim
            // 
            this.textBNomAnim.Location = new System.Drawing.Point(155, 111);
            this.textBNomAnim.MaxLength = 40;
            this.textBNomAnim.Name = "textBNomAnim";
            this.textBNomAnim.Size = new System.Drawing.Size(100, 20);
            this.textBNomAnim.TabIndex = 19;
            // 
            // numUpDwnTarif
            // 
            this.numUpDwnTarif.Location = new System.Drawing.Point(261, 239);
            this.numUpDwnTarif.Maximum = new decimal(new int[] {
            35000,
            0,
            0,
            0});
            this.numUpDwnTarif.Name = "numUpDwnTarif";
            this.numUpDwnTarif.Size = new System.Drawing.Size(98, 20);
            this.numUpDwnTarif.TabIndex = 20;
            // 
            // numUpDwnDureeAnim
            // 
            this.numUpDwnDureeAnim.Location = new System.Drawing.Point(261, 185);
            this.numUpDwnDureeAnim.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numUpDwnDureeAnim.Name = "numUpDwnDureeAnim";
            this.numUpDwnDureeAnim.Size = new System.Drawing.Size(98, 20);
            this.numUpDwnDureeAnim.TabIndex = 21;
            // 
            // numUpDwnLimiteAge
            // 
            this.numUpDwnLimiteAge.Location = new System.Drawing.Point(261, 213);
            this.numUpDwnLimiteAge.Maximum = new decimal(new int[] {
            135,
            0,
            0,
            0});
            this.numUpDwnLimiteAge.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numUpDwnLimiteAge.Name = "numUpDwnLimiteAge";
            this.numUpDwnLimiteAge.Size = new System.Drawing.Size(98, 20);
            this.numUpDwnLimiteAge.TabIndex = 22;
            this.numUpDwnLimiteAge.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numUpDwnNbrePlaceAnim
            // 
            this.numUpDwnNbrePlaceAnim.Location = new System.Drawing.Point(261, 265);
            this.numUpDwnNbrePlaceAnim.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numUpDwnNbrePlaceAnim.Name = "numUpDwnNbrePlaceAnim";
            this.numUpDwnNbrePlaceAnim.Size = new System.Drawing.Size(98, 20);
            this.numUpDwnNbrePlaceAnim.TabIndex = 23;
            // 
            // cmbBoxDifficulteAnim
            // 
            this.cmbBoxDifficulteAnim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxDifficulteAnim.FormattingEnabled = true;
            this.cmbBoxDifficulteAnim.Items.AddRange(new object[] {
            "Très facile",
            "Facile",
            "Moyenne",
            "Difficile",
            "Très difficile",
            "Deus"});
            this.cmbBoxDifficulteAnim.Location = new System.Drawing.Point(261, 291);
            this.cmbBoxDifficulteAnim.Name = "cmbBoxDifficulteAnim";
            this.cmbBoxDifficulteAnim.Size = new System.Drawing.Size(98, 21);
            this.cmbBoxDifficulteAnim.TabIndex = 24;
            // 
            // dtTimePickerDateValiditeAnim
            // 
            this.dtTimePickerDateValiditeAnim.CustomFormat = "";
            this.dtTimePickerDateValiditeAnim.Location = new System.Drawing.Point(204, 149);
            this.dtTimePickerDateValiditeAnim.Name = "dtTimePickerDateValiditeAnim";
            this.dtTimePickerDateValiditeAnim.Size = new System.Drawing.Size(155, 20);
            this.dtTimePickerDateValiditeAnim.TabIndex = 25;
            // 
            // comboBoxCodeDuTypeAnimation
            // 
            this.comboBoxCodeDuTypeAnimation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCodeDuTypeAnimation.FormattingEnabled = true;
            this.comboBoxCodeDuTypeAnimation.Location = new System.Drawing.Point(518, 82);
            this.comboBoxCodeDuTypeAnimation.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCodeDuTypeAnimation.Name = "comboBoxCodeDuTypeAnimation";
            this.comboBoxCodeDuTypeAnimation.Size = new System.Drawing.Size(92, 21);
            this.comboBoxCodeDuTypeAnimation.TabIndex = 26;
            // 
            // sideBar1
            // 
            this.sideBar1.Location = new System.Drawing.Point(2, 2);
            this.sideBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sideBar1.Name = "sideBar1";
            this.sideBar1.Size = new System.Drawing.Size(90, 456);
            this.sideBar1.TabIndex = 0;
            // 
            // EnregistrerAnimationEncadrant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.comboBoxCodeDuTypeAnimation);
            this.Controls.Add(this.dtTimePickerDateValiditeAnim);
            this.Controls.Add(this.cmbBoxDifficulteAnim);
            this.Controls.Add(this.numUpDwnNbrePlaceAnim);
            this.Controls.Add(this.numUpDwnLimiteAge);
            this.Controls.Add(this.numUpDwnDureeAnim);
            this.Controls.Add(this.numUpDwnTarif);
            this.Controls.Add(this.textBNomAnim);
            this.Controls.Add(this.textBCodeAnim);
            this.Controls.Add(this.rTextBCommentaire);
            this.Controls.Add(this.rTextBDescriptif);
            this.Controls.Add(this.lbEnregistrementDUneNouvelleActivite);
            this.Controls.Add(this.lbDifficulteAnim);
            this.Controls.Add(this.lbCommentAnim);
            this.Controls.Add(this.lbDescriptionAnim);
            this.Controls.Add(this.lbNbrePlaceAnim);
            this.Controls.Add(this.lbTarifAnim);
            this.Controls.Add(this.lbLimiteAge);
            this.Controls.Add(this.lbDureeAnim);
            this.Controls.Add(this.lbDtValiditeAnim);
            this.Controls.Add(this.lbNomAnim);
            this.Controls.Add(this.lbCdTypeAnim);
            this.Controls.Add(this.lbCdAnim);
            this.Controls.Add(this.btnEnregistrerAnim);
            this.Controls.Add(this.sideBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EnregistrerAnimationEncadrant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enregistrer une animation";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnTarif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnDureeAnim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnLimiteAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnNbrePlaceAnim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SideBar sideBar1;
        private System.Windows.Forms.Button btnEnregistrerAnim;
        private System.Windows.Forms.Label lbCdAnim;
        private System.Windows.Forms.Label lbCdTypeAnim;
        private System.Windows.Forms.Label lbNomAnim;
        private System.Windows.Forms.Label lbDtValiditeAnim;
        private System.Windows.Forms.Label lbDureeAnim;
        private System.Windows.Forms.Label lbLimiteAge;
        private System.Windows.Forms.Label lbTarifAnim;
        private System.Windows.Forms.Label lbNbrePlaceAnim;
        private System.Windows.Forms.Label lbDescriptionAnim;
        private System.Windows.Forms.Label lbCommentAnim;
        private System.Windows.Forms.Label lbDifficulteAnim;
        private System.Windows.Forms.Label lbEnregistrementDUneNouvelleActivite;
        private System.Windows.Forms.RichTextBox rTextBDescriptif;
        private System.Windows.Forms.RichTextBox rTextBCommentaire;
        private System.Windows.Forms.TextBox textBCodeAnim;
        private System.Windows.Forms.TextBox textBNomAnim;
        private System.Windows.Forms.NumericUpDown numUpDwnTarif;
        private System.Windows.Forms.NumericUpDown numUpDwnDureeAnim;
        private System.Windows.Forms.NumericUpDown numUpDwnLimiteAge;
        private System.Windows.Forms.NumericUpDown numUpDwnNbrePlaceAnim;
        private System.Windows.Forms.ComboBox cmbBoxDifficulteAnim;
        private System.Windows.Forms.DateTimePicker dtTimePickerDateValiditeAnim;
        private System.Windows.Forms.ComboBox comboBoxCodeDuTypeAnimation;
    }
}