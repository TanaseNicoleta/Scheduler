namespace WindowsForms_Agenda_de_Activitati
{
    partial class FormFamilie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFamilie));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbPersoane = new System.Windows.Forms.ListBox();
            this.btnAddPers = new System.Windows.Forms.Button();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.labelData = new System.Windows.Forms.Label();
            this.tbLocatie = new System.Windows.Forms.TextBox();
            this.labelLocatie = new System.Windows.Forms.Label();
            this.tbDenumire = new System.Windows.Forms.TextBox();
            this.labelDenumire = new System.Windows.Forms.Label();
            this.btnCurata = new System.Windows.Forms.Button();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.dgvFamilie = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denumireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataActivitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detaliiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prioritateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activitatiFamilieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proiecteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evenimenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.statusStripNrActivitati = new System.Windows.Forms.StatusStrip();
            this.tssTotalAct = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamilie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitatiFamilieBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStripNrActivitati.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.lbPersoane);
            this.groupBox1.Controls.Add(this.btnAddPers);
            this.groupBox1.Controls.Add(this.dtpData);
            this.groupBox1.Controls.Add(this.labelData);
            this.groupBox1.Controls.Add(this.tbLocatie);
            this.groupBox1.Controls.Add(this.labelLocatie);
            this.groupBox1.Controls.Add(this.tbDenumire);
            this.groupBox1.Controls.Add(this.labelDenumire);
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 418);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalii Activitate in Familie";
            // 
            // lbPersoane
            // 
            this.lbPersoane.FormattingEnabled = true;
            this.lbPersoane.ItemHeight = 16;
            this.lbPersoane.Location = new System.Drawing.Point(19, 263);
            this.lbPersoane.Name = "lbPersoane";
            this.lbPersoane.Size = new System.Drawing.Size(245, 132);
            this.lbPersoane.TabIndex = 32;
            // 
            // btnAddPers
            // 
            this.btnAddPers.BackColor = System.Drawing.SystemColors.Menu;
            this.btnAddPers.Location = new System.Drawing.Point(19, 199);
            this.btnAddPers.Name = "btnAddPers";
            this.btnAddPers.Size = new System.Drawing.Size(245, 41);
            this.btnAddPers.TabIndex = 31;
            this.btnAddPers.Text = "Adauga Persoane";
            this.btnAddPers.UseVisualStyleBackColor = false;
            this.btnAddPers.Click += new System.EventHandler(this.btnAddPers_Click);
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(19, 151);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(245, 22);
            this.dtpData.TabIndex = 25;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(16, 131);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(38, 17);
            this.labelData.TabIndex = 24;
            this.labelData.Text = "Data";
            // 
            // tbLocatie
            // 
            this.tbLocatie.Location = new System.Drawing.Point(19, 101);
            this.tbLocatie.Name = "tbLocatie";
            this.tbLocatie.Size = new System.Drawing.Size(245, 22);
            this.tbLocatie.TabIndex = 23;
            // 
            // labelLocatie
            // 
            this.labelLocatie.AutoSize = true;
            this.labelLocatie.Location = new System.Drawing.Point(20, 81);
            this.labelLocatie.Name = "labelLocatie";
            this.labelLocatie.Size = new System.Drawing.Size(54, 17);
            this.labelLocatie.TabIndex = 22;
            this.labelLocatie.Text = "Locație";
            // 
            // tbDenumire
            // 
            this.tbDenumire.Location = new System.Drawing.Point(19, 56);
            this.tbDenumire.Name = "tbDenumire";
            this.tbDenumire.Size = new System.Drawing.Size(245, 22);
            this.tbDenumire.TabIndex = 21;
            // 
            // labelDenumire
            // 
            this.labelDenumire.AutoSize = true;
            this.labelDenumire.Location = new System.Drawing.Point(20, 36);
            this.labelDenumire.Name = "labelDenumire";
            this.labelDenumire.Size = new System.Drawing.Size(69, 17);
            this.labelDenumire.TabIndex = 20;
            this.labelDenumire.Text = "Denumire";
            // 
            // btnCurata
            // 
            this.btnCurata.BackColor = System.Drawing.SystemColors.Menu;
            this.btnCurata.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurata.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCurata.Location = new System.Drawing.Point(189, 491);
            this.btnCurata.Name = "btnCurata";
            this.btnCurata.Size = new System.Drawing.Size(136, 48);
            this.btnCurata.TabIndex = 25;
            this.btnCurata.Text = "Șterge";
            this.btnCurata.UseVisualStyleBackColor = false;
            this.btnCurata.Click += new System.EventHandler(this.btnCurata_Click);
            // 
            // btnAdauga
            // 
            this.btnAdauga.BackColor = System.Drawing.SystemColors.Menu;
            this.btnAdauga.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdauga.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdauga.Location = new System.Drawing.Point(12, 491);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(136, 48);
            this.btnAdauga.TabIndex = 24;
            this.btnAdauga.Text = "Adaugă/Editeaza ";
            this.btnAdauga.UseVisualStyleBackColor = false;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // dgvFamilie
            // 
            this.dgvFamilie.AutoGenerateColumns = false;
            this.dgvFamilie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFamilie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.denumireDataGridViewTextBoxColumn,
            this.dataActivitateDataGridViewTextBoxColumn,
            this.tipDataGridViewTextBoxColumn,
            this.detaliiDataGridViewTextBoxColumn,
            this.prioritateDataGridViewTextBoxColumn});
            this.dgvFamilie.DataSource = this.activitatiFamilieBindingSource;
            this.dgvFamilie.Location = new System.Drawing.Point(351, 99);
            this.dgvFamilie.Name = "dgvFamilie";
            this.dgvFamilie.RowTemplate.Height = 24;
            this.dgvFamilie.Size = new System.Drawing.Size(702, 436);
            this.dgvFamilie.TabIndex = 27;
            this.dgvFamilie.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvFamilie_MouseDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // denumireDataGridViewTextBoxColumn
            // 
            this.denumireDataGridViewTextBoxColumn.DataPropertyName = "Denumire";
            this.denumireDataGridViewTextBoxColumn.HeaderText = "Denumire";
            this.denumireDataGridViewTextBoxColumn.Name = "denumireDataGridViewTextBoxColumn";
            // 
            // dataActivitateDataGridViewTextBoxColumn
            // 
            this.dataActivitateDataGridViewTextBoxColumn.DataPropertyName = "dataActivitate";
            this.dataActivitateDataGridViewTextBoxColumn.HeaderText = "dataActivitate";
            this.dataActivitateDataGridViewTextBoxColumn.Name = "dataActivitateDataGridViewTextBoxColumn";
            // 
            // tipDataGridViewTextBoxColumn
            // 
            this.tipDataGridViewTextBoxColumn.DataPropertyName = "tip";
            this.tipDataGridViewTextBoxColumn.HeaderText = "tip";
            this.tipDataGridViewTextBoxColumn.Name = "tipDataGridViewTextBoxColumn";
            // 
            // detaliiDataGridViewTextBoxColumn
            // 
            this.detaliiDataGridViewTextBoxColumn.DataPropertyName = "Detalii";
            this.detaliiDataGridViewTextBoxColumn.HeaderText = "Detalii";
            this.detaliiDataGridViewTextBoxColumn.Name = "detaliiDataGridViewTextBoxColumn";
            // 
            // prioritateDataGridViewTextBoxColumn
            // 
            this.prioritateDataGridViewTextBoxColumn.DataPropertyName = "Prioritate";
            this.prioritateDataGridViewTextBoxColumn.HeaderText = "Prioritate";
            this.prioritateDataGridViewTextBoxColumn.Name = "prioritateDataGridViewTextBoxColumn";
            // 
            // activitatiFamilieBindingSource
            // 
            this.activitatiFamilieBindingSource.DataSource = typeof(WindowsForms_Agenda_de_Activitati.Models.ActivitatiFamilie);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(647, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Lista Activitati";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Lavender;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.proiecteToolStripMenuItem,
            this.evenimenteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1083, 28);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // proiecteToolStripMenuItem
            // 
            this.proiecteToolStripMenuItem.Name = "proiecteToolStripMenuItem";
            this.proiecteToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.proiecteToolStripMenuItem.Text = "Proiecte";
            this.proiecteToolStripMenuItem.Click += new System.EventHandler(this.proiecteToolStripMenuItem_Click);
            // 
            // evenimenteToolStripMenuItem
            // 
            this.evenimenteToolStripMenuItem.Name = "evenimenteToolStripMenuItem";
            this.evenimenteToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.evenimenteToolStripMenuItem.Text = "Evenimente";
            this.evenimenteToolStripMenuItem.Click += new System.EventHandler(this.evenimenteToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Lavender;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbPrint,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1083, 27);
            this.toolStrip1.TabIndex = 30;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbPrint
            // 
            this.tsbPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPrint.Image = global::WindowsForms_Agenda_de_Activitati.Properties.Resources.print;
            this.tsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrint.Name = "tsbPrint";
            this.tsbPrint.Size = new System.Drawing.Size(24, 24);
            this.tsbPrint.Text = "Printare";
            this.tsbPrint.Click += new System.EventHandler(this.tsbPrint_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // statusStripNrActivitati
            // 
            this.statusStripNrActivitati.BackColor = System.Drawing.Color.AliceBlue;
            this.statusStripNrActivitati.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripNrActivitati.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssTotalAct});
            this.statusStripNrActivitati.Location = new System.Drawing.Point(0, 557);
            this.statusStripNrActivitati.Name = "statusStripNrActivitati";
            this.statusStripNrActivitati.Size = new System.Drawing.Size(1083, 25);
            this.statusStripNrActivitati.TabIndex = 31;
            this.statusStripNrActivitati.Text = "statusStrip1";
            // 
            // tssTotalAct
            // 
            this.tssTotalAct.Name = "tssTotalAct";
            this.tssTotalAct.Size = new System.Drawing.Size(163, 20);
            this.tssTotalAct.Text = "Total Activitati Familie: ";
            this.tssTotalAct.TextChanged += new System.EventHandler(this.tssTotalAct_TextChanged);
            // 
            // FormFamilie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1083, 582);
            this.Controls.Add(this.statusStripNrActivitati);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFamilie);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCurata);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormFamilie";
            this.Text = "Familie";
            this.Load += new System.EventHandler(this.FormFamilie_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamilie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitatiFamilieBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStripNrActivitati.ResumeLayout(false);
            this.statusStripNrActivitati.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddPers;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.TextBox tbLocatie;
        private System.Windows.Forms.Label labelLocatie;
        private System.Windows.Forms.TextBox tbDenumire;
        private System.Windows.Forms.Label labelDenumire;
        private System.Windows.Forms.Button btnCurata;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.ListBox lbPersoane;
        private System.Windows.Forms.DataGridView dgvFamilie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proiecteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evenimenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataActivitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detaliiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prioritateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource activitatiFamilieBindingSource;
        private System.Windows.Forms.StatusStrip statusStripNrActivitati;
        private System.Windows.Forms.ToolStripStatusLabel tssTotalAct;
    }
}