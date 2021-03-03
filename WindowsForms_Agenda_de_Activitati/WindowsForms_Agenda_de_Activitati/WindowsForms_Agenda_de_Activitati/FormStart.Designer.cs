namespace WindowsForms_Agenda_de_Activitati
{
    partial class FormStart
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnProiecte = new System.Windows.Forms.Button();
            this.btnEveniment = new System.Windows.Forms.Button();
            this.btnFamilie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agenda de activități";
            // 
            // btnProiecte
            // 
            this.btnProiecte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProiecte.Location = new System.Drawing.Point(100, 115);
            this.btnProiecte.Name = "btnProiecte";
            this.btnProiecte.Size = new System.Drawing.Size(185, 57);
            this.btnProiecte.TabIndex = 1;
            this.btnProiecte.Text = "Proiect";
            this.btnProiecte.UseVisualStyleBackColor = true;
            this.btnProiecte.Click += new System.EventHandler(this.btnProiecte_Click);
            // 
            // btnEveniment
            // 
            this.btnEveniment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEveniment.Location = new System.Drawing.Point(100, 217);
            this.btnEveniment.Name = "btnEveniment";
            this.btnEveniment.Size = new System.Drawing.Size(185, 57);
            this.btnEveniment.TabIndex = 2;
            this.btnEveniment.Text = "Eveniment Firma";
            this.btnEveniment.UseVisualStyleBackColor = true;
            this.btnEveniment.Click += new System.EventHandler(this.btnEveniment_Click);
            // 
            // btnFamilie
            // 
            this.btnFamilie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFamilie.Location = new System.Drawing.Point(100, 335);
            this.btnFamilie.Name = "btnFamilie";
            this.btnFamilie.Size = new System.Drawing.Size(185, 57);
            this.btnFamilie.TabIndex = 3;
            this.btnFamilie.Text = "Familie";
            this.btnFamilie.UseVisualStyleBackColor = true;
            this.btnFamilie.Click += new System.EventHandler(this.btnFamilie_Click);
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(401, 447);
            this.Controls.Add(this.btnFamilie);
            this.Controls.Add(this.btnEveniment);
            this.Controls.Add(this.btnProiecte);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormStart";
            this.Text = "Start";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProiecte;
        private System.Windows.Forms.Button btnEveniment;
        private System.Windows.Forms.Button btnFamilie;
    }
}