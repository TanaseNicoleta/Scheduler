namespace WindowsForms_Agenda_de_Activitati
{
    partial class EditeazaActivitate
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbProgres = new System.Windows.Forms.TextBox();
            this.labelProgres = new System.Windows.Forms.Label();
            this.cbPrioritate = new System.Windows.Forms.ComboBox();
            this.labelPrioritate = new System.Windows.Forms.Label();
            this.dtpIncheiere = new System.Windows.Forms.DateTimePicker();
            this.labelIncheiere = new System.Windows.Forms.Label();
            this.dtpInceput = new System.Windows.Forms.DateTimePicker();
            this.labelInceput = new System.Windows.Forms.Label();
            this.tbLocatie = new System.Windows.Forms.TextBox();
            this.labelLocatie = new System.Windows.Forms.Label();
            this.tbTitlu = new System.Windows.Forms.TextBox();
            this.labelTitlu = new System.Windows.Forms.Label();
            this.cbTip = new System.Windows.Forms.ComboBox();
            this.labelTip = new System.Windows.Forms.Label();
            this.labelDomeniu = new System.Windows.Forms.Label();
            this.cbDomenii = new System.Windows.Forms.ComboBox();
            this.btnAnuleaza = new System.Windows.Forms.Button();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.tbProgres);
            this.groupBox1.Controls.Add(this.labelProgres);
            this.groupBox1.Controls.Add(this.cbPrioritate);
            this.groupBox1.Controls.Add(this.labelPrioritate);
            this.groupBox1.Controls.Add(this.dtpIncheiere);
            this.groupBox1.Controls.Add(this.labelIncheiere);
            this.groupBox1.Controls.Add(this.dtpInceput);
            this.groupBox1.Controls.Add(this.labelInceput);
            this.groupBox1.Controls.Add(this.tbLocatie);
            this.groupBox1.Controls.Add(this.labelLocatie);
            this.groupBox1.Controls.Add(this.tbTitlu);
            this.groupBox1.Controls.Add(this.labelTitlu);
            this.groupBox1.Controls.Add(this.cbTip);
            this.groupBox1.Controls.Add(this.labelTip);
            this.groupBox1.Controls.Add(this.labelDomeniu);
            this.groupBox1.Controls.Add(this.cbDomenii);
            this.groupBox1.Location = new System.Drawing.Point(20, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 397);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalii Activitate";
            // 
            // tbProgres
            // 
            this.tbProgres.Location = new System.Drawing.Point(19, 360);
            this.tbProgres.Name = "tbProgres";
            this.tbProgres.Size = new System.Drawing.Size(215, 22);
            this.tbProgres.TabIndex = 31;
            this.tbProgres.Text = "0%";
            // 
            // labelProgres
            // 
            this.labelProgres.AutoSize = true;
            this.labelProgres.Location = new System.Drawing.Point(16, 340);
            this.labelProgres.Name = "labelProgres";
            this.labelProgres.Size = new System.Drawing.Size(58, 17);
            this.labelProgres.TabIndex = 30;
            this.labelProgres.Text = "Progres";
            // 
            // cbPrioritate
            // 
            this.cbPrioritate.FormattingEnabled = true;
            this.cbPrioritate.Items.AddRange(new object[] {
            "LOW",
            "MEDIUM",
            "HIGH"});
            this.cbPrioritate.Location = new System.Drawing.Point(19, 313);
            this.cbPrioritate.Name = "cbPrioritate";
            this.cbPrioritate.Size = new System.Drawing.Size(215, 24);
            this.cbPrioritate.TabIndex = 29;
            // 
            // labelPrioritate
            // 
            this.labelPrioritate.AutoSize = true;
            this.labelPrioritate.Location = new System.Drawing.Point(16, 293);
            this.labelPrioritate.Name = "labelPrioritate";
            this.labelPrioritate.Size = new System.Drawing.Size(65, 17);
            this.labelPrioritate.TabIndex = 28;
            this.labelPrioritate.Text = "Prioritate";
            // 
            // dtpIncheiere
            // 
            this.dtpIncheiere.Location = new System.Drawing.Point(19, 268);
            this.dtpIncheiere.Name = "dtpIncheiere";
            this.dtpIncheiere.Size = new System.Drawing.Size(215, 22);
            this.dtpIncheiere.TabIndex = 27;
            // 
            // labelIncheiere
            // 
            this.labelIncheiere.AutoSize = true;
            this.labelIncheiere.Location = new System.Drawing.Point(16, 248);
            this.labelIncheiere.Name = "labelIncheiere";
            this.labelIncheiere.Size = new System.Drawing.Size(100, 17);
            this.labelIncheiere.TabIndex = 26;
            this.labelIncheiere.Text = "Data Încheiere";
            // 
            // dtpInceput
            // 
            this.dtpInceput.Location = new System.Drawing.Point(19, 223);
            this.dtpInceput.Name = "dtpInceput";
            this.dtpInceput.Size = new System.Drawing.Size(215, 22);
            this.dtpInceput.TabIndex = 25;
            // 
            // labelInceput
            // 
            this.labelInceput.AutoSize = true;
            this.labelInceput.Location = new System.Drawing.Point(16, 203);
            this.labelInceput.Name = "labelInceput";
            this.labelInceput.Size = new System.Drawing.Size(97, 17);
            this.labelInceput.TabIndex = 24;
            this.labelInceput.Text = "Data Începere";
            // 
            // tbLocatie
            // 
            this.tbLocatie.Location = new System.Drawing.Point(19, 178);
            this.tbLocatie.Name = "tbLocatie";
            this.tbLocatie.Size = new System.Drawing.Size(215, 22);
            this.tbLocatie.TabIndex = 23;
            // 
            // labelLocatie
            // 
            this.labelLocatie.AutoSize = true;
            this.labelLocatie.Location = new System.Drawing.Point(20, 158);
            this.labelLocatie.Name = "labelLocatie";
            this.labelLocatie.Size = new System.Drawing.Size(54, 17);
            this.labelLocatie.TabIndex = 22;
            this.labelLocatie.Text = "Locație";
            // 
            // tbTitlu
            // 
            this.tbTitlu.Location = new System.Drawing.Point(19, 133);
            this.tbTitlu.Name = "tbTitlu";
            this.tbTitlu.Size = new System.Drawing.Size(215, 22);
            this.tbTitlu.TabIndex = 21;
            // 
            // labelTitlu
            // 
            this.labelTitlu.AutoSize = true;
            this.labelTitlu.Location = new System.Drawing.Point(20, 113);
            this.labelTitlu.Name = "labelTitlu";
            this.labelTitlu.Size = new System.Drawing.Size(35, 17);
            this.labelTitlu.TabIndex = 20;
            this.labelTitlu.Text = "Titlu";
            // 
            // cbTip
            // 
            this.cbTip.FormattingEnabled = true;
            this.cbTip.Items.AddRange(new object[] {
            "ȘEDINȚĂ",
            "PREZENTARE",
            "ÎNTÂLNIRE",
            "REALIZARE_PROIECT"});
            this.cbTip.Location = new System.Drawing.Point(19, 86);
            this.cbTip.Name = "cbTip";
            this.cbTip.Size = new System.Drawing.Size(215, 24);
            this.cbTip.TabIndex = 19;
            // 
            // labelTip
            // 
            this.labelTip.AutoSize = true;
            this.labelTip.Location = new System.Drawing.Point(20, 66);
            this.labelTip.Name = "labelTip";
            this.labelTip.Size = new System.Drawing.Size(65, 17);
            this.labelTip.TabIndex = 18;
            this.labelTip.Text = "Activitate";
            // 
            // labelDomeniu
            // 
            this.labelDomeniu.AutoSize = true;
            this.labelDomeniu.Location = new System.Drawing.Point(16, 25);
            this.labelDomeniu.Name = "labelDomeniu";
            this.labelDomeniu.Size = new System.Drawing.Size(64, 17);
            this.labelDomeniu.TabIndex = 17;
            this.labelDomeniu.Text = "Domeniu";
            // 
            // cbDomenii
            // 
            this.cbDomenii.FormattingEnabled = true;
            this.cbDomenii.Items.AddRange(new object[] {
            "MARKETING",
            "FINANȚE",
            "DESIGN",
            "DEZVOLTARE",
            "CONTABILITATE",
            "VÂNZĂRI",
            "RESURSE",
            "CLIENTI"});
            this.cbDomenii.Location = new System.Drawing.Point(19, 39);
            this.cbDomenii.Name = "cbDomenii";
            this.cbDomenii.Size = new System.Drawing.Size(215, 24);
            this.cbDomenii.TabIndex = 16;
            // 
            // btnAnuleaza
            // 
            this.btnAnuleaza.BackColor = System.Drawing.SystemColors.Menu;
            this.btnAnuleaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnuleaza.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnuleaza.Location = new System.Drawing.Point(176, 434);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(116, 48);
            this.btnAnuleaza.TabIndex = 22;
            this.btnAnuleaza.Text = "Anulează";
            this.btnAnuleaza.UseVisualStyleBackColor = false;
            this.btnAnuleaza.Click += new System.EventHandler(this.btnAnuleaza_Click);
            // 
            // btnConfirma
            // 
            this.btnConfirma.BackColor = System.Drawing.SystemColors.Menu;
            this.btnConfirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirma.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirma.Location = new System.Drawing.Point(17, 434);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(116, 48);
            this.btnConfirma.TabIndex = 21;
            this.btnConfirma.Text = "Confirmă";
            this.btnConfirma.UseVisualStyleBackColor = false;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // EditeazaActivitate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(313, 498);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAnuleaza);
            this.Controls.Add(this.btnConfirma);
            this.MaximizeBox = false;
            this.Name = "EditeazaActivitate";
            this.Text = "Editează Activitate";
            this.Load += new System.EventHandler(this.EditeazaActivitate_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbProgres;
        private System.Windows.Forms.Label labelProgres;
        private System.Windows.Forms.ComboBox cbPrioritate;
        private System.Windows.Forms.Label labelPrioritate;
        private System.Windows.Forms.DateTimePicker dtpIncheiere;
        private System.Windows.Forms.Label labelIncheiere;
        private System.Windows.Forms.DateTimePicker dtpInceput;
        private System.Windows.Forms.Label labelInceput;
        private System.Windows.Forms.TextBox tbLocatie;
        private System.Windows.Forms.Label labelLocatie;
        private System.Windows.Forms.TextBox tbTitlu;
        private System.Windows.Forms.Label labelTitlu;
        private System.Windows.Forms.ComboBox cbTip;
        private System.Windows.Forms.Label labelTip;
        private System.Windows.Forms.Label labelDomeniu;
        private System.Windows.Forms.ComboBox cbDomenii;
        private System.Windows.Forms.Button btnAnuleaza;
        private System.Windows.Forms.Button btnConfirma;
    }
}