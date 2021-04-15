
namespace AqlProjet_Final
{
    partial class Form3
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
            this.sourcenom = new System.Windows.Forms.TextBox();
            this.sourceprenom = new System.Windows.Forms.TextBox();
            this.sourcenumetudiant = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Enregistrer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sourcenom
            // 
            this.sourcenom.Location = new System.Drawing.Point(357, 232);
            this.sourcenom.Name = "sourcenom";
            this.sourcenom.Size = new System.Drawing.Size(179, 26);
            this.sourcenom.TabIndex = 19;
            // 
            // sourceprenom
            // 
            this.sourceprenom.Location = new System.Drawing.Point(357, 306);
            this.sourceprenom.Name = "sourceprenom";
            this.sourceprenom.Size = new System.Drawing.Size(179, 26);
            this.sourceprenom.TabIndex = 18;
            // 
            // sourcenumetudiant
            // 
            this.sourcenumetudiant.Location = new System.Drawing.Point(357, 153);
            this.sourcenumetudiant.Name = "sourcenumetudiant";
            this.sourcenumetudiant.Size = new System.Drawing.Size(179, 26);
            this.sourcenumetudiant.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Numéro d\'etudiant :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Prénom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ajouter un  Etudiant ";
            // 
            // Enregistrer
            // 
            this.Enregistrer.Location = new System.Drawing.Point(334, 422);
            this.Enregistrer.Name = "Enregistrer";
            this.Enregistrer.Size = new System.Drawing.Size(131, 41);
            this.Enregistrer.TabIndex = 20;
            this.Enregistrer.Text = "Enregistrer";
            this.Enregistrer.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 550);
            this.Controls.Add(this.Enregistrer);
            this.Controls.Add(this.sourcenom);
            this.Controls.Add(this.sourceprenom);
            this.Controls.Add(this.sourcenumetudiant);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sourcenom;
        private System.Windows.Forms.TextBox sourceprenom;
        private System.Windows.Forms.TextBox sourcenumetudiant;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Enregistrer;
    }
}