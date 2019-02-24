namespace Gacti_PPE
{
    partial class PlanningDesActivitesPourUneSeuleAnimation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanningDesActivitesPourUneSeuleAnimation));
            this.listBPlanningActivitesPourUneAnimation = new System.Windows.Forms.ListBox();
            this.lbNomAnimation = new System.Windows.Forms.Label();
            this.lbPlanningActivites = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBPlanningActivitesPourUneAnimation
            // 
            this.listBPlanningActivitesPourUneAnimation.FormattingEnabled = true;
            this.listBPlanningActivitesPourUneAnimation.Location = new System.Drawing.Point(12, 46);
            this.listBPlanningActivitesPourUneAnimation.Name = "listBPlanningActivitesPourUneAnimation";
            this.listBPlanningActivitesPourUneAnimation.Size = new System.Drawing.Size(452, 212);
            this.listBPlanningActivitesPourUneAnimation.TabIndex = 13;
            // 
            // lbNomAnimation
            // 
            this.lbNomAnimation.AutoSize = true;
            this.lbNomAnimation.Location = new System.Drawing.Point(237, 9);
            this.lbNomAnimation.Name = "lbNomAnimation";
            this.lbNomAnimation.Size = new System.Drawing.Size(93, 13);
            this.lbNomAnimation.TabIndex = 12;
            this.lbNomAnimation.Text = "{{ uneAnimation }}";
            // 
            // lbPlanningActivites
            // 
            this.lbPlanningActivites.AutoSize = true;
            this.lbPlanningActivites.Location = new System.Drawing.Point(9, 9);
            this.lbPlanningActivites.Name = "lbPlanningActivites";
            this.lbPlanningActivites.Size = new System.Drawing.Size(222, 13);
            this.lbPlanningActivites.TabIndex = 11;
            this.lbPlanningActivites.Text = "Planning des activités concernant l\'animation ";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(12, 294);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 10;
            this.btnQuitter.Text = "Retour";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // PlanningDesActivitesPourUneSeuleAnimation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 333);
            this.ControlBox = false;
            this.Controls.Add(this.listBPlanningActivitesPourUneAnimation);
            this.Controls.Add(this.lbNomAnimation);
            this.Controls.Add(this.lbPlanningActivites);
            this.Controls.Add(this.btnQuitter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlanningDesActivitesPourUneSeuleAnimation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Planning des activités d\'une animation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBPlanningActivitesPourUneAnimation;
        private System.Windows.Forms.Label lbNomAnimation;
        private System.Windows.Forms.Label lbPlanningActivites;
        private System.Windows.Forms.Button btnQuitter;
    }
}