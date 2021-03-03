namespace WindowsForms_Agenda_de_Activitati
{
    partial class FormDetalii
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
            this.rtDetalii = new System.Windows.Forms.RichTextBox();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtDetalii
            // 
            this.rtDetalii.AcceptsTab = true;
            this.rtDetalii.BackColor = System.Drawing.SystemColors.Window;
            this.rtDetalii.Location = new System.Drawing.Point(18, 55);
            this.rtDetalii.Name = "rtDetalii";
            this.rtDetalii.Size = new System.Drawing.Size(285, 296);
            this.rtDetalii.TabIndex = 1;
            this.rtDetalii.Text = "";
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.BackColor = System.Drawing.SystemColors.Menu;
            this.btnSalveaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalveaza.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalveaza.Location = new System.Drawing.Point(21, 432);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(105, 39);
            this.btnSalveaza.TabIndex = 23;
            this.btnSalveaza.Text = "Salvează";
            this.btnSalveaza.UseVisualStyleBackColor = false;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // btnSterge
            // 
            this.btnSterge.BackColor = System.Drawing.SystemColors.Menu;
            this.btnSterge.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSterge.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSterge.Location = new System.Drawing.Point(242, 432);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(105, 39);
            this.btnSterge.TabIndex = 23;
            this.btnSterge.Text = "Șterge";
            this.btnSterge.UseVisualStyleBackColor = false;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtDetalii);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 380);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detali Activitate";
            // 
            // FormDetalii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(359, 491);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.btnSterge);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormDetalii";
            this.Text = "Adăugați Detalii";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtDetalii;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}