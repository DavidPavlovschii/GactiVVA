namespace Gacti_PPE.Encadrant
{
    partial class ModifierAnimationEncadrant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifierAnimationEncadrant));
            this.btnQuitter = new System.Windows.Forms.Button();
            this.dtTimePickerDateValiditeAnim = new System.Windows.Forms.DateTimePicker();
            this.cmbBoxDifficulteAnim = new System.Windows.Forms.ComboBox();
            this.numUpDwnNbrePlaceAnim = new System.Windows.Forms.NumericUpDown();
            this.numUpDwnLimiteAge = new System.Windows.Forms.NumericUpDown();
            this.numUpDwnDureeAnim = new System.Windows.Forms.NumericUpDown();
            this.numUpDwnTarif = new System.Windows.Forms.NumericUpDown();
            this.textBNomAnim = new System.Windows.Forms.TextBox();
            this.textBCodeAnim = new System.Windows.Forms.TextBox();
            this.rTextBCommentaire = new System.Windows.Forms.RichTextBox();
            this.rTextBDescriptif = new System.Windows.Forms.RichTextBox();
            this.lbDifficulteAnim = new System.Windows.Forms.Label();
            this.lbCommentAnim = new System.Windows.Forms.Label();
            this.lbDescriptionAnim = new System.Windows.Forms.Label();
            this.lbNbrePlaceAnim = new System.Windows.Forms.Label();
            this.lbTarifAnim = new System.Windows.Forms.Label();
            this.lbLimiteAge = new System.Windows.Forms.Label();
            this.lbDureeAnim = new System.Windows.Forms.Label();
            this.lbDtValiditeAnim = new System.Windows.Forms.Label();
            this.lbNomAnim = new System.Windows.Forms.Label();
            this.lbCdAnim = new System.Windows.Forms.Label();
            this.btnEnregistrerModifAnim = new System.Windows.Forms.Button();
            this.comboBoxCodeDuTypeAnimation = new System.Windows.Forms.ComboBox();
            this.lbCodeTypeAnim = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbModifierAnimation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnNbrePlaceAnim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnLimiteAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnDureeAnim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnTarif)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(123, 354);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 39);
            this.btnQuitter.TabIndex = 0;
            this.btnQuitter.Text = "Retour";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // dtTimePickerDateValiditeAnim
            // 
            this.dtTimePickerDateValiditeAnim.Location = new System.Drawing.Point(110, 147);
            this.dtTimePickerDateValiditeAnim.Name = "dtTimePickerDateValiditeAnim";
            this.dtTimePickerDateValiditeAnim.Size = new System.Drawing.Size(166, 20);
            this.dtTimePickerDateValiditeAnim.TabIndex = 46;
            // 
            // cmbBoxDifficulteAnim
            // 
            this.cmbBoxDifficulteAnim.FormattingEnabled = true;
            this.cmbBoxDifficulteAnim.Items.AddRange(new object[] {
            "Très facile",
            "Facile",
            "Moyenne",
            "Difficile",
            "Très difficile",
            "Deus"});
            this.cmbBoxDifficulteAnim.Location = new System.Drawing.Point(74, 307);
            this.cmbBoxDifficulteAnim.Name = "cmbBoxDifficulteAnim";
            this.cmbBoxDifficulteAnim.Size = new System.Drawing.Size(88, 21);
            this.cmbBoxDifficulteAnim.TabIndex = 45;
            // 
            // numUpDwnNbrePlaceAnim
            // 
            this.numUpDwnNbrePlaceAnim.Location = new System.Drawing.Point(123, 267);
            this.numUpDwnNbrePlaceAnim.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numUpDwnNbrePlaceAnim.Name = "numUpDwnNbrePlaceAnim";
            this.numUpDwnNbrePlaceAnim.Size = new System.Drawing.Size(54, 20);
            this.numUpDwnNbrePlaceAnim.TabIndex = 44;
            // 
            // numUpDwnLimiteAge
            // 
            this.numUpDwnLimiteAge.Location = new System.Drawing.Point(165, 215);
            this.numUpDwnLimiteAge.Maximum = new decimal(new int[] {
            130,
            0,
            0,
            0});
            this.numUpDwnLimiteAge.Name = "numUpDwnLimiteAge";
            this.numUpDwnLimiteAge.Size = new System.Drawing.Size(62, 20);
            this.numUpDwnLimiteAge.TabIndex = 43;
            // 
            // numUpDwnDureeAnim
            // 
            this.numUpDwnDureeAnim.Location = new System.Drawing.Point(68, 189);
            this.numUpDwnDureeAnim.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numUpDwnDureeAnim.Name = "numUpDwnDureeAnim";
            this.numUpDwnDureeAnim.Size = new System.Drawing.Size(51, 20);
            this.numUpDwnDureeAnim.TabIndex = 42;
            // 
            // numUpDwnTarif
            // 
            this.numUpDwnTarif.Location = new System.Drawing.Point(57, 243);
            this.numUpDwnTarif.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numUpDwnTarif.Name = "numUpDwnTarif";
            this.numUpDwnTarif.Size = new System.Drawing.Size(62, 20);
            this.numUpDwnTarif.TabIndex = 41;
            // 
            // textBNomAnim
            // 
            this.textBNomAnim.Location = new System.Drawing.Point(62, 116);
            this.textBNomAnim.MaxLength = 39;
            this.textBNomAnim.Name = "textBNomAnim";
            this.textBNomAnim.Size = new System.Drawing.Size(100, 20);
            this.textBNomAnim.TabIndex = 40;
            // 
            // textBCodeAnim
            // 
            this.textBCodeAnim.Location = new System.Drawing.Point(61, 81);
            this.textBCodeAnim.MaxLength = 8;
            this.textBCodeAnim.Name = "textBCodeAnim";
            this.textBCodeAnim.Size = new System.Drawing.Size(100, 20);
            this.textBCodeAnim.TabIndex = 39;
            // 
            // rTextBCommentaire
            // 
            this.rTextBCommentaire.Location = new System.Drawing.Point(365, 266);
            this.rTextBCommentaire.MaxLength = 235;
            this.rTextBCommentaire.Name = "rTextBCommentaire";
            this.rTextBCommentaire.Size = new System.Drawing.Size(259, 96);
            this.rTextBCommentaire.TabIndex = 38;
            this.rTextBCommentaire.Text = "";
            // 
            // rTextBDescriptif
            // 
            this.rTextBDescriptif.Location = new System.Drawing.Point(365, 156);
            this.rTextBDescriptif.MaxLength = 235;
            this.rTextBDescriptif.Name = "rTextBDescriptif";
            this.rTextBDescriptif.Size = new System.Drawing.Size(259, 96);
            this.rTextBDescriptif.TabIndex = 37;
            this.rTextBDescriptif.Text = "";
            // 
            // lbDifficulteAnim
            // 
            this.lbDifficulteAnim.AutoSize = true;
            this.lbDifficulteAnim.Location = new System.Drawing.Point(17, 310);
            this.lbDifficulteAnim.Name = "lbDifficulteAnim";
            this.lbDifficulteAnim.Size = new System.Drawing.Size(57, 13);
            this.lbDifficulteAnim.TabIndex = 36;
            this.lbDifficulteAnim.Text = "Difficulté : ";
            // 
            // lbCommentAnim
            // 
            this.lbCommentAnim.AutoSize = true;
            this.lbCommentAnim.Location = new System.Drawing.Point(282, 269);
            this.lbCommentAnim.Name = "lbCommentAnim";
            this.lbCommentAnim.Size = new System.Drawing.Size(77, 13);
            this.lbCommentAnim.TabIndex = 35;
            this.lbCommentAnim.Text = "Commentaire : ";
            // 
            // lbDescriptionAnim
            // 
            this.lbDescriptionAnim.AutoSize = true;
            this.lbDescriptionAnim.Location = new System.Drawing.Point(293, 159);
            this.lbDescriptionAnim.Name = "lbDescriptionAnim";
            this.lbDescriptionAnim.Size = new System.Drawing.Size(66, 13);
            this.lbDescriptionAnim.TabIndex = 34;
            this.lbDescriptionAnim.Text = "Description :";
            // 
            // lbNbrePlaceAnim
            // 
            this.lbNbrePlaceAnim.AutoSize = true;
            this.lbNbrePlaceAnim.Location = new System.Drawing.Point(17, 269);
            this.lbNbrePlaceAnim.Name = "lbNbrePlaceAnim";
            this.lbNbrePlaceAnim.Size = new System.Drawing.Size(102, 13);
            this.lbNbrePlaceAnim.TabIndex = 33;
            this.lbNbrePlaceAnim.Text = "Nombre de places : ";
            // 
            // lbTarifAnim
            // 
            this.lbTarifAnim.AutoSize = true;
            this.lbTarifAnim.Location = new System.Drawing.Point(17, 245);
            this.lbTarifAnim.Name = "lbTarifAnim";
            this.lbTarifAnim.Size = new System.Drawing.Size(34, 13);
            this.lbTarifAnim.TabIndex = 32;
            this.lbTarifAnim.Text = "Tarif :";
            // 
            // lbLimiteAge
            // 
            this.lbLimiteAge.AutoSize = true;
            this.lbLimiteAge.Location = new System.Drawing.Point(17, 217);
            this.lbLimiteAge.Name = "lbLimiteAge";
            this.lbLimiteAge.Size = new System.Drawing.Size(142, 13);
            this.lbLimiteAge.TabIndex = 31;
            this.lbLimiteAge.Text = "Age minimum (limite d\'age)  : ";
            // 
            // lbDureeAnim
            // 
            this.lbDureeAnim.AutoSize = true;
            this.lbDureeAnim.Location = new System.Drawing.Point(17, 191);
            this.lbDureeAnim.Name = "lbDureeAnim";
            this.lbDureeAnim.Size = new System.Drawing.Size(45, 13);
            this.lbDureeAnim.TabIndex = 30;
            this.lbDureeAnim.Text = "Durée : ";
            // 
            // lbDtValiditeAnim
            // 
            this.lbDtValiditeAnim.AutoSize = true;
            this.lbDtValiditeAnim.Location = new System.Drawing.Point(17, 153);
            this.lbDtValiditeAnim.Name = "lbDtValiditeAnim";
            this.lbDtValiditeAnim.Size = new System.Drawing.Size(87, 13);
            this.lbDtValiditeAnim.TabIndex = 29;
            this.lbDtValiditeAnim.Text = "Date de validité :";
            // 
            // lbNomAnim
            // 
            this.lbNomAnim.AutoSize = true;
            this.lbNomAnim.Location = new System.Drawing.Point(17, 119);
            this.lbNomAnim.Name = "lbNomAnim";
            this.lbNomAnim.Size = new System.Drawing.Size(35, 13);
            this.lbNomAnim.TabIndex = 28;
            this.lbNomAnim.Text = "Nom :";
            // 
            // lbCdAnim
            // 
            this.lbCdAnim.AutoSize = true;
            this.lbCdAnim.Location = new System.Drawing.Point(17, 84);
            this.lbCdAnim.Name = "lbCdAnim";
            this.lbCdAnim.Size = new System.Drawing.Size(38, 13);
            this.lbCdAnim.TabIndex = 27;
            this.lbCdAnim.Text = "Code :";
            // 
            // btnEnregistrerModifAnim
            // 
            this.btnEnregistrerModifAnim.Location = new System.Drawing.Point(20, 354);
            this.btnEnregistrerModifAnim.Name = "btnEnregistrerModifAnim";
            this.btnEnregistrerModifAnim.Size = new System.Drawing.Size(78, 39);
            this.btnEnregistrerModifAnim.TabIndex = 26;
            this.btnEnregistrerModifAnim.Text = "Enregistrer la modification";
            this.btnEnregistrerModifAnim.UseVisualStyleBackColor = true;
            this.btnEnregistrerModifAnim.Click += new System.EventHandler(this.btnEnregistrerModifAnim_Click);
            // 
            // comboBoxCodeDuTypeAnimation
            // 
            this.comboBoxCodeDuTypeAnimation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCodeDuTypeAnimation.FormattingEnabled = true;
            this.comboBoxCodeDuTypeAnimation.Location = new System.Drawing.Point(387, 81);
            this.comboBoxCodeDuTypeAnimation.Name = "comboBoxCodeDuTypeAnimation";
            this.comboBoxCodeDuTypeAnimation.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCodeDuTypeAnimation.TabIndex = 47;
            // 
            // lbCodeTypeAnim
            // 
            this.lbCodeTypeAnim.AutoSize = true;
            this.lbCodeTypeAnim.Location = new System.Drawing.Point(296, 83);
            this.lbCodeTypeAnim.Name = "lbCodeTypeAnim";
            this.lbCodeTypeAnim.Size = new System.Drawing.Size(61, 13);
            this.lbCodeTypeAnim.TabIndex = 48;
            this.lbCodeTypeAnim.Text = "Code type :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "minutes";
            // 
            // lbModifierAnimation
            // 
            this.lbModifierAnimation.AutoSize = true;
            this.lbModifierAnimation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lbModifierAnimation.Location = new System.Drawing.Point(17, 23);
            this.lbModifierAnimation.Name = "lbModifierAnimation";
            this.lbModifierAnimation.Size = new System.Drawing.Size(164, 20);
            this.lbModifierAnimation.TabIndex = 50;
            this.lbModifierAnimation.Text = "Modifier l\'animation :";
            // 
            // ModifierAnimationEncadrant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 404);
            this.ControlBox = false;
            this.Controls.Add(this.lbModifierAnimation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCodeTypeAnim);
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
            this.Controls.Add(this.lbDifficulteAnim);
            this.Controls.Add(this.lbCommentAnim);
            this.Controls.Add(this.lbDescriptionAnim);
            this.Controls.Add(this.lbNbrePlaceAnim);
            this.Controls.Add(this.lbTarifAnim);
            this.Controls.Add(this.lbLimiteAge);
            this.Controls.Add(this.lbDureeAnim);
            this.Controls.Add(this.lbDtValiditeAnim);
            this.Controls.Add(this.lbNomAnim);
            this.Controls.Add(this.lbCdAnim);
            this.Controls.Add(this.btnEnregistrerModifAnim);
            this.Controls.Add(this.btnQuitter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModifierAnimationEncadrant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifier animation";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnNbrePlaceAnim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnLimiteAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnDureeAnim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnTarif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.DateTimePicker dtTimePickerDateValiditeAnim;
        private System.Windows.Forms.ComboBox cmbBoxDifficulteAnim;
        private System.Windows.Forms.NumericUpDown numUpDwnNbrePlaceAnim;
        private System.Windows.Forms.NumericUpDown numUpDwnLimiteAge;
        private System.Windows.Forms.NumericUpDown numUpDwnDureeAnim;
        private System.Windows.Forms.NumericUpDown numUpDwnTarif;
        private System.Windows.Forms.TextBox textBNomAnim;
        private System.Windows.Forms.TextBox textBCodeAnim;
        private System.Windows.Forms.RichTextBox rTextBCommentaire;
        private System.Windows.Forms.RichTextBox rTextBDescriptif;
        private System.Windows.Forms.Label lbDifficulteAnim;
        private System.Windows.Forms.Label lbCommentAnim;
        private System.Windows.Forms.Label lbDescriptionAnim;
        private System.Windows.Forms.Label lbNbrePlaceAnim;
        private System.Windows.Forms.Label lbTarifAnim;
        private System.Windows.Forms.Label lbLimiteAge;
        private System.Windows.Forms.Label lbDureeAnim;
        private System.Windows.Forms.Label lbDtValiditeAnim;
        private System.Windows.Forms.Label lbNomAnim;
        private System.Windows.Forms.Label lbCdAnim;
        private System.Windows.Forms.Button btnEnregistrerModifAnim;
        private System.Windows.Forms.ComboBox comboBoxCodeDuTypeAnimation;
        private System.Windows.Forms.Label lbCodeTypeAnim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbModifierAnimation;
    }
}