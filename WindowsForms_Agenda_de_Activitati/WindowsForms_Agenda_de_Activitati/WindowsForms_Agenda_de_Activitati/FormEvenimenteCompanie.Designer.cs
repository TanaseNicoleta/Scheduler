namespace WindowsForms_Agenda_de_Activitati
{
    partial class FormListareEvenimenteBD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListareEvenimenteBD));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDetalii = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPrioritate = new System.Windows.Forms.ComboBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.labelData = new System.Windows.Forms.Label();
            this.tbLocatie = new System.Windows.Forms.TextBox();
            this.labelLocatie = new System.Windows.Forms.Label();
            this.tbDenumire = new System.Windows.Forms.TextBox();
            this.labelDenumire = new System.Windows.Forms.Label();
            this.btnCurata = new System.Windows.Forms.Button();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.labelLista = new System.Windows.Forms.Label();
            this.dgvEvenimente = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denumireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEvenimentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detaliiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prioritateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evenimentFirmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.proiecteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proiecteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.familieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPrint = new System.Windows.Forms.ToolStrip();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tspStats = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.statusStripNrActivitati = new System.Windows.Forms.StatusStrip();
            this.tssTotalAct = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvenimente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evenimentFirmaBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tsPrint.SuspendLayout();
            this.statusStripNrActivitati.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.btnDetalii);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbPrioritate);
            this.groupBox1.Controls.Add(this.dtpData);
            this.groupBox1.Controls.Add(this.labelData);
            this.groupBox1.Controls.Add(this.tbLocatie);
            this.groupBox1.Controls.Add(this.labelLocatie);
            this.groupBox1.Controls.Add(this.tbDenumire);
            this.groupBox1.Controls.Add(this.labelDenumire);
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 332);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalii Eveniment";
            // 
            // btnDetalii
            // 
            this.btnDetalii.BackColor = System.Drawing.SystemColors.Menu;
            this.btnDetalii.Location = new System.Drawing.Point(19, 256);
            this.btnDetalii.Name = "btnDetalii";
            this.btnDetalii.Size = new System.Drawing.Size(245, 48);
            this.btnDetalii.TabIndex = 31;
            this.btnDetalii.Text = "Adauga Detalii";
            this.btnDetalii.UseVisualStyleBackColor = false;
            this.btnDetalii.Click += new System.EventHandler(this.btnDetalii_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Prioritate";
            // 
            // cbPrioritate
            // 
            this.cbPrioritate.FormattingEnabled = true;
            this.cbPrioritate.Items.AddRange(new object[] {
            "LOW",
            "MEDIUM",
            "HIGH"});
            this.cbPrioritate.Location = new System.Drawing.Point(19, 200);
            this.cbPrioritate.Name = "cbPrioritate";
            this.cbPrioritate.Size = new System.Drawing.Size(245, 24);
            this.cbPrioritate.TabIndex = 29;
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
            this.btnCurata.Location = new System.Drawing.Point(189, 432);
            this.btnCurata.Name = "btnCurata";
            this.btnCurata.Size = new System.Drawing.Size(136, 48);
            this.btnCurata.TabIndex = 22;
            this.btnCurata.Text = "Șterge";
            this.btnCurata.UseVisualStyleBackColor = false;
            this.btnCurata.Click += new System.EventHandler(this.btnCurata_Click);
            // 
            // btnAdauga
            // 
            this.btnAdauga.BackColor = System.Drawing.SystemColors.Menu;
            this.btnAdauga.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdauga.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdauga.Location = new System.Drawing.Point(12, 432);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(136, 48);
            this.btnAdauga.TabIndex = 21;
            this.btnAdauga.Text = "Adaugă/Editeaza ";
            this.btnAdauga.UseVisualStyleBackColor = false;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // labelLista
            // 
            this.labelLista.AutoSize = true;
            this.labelLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLista.Location = new System.Drawing.Point(697, 75);
            this.labelLista.Name = "labelLista";
            this.labelLista.Size = new System.Drawing.Size(96, 20);
            this.labelLista.TabIndex = 24;
            this.labelLista.Text = "Evenimente";
            this.labelLista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvEvenimente
            // 
            this.dgvEvenimente.AutoGenerateColumns = false;
            this.dgvEvenimente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvenimente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.denumireDataGridViewTextBoxColumn,
            this.dataEvenimentDataGridViewTextBoxColumn,
            this.tipDataGridViewTextBoxColumn,
            this.detaliiDataGridViewTextBoxColumn,
            this.prioritateDataGridViewTextBoxColumn});
            this.dgvEvenimente.DataSource = this.evenimentFirmaBindingSource;
            this.dgvEvenimente.Location = new System.Drawing.Point(371, 98);
            this.dgvEvenimente.Name = "dgvEvenimente";
            this.dgvEvenimente.RowTemplate.Height = 24;
            this.dgvEvenimente.Size = new System.Drawing.Size(726, 382);
            this.dgvEvenimente.TabIndex = 25;
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
            // dataEvenimentDataGridViewTextBoxColumn
            // 
            this.dataEvenimentDataGridViewTextBoxColumn.DataPropertyName = "dataEveniment";
            this.dataEvenimentDataGridViewTextBoxColumn.HeaderText = "dataEveniment";
            this.dataEvenimentDataGridViewTextBoxColumn.Name = "dataEvenimentDataGridViewTextBoxColumn";
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
            // evenimentFirmaBindingSource
            // 
            this.evenimentFirmaBindingSource.DataSource = typeof(WindowsForms_Agenda_de_Activitati.Models.EvenimentFirma);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Lavender;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proiecteToolStripMenuItem,
            this.proiecteToolStripMenuItem1,
            this.familieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1138, 28);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // proiecteToolStripMenuItem
            // 
            this.proiecteToolStripMenuItem.Name = "proiecteToolStripMenuItem";
            this.proiecteToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.proiecteToolStripMenuItem.Text = "Start";
            this.proiecteToolStripMenuItem.Click += new System.EventHandler(this.proiecteToolStripMenuItem_Click);
            // 
            // proiecteToolStripMenuItem1
            // 
            this.proiecteToolStripMenuItem1.Name = "proiecteToolStripMenuItem1";
            this.proiecteToolStripMenuItem1.Size = new System.Drawing.Size(75, 24);
            this.proiecteToolStripMenuItem1.Text = "Proiecte";
            this.proiecteToolStripMenuItem1.Click += new System.EventHandler(this.proiecteToolStripMenuItem1_Click);
            // 
            // familieToolStripMenuItem
            // 
            this.familieToolStripMenuItem.Name = "familieToolStripMenuItem";
            this.familieToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.familieToolStripMenuItem.Text = "Familie";
            this.familieToolStripMenuItem.Click += new System.EventHandler(this.familieToolStripMenuItem_Click);
            // 
            // tsPrint
            // 
            this.tsPrint.BackColor = System.Drawing.Color.Lavender;
            this.tsPrint.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsPrint.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPrint,
            this.toolStripSeparator1,
            this.tspStats,
            this.toolStripSeparator2});
            this.tsPrint.Location = new System.Drawing.Point(0, 28);
            this.tsPrint.Name = "tsPrint";
            this.tsPrint.Size = new System.Drawing.Size(1138, 27);
            this.tsPrint.TabIndex = 27;
            this.tsPrint.Text = "Printare";
            // 
            // btnPrint
            // 
            this.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrint.Image = global::WindowsForms_Agenda_de_Activitati.Properties.Resources.print;
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(24, 24);
            this.btnPrint.Text = "toolStripButton1";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tspStats
            // 
            this.tspStats.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tspStats.Image = global::WindowsForms_Agenda_de_Activitati.Properties.Resources.stats;
            this.tspStats.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspStats.Name = "tspStats";
            this.tspStats.Size = new System.Drawing.Size(24, 24);
            this.tspStats.Text = "toolStripButton1";
            this.tspStats.Click += new System.EventHandler(this.tspStats_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
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
            this.statusStripNrActivitati.Location = new System.Drawing.Point(0, 503);
            this.statusStripNrActivitati.Name = "statusStripNrActivitati";
            this.statusStripNrActivitati.Size = new System.Drawing.Size(1138, 25);
            this.statusStripNrActivitati.TabIndex = 28;
            this.statusStripNrActivitati.Text = "statusStrip1";
            // 
            // tssTotalAct
            // 
            this.tssTotalAct.Name = "tssTotalAct";
            this.tssTotalAct.Size = new System.Drawing.Size(130, 20);
            this.tssTotalAct.Text = "Total Evenimente: ";
            this.tssTotalAct.TextChanged += new System.EventHandler(this.tssTotalAct_TextChanged);
            // 
            // FormListareEvenimenteBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1138, 528);
            this.Controls.Add(this.statusStripNrActivitati);
            this.Controls.Add(this.tsPrint);
            this.Controls.Add(this.dgvEvenimente);
            this.Controls.Add(this.labelLista);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCurata);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormListareEvenimenteBD";
            this.Text = "Listare Evenimente";
            this.Load += new System.EventHandler(this.FormListareEvenimenteBD_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvenimente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evenimentFirmaBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tsPrint.ResumeLayout(false);
            this.tsPrint.PerformLayout();
            this.statusStripNrActivitati.ResumeLayout(false);
            this.statusStripNrActivitati.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbPrioritate;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.TextBox tbLocatie;
        private System.Windows.Forms.Label labelLocatie;
        private System.Windows.Forms.TextBox tbDenumire;
        private System.Windows.Forms.Label labelDenumire;
        private System.Windows.Forms.Button btnCurata;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Label labelLista;
        private System.Windows.Forms.DataGridView dgvEvenimente;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEvenimentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detaliiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prioritateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource evenimentFirmaBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDetalii;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem proiecteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proiecteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem familieToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tsPrint;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        private System.Windows.Forms.ToolStripButton tspStats;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.StatusStrip statusStripNrActivitati;
        private System.Windows.Forms.ToolStripStatusLabel tssTotalAct;
    }
}