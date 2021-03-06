﻿namespace WindowsForms_Agenda_de_Activitati
{
    partial class Agenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agenda));
            this.lvAgenda = new System.Windows.Forms.ListView();
            this.chDomeniu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chActivitate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTitlu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPrioritate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelLista = new System.Windows.Forms.Label();
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
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsEditeaza = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSterge = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.epDomenii = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSterge = new System.Windows.Forms.Button();
            this.btnEditare = new System.Windows.Forms.Button();
            this.btnCurata = new System.Windows.Forms.Button();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.ltsEditare = new System.Windows.Forms.ToolStripMenuItem();
            this.ltsDetalii = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSalveaza = new System.Windows.Forms.ToolStripMenuItem();
            this.ltsSaveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.fisierBinarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fisierTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fisierXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.ltsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.ltsDeleteAll = new System.Windows.Forms.ToolStripMenuItem();
            this.importDinFisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navigareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evenimenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.familieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripNrActivitati = new System.Windows.Forms.StatusStrip();
            this.tssTotalAct = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tspStats = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.groupBox1.SuspendLayout();
            this.cms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epDomenii)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStripNrActivitati.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvAgenda
            // 
            this.lvAgenda.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chDomeniu,
            this.chActivitate,
            this.chTitlu,
            this.chPrioritate});
            this.lvAgenda.FullRowSelect = true;
            this.lvAgenda.HideSelection = false;
            this.lvAgenda.Location = new System.Drawing.Point(376, 89);
            this.lvAgenda.Name = "lvAgenda";
            this.lvAgenda.Size = new System.Drawing.Size(696, 389);
            this.lvAgenda.TabIndex = 18;
            this.lvAgenda.UseCompatibleStateImageBehavior = false;
            this.lvAgenda.View = System.Windows.Forms.View.Details;
            this.lvAgenda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvAgenda_KeyDown);
            this.lvAgenda.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvAgenda_MouseClick);
            this.lvAgenda.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvAgenda_MouseDoubleClick);
            // 
            // chDomeniu
            // 
            this.chDomeniu.Text = "Domeniu";
            this.chDomeniu.Width = 93;
            // 
            // chActivitate
            // 
            this.chActivitate.Text = "Activitate";
            this.chActivitate.Width = 120;
            // 
            // chTitlu
            // 
            this.chTitlu.Text = "Titlu";
            this.chTitlu.Width = 99;
            // 
            // chPrioritate
            // 
            this.chPrioritate.Text = "Prioritate";
            this.chPrioritate.Width = 79;
            // 
            // labelLista
            // 
            this.labelLista.AutoSize = true;
            this.labelLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLista.Location = new System.Drawing.Point(660, 66);
            this.labelLista.Name = "labelLista";
            this.labelLista.Size = new System.Drawing.Size(115, 20);
            this.labelLista.TabIndex = 19;
            this.labelLista.Text = "Listă Activități";
            this.labelLista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.groupBox1.Location = new System.Drawing.Point(6, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 403);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalii Activitate";
            // 
            // tbProgres
            // 
            this.tbProgres.Location = new System.Drawing.Point(19, 360);
            this.tbProgres.Name = "tbProgres";
            this.tbProgres.Size = new System.Drawing.Size(245, 22);
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
            this.cbPrioritate.Size = new System.Drawing.Size(245, 24);
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
            this.dtpIncheiere.Size = new System.Drawing.Size(245, 22);
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
            this.dtpInceput.Size = new System.Drawing.Size(245, 22);
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
            this.tbLocatie.Size = new System.Drawing.Size(245, 22);
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
            this.tbTitlu.Size = new System.Drawing.Size(245, 22);
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
            this.cbTip.Size = new System.Drawing.Size(245, 24);
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
            this.labelDomeniu.Location = new System.Drawing.Point(17, 19);
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
            this.cbDomenii.Size = new System.Drawing.Size(245, 24);
            this.cbDomenii.TabIndex = 16;
            this.cbDomenii.Validating += new System.ComponentModel.CancelEventHandler(this.cbDomenii_Validating);
            this.cbDomenii.Validated += new System.EventHandler(this.cbDomenii_Validated);
            // 
            // cms
            // 
            this.cms.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsEditeaza,
            this.cmsSterge,
            this.cmsAdd});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(179, 76);
            // 
            // cmsEditeaza
            // 
            this.cmsEditeaza.Name = "cmsEditeaza";
            this.cmsEditeaza.Size = new System.Drawing.Size(178, 24);
            this.cmsEditeaza.Text = "Editeaza";
            this.cmsEditeaza.Click += new System.EventHandler(this.cmsEditeaza_Click);
            // 
            // cmsSterge
            // 
            this.cmsSterge.Name = "cmsSterge";
            this.cmsSterge.Size = new System.Drawing.Size(178, 24);
            this.cmsSterge.Text = "Sterge";
            this.cmsSterge.Click += new System.EventHandler(this.cmsSterge_Click);
            // 
            // cmsAdd
            // 
            this.cmsAdd.Name = "cmsAdd";
            this.cmsAdd.Size = new System.Drawing.Size(178, 24);
            this.cmsAdd.Text = "Adaugă Detalii";
            this.cmsAdd.Click += new System.EventHandler(this.cmsAdd_Click);
            // 
            // epDomenii
            // 
            this.epDomenii.ContainerControl = this;
            // 
            // btnSterge
            // 
            this.btnSterge.BackColor = System.Drawing.SystemColors.Menu;
            this.btnSterge.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSterge.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSterge.Location = new System.Drawing.Point(927, 490);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(145, 48);
            this.btnSterge.TabIndex = 22;
            this.btnSterge.Text = "Șterge Activitate";
            this.btnSterge.UseVisualStyleBackColor = false;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // btnEditare
            // 
            this.btnEditare.BackColor = System.Drawing.SystemColors.Menu;
            this.btnEditare.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditare.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditare.Location = new System.Drawing.Point(739, 490);
            this.btnEditare.Name = "btnEditare";
            this.btnEditare.Size = new System.Drawing.Size(145, 48);
            this.btnEditare.TabIndex = 21;
            this.btnEditare.Text = "Editează Activitate";
            this.btnEditare.UseVisualStyleBackColor = false;
            this.btnEditare.Click += new System.EventHandler(this.btnEditare_Click);
            // 
            // btnCurata
            // 
            this.btnCurata.BackColor = System.Drawing.SystemColors.Menu;
            this.btnCurata.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurata.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCurata.Location = new System.Drawing.Point(203, 490);
            this.btnCurata.Name = "btnCurata";
            this.btnCurata.Size = new System.Drawing.Size(116, 48);
            this.btnCurata.TabIndex = 17;
            this.btnCurata.Text = "Curăță Formular";
            this.btnCurata.UseVisualStyleBackColor = false;
            this.btnCurata.Click += new System.EventHandler(this.btnCurata_Click);
            // 
            // btnAdauga
            // 
            this.btnAdauga.BackColor = System.Drawing.SystemColors.Menu;
            this.btnAdauga.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdauga.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdauga.Location = new System.Drawing.Point(12, 490);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(116, 48);
            this.btnAdauga.TabIndex = 16;
            this.btnAdauga.Text = "Adaugă Activitate";
            this.btnAdauga.UseVisualStyleBackColor = false;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Lavender;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFile,
            this.tsmSalveaza,
            this.tsmDelete,
            this.importDinFisierToolStripMenuItem,
            this.navigareToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1106, 28);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmFile
            // 
            this.tsmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmOpen,
            this.tsmAdd});
            this.tsmFile.Name = "tsmFile";
            this.tsmFile.Size = new System.Drawing.Size(63, 24);
            this.tsmFile.Text = "Fisiere";
            // 
            // tsmOpen
            // 
            this.tsmOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ltsEditare,
            this.ltsDetalii});
            this.tsmOpen.Name = "tsmOpen";
            this.tsmOpen.Size = new System.Drawing.Size(265, 26);
            this.tsmOpen.Text = "Deschide";
            // 
            // ltsEditare
            // 
            this.ltsEditare.Name = "ltsEditare";
            this.ltsEditare.Size = new System.Drawing.Size(131, 26);
            this.ltsEditare.Text = "Editare";
            this.ltsEditare.Click += new System.EventHandler(this.editareToolStripMenuItem_Click);
            // 
            // ltsDetalii
            // 
            this.ltsDetalii.Name = "ltsDetalii";
            this.ltsDetalii.Size = new System.Drawing.Size(131, 26);
            this.ltsDetalii.Text = "Detalii";
            this.ltsDetalii.Click += new System.EventHandler(this.detaliiToolStripMenuItem_Click);
            // 
            // tsmAdd
            // 
            this.tsmAdd.Name = "tsmAdd";
            this.tsmAdd.Size = new System.Drawing.Size(265, 26);
            this.tsmAdd.Text = "Adauga o noua inregistrare";
            this.tsmAdd.Click += new System.EventHandler(this.adaugaONouaInregistrareToolStripMenuItem_Click);
            // 
            // tsmSalveaza
            // 
            this.tsmSalveaza.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ltsSaveAll});
            this.tsmSalveaza.Name = "tsmSalveaza";
            this.tsmSalveaza.Size = new System.Drawing.Size(79, 24);
            this.tsmSalveaza.Text = "Salveaza";
            // 
            // ltsSaveAll
            // 
            this.ltsSaveAll.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisierBinarToolStripMenuItem,
            this.fisierTextToolStripMenuItem,
            this.fisierXMLToolStripMenuItem});
            this.ltsSaveAll.Name = "ltsSaveAll";
            this.ltsSaveAll.Size = new System.Drawing.Size(165, 26);
            this.ltsSaveAll.Text = "Salveaza tot";
            // 
            // fisierBinarToolStripMenuItem
            // 
            this.fisierBinarToolStripMenuItem.Name = "fisierBinarToolStripMenuItem";
            this.fisierBinarToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.fisierBinarToolStripMenuItem.Text = "Fisier binar";
            this.fisierBinarToolStripMenuItem.Click += new System.EventHandler(this.fisierBinarToolStripMenuItem_Click);
            // 
            // fisierTextToolStripMenuItem
            // 
            this.fisierTextToolStripMenuItem.Name = "fisierTextToolStripMenuItem";
            this.fisierTextToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.fisierTextToolStripMenuItem.Text = "Fisier text";
            this.fisierTextToolStripMenuItem.Click += new System.EventHandler(this.fisierTextToolStripMenuItem_Click);
            // 
            // fisierXMLToolStripMenuItem
            // 
            this.fisierXMLToolStripMenuItem.Name = "fisierXMLToolStripMenuItem";
            this.fisierXMLToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.fisierXMLToolStripMenuItem.Text = "Fisier XML";
            this.fisierXMLToolStripMenuItem.Click += new System.EventHandler(this.fisierXMLToolStripMenuItem_Click);
            // 
            // tsmDelete
            // 
            this.tsmDelete.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ltsDelete,
            this.ltsDeleteAll});
            this.tsmDelete.Name = "tsmDelete";
            this.tsmDelete.Size = new System.Drawing.Size(64, 24);
            this.tsmDelete.Text = "Sterge";
            // 
            // ltsDelete
            // 
            this.ltsDelete.Name = "ltsDelete";
            this.ltsDelete.Size = new System.Drawing.Size(223, 26);
            this.ltsDelete.Text = "Sterge camp selectat";
            this.ltsDelete.Click += new System.EventHandler(this.ltsDelete_Click);
            // 
            // ltsDeleteAll
            // 
            this.ltsDeleteAll.Name = "ltsDeleteAll";
            this.ltsDeleteAll.Size = new System.Drawing.Size(223, 26);
            this.ltsDeleteAll.Text = "Sterge toata lista";
            this.ltsDeleteAll.Click += new System.EventHandler(this.ltsDeleteAll_Click);
            // 
            // importDinFisierToolStripMenuItem
            // 
            this.importDinFisierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binarToolStripMenuItem,
            this.textToolStripMenuItem,
            this.xMLToolStripMenuItem});
            this.importDinFisierToolStripMenuItem.Name = "importDinFisierToolStripMenuItem";
            this.importDinFisierToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.importDinFisierToolStripMenuItem.Text = "Import din fisier";
            // 
            // binarToolStripMenuItem
            // 
            this.binarToolStripMenuItem.Name = "binarToolStripMenuItem";
            this.binarToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.binarToolStripMenuItem.Text = "Binar";
            this.binarToolStripMenuItem.Click += new System.EventHandler(this.binarToolStripMenuItem_Click);
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.textToolStripMenuItem.Text = "Text";
            this.textToolStripMenuItem.Click += new System.EventHandler(this.textToolStripMenuItem_Click);
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.xMLToolStripMenuItem.Text = "XML";
            this.xMLToolStripMenuItem.Click += new System.EventHandler(this.xMLToolStripMenuItem_Click);
            // 
            // navigareToolStripMenuItem
            // 
            this.navigareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.evenimenteToolStripMenuItem,
            this.familieToolStripMenuItem});
            this.navigareToolStripMenuItem.Name = "navigareToolStripMenuItem";
            this.navigareToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.navigareToolStripMenuItem.Text = "Navigare";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // evenimenteToolStripMenuItem
            // 
            this.evenimenteToolStripMenuItem.Name = "evenimenteToolStripMenuItem";
            this.evenimenteToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.evenimenteToolStripMenuItem.Text = "Evenimente";
            this.evenimenteToolStripMenuItem.Click += new System.EventHandler(this.evenimenteToolStripMenuItem_Click);
            // 
            // familieToolStripMenuItem
            // 
            this.familieToolStripMenuItem.Name = "familieToolStripMenuItem";
            this.familieToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.familieToolStripMenuItem.Text = "Familie";
            this.familieToolStripMenuItem.Click += new System.EventHandler(this.familieToolStripMenuItem_Click);
            // 
            // statusStripNrActivitati
            // 
            this.statusStripNrActivitati.BackColor = System.Drawing.Color.AliceBlue;
            this.statusStripNrActivitati.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripNrActivitati.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssTotalAct});
            this.statusStripNrActivitati.Location = new System.Drawing.Point(0, 541);
            this.statusStripNrActivitati.Name = "statusStripNrActivitati";
            this.statusStripNrActivitati.Size = new System.Drawing.Size(1106, 25);
            this.statusStripNrActivitati.TabIndex = 24;
            this.statusStripNrActivitati.Text = "statusStrip1";
            // 
            // tssTotalAct
            // 
            this.tssTotalAct.Name = "tssTotalAct";
            this.tssTotalAct.Size = new System.Drawing.Size(112, 20);
            this.tssTotalAct.Text = "Total Activitati: ";
            this.tssTotalAct.TextChanged += new System.EventHandler(this.tssTotalAct_TextChanged);
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.Lavender;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbPrint,
            this.toolStripSeparator1,
            this.tspStats,
            this.toolStripSeparator2});
            this.toolStrip.Location = new System.Drawing.Point(0, 28);
            this.toolStrip.Margin = new System.Windows.Forms.Padding(5);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1106, 27);
            this.toolStrip.TabIndex = 25;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tsbPrint
            // 
            this.tsbPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPrint.Image = global::WindowsForms_Agenda_de_Activitati.Properties.Resources.print;
            this.tsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrint.Name = "tsbPrint";
            this.tsbPrint.Size = new System.Drawing.Size(24, 24);
            this.tsbPrint.Text = "toolStripButton1";
            this.tsbPrint.Click += new System.EventHandler(this.tsbPrint_Click);
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
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1106, 566);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusStripNrActivitati);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnEditare);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelLista);
            this.Controls.Add(this.lvAgenda);
            this.Controls.Add(this.btnCurata);
            this.Controls.Add(this.btnAdauga);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Agenda";
            this.Text = "Agenda";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.cms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epDomenii)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStripNrActivitati.ResumeLayout(false);
            this.statusStripNrActivitati.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnCurata;
        private System.Windows.Forms.ListView lvAgenda;
        private System.Windows.Forms.ColumnHeader chDomeniu;
        private System.Windows.Forms.ColumnHeader chActivitate;
        private System.Windows.Forms.ColumnHeader chTitlu;
        private System.Windows.Forms.ColumnHeader chPrioritate;
        private System.Windows.Forms.Label labelLista;
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
        private System.Windows.Forms.Button btnEditare;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem cmsEditeaza;
        private System.Windows.Forms.ToolStripMenuItem cmsSterge;
        private System.Windows.Forms.ErrorProvider epDomenii;
        private System.Windows.Forms.ToolStripMenuItem cmsAdd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmFile;
        private System.Windows.Forms.ToolStripMenuItem tsmOpen;
        private System.Windows.Forms.ToolStripMenuItem ltsEditare;
        private System.Windows.Forms.ToolStripMenuItem ltsDetalii;
        private System.Windows.Forms.ToolStripMenuItem tsmSalveaza;
        private System.Windows.Forms.ToolStripMenuItem ltsSaveAll;
        private System.Windows.Forms.ToolStripMenuItem tsmDelete;
        private System.Windows.Forms.ToolStripMenuItem ltsDelete;
        private System.Windows.Forms.ToolStripMenuItem ltsDeleteAll;
        private System.Windows.Forms.ToolStripMenuItem tsmAdd;
        private System.Windows.Forms.ToolStripMenuItem fisierBinarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fisierTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fisierXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importDinFisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStripNrActivitati;
        private System.Windows.Forms.ToolStripStatusLabel tssTotalAct;
        private System.Windows.Forms.ToolStripButton tsbPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem navigareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evenimenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem familieToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        private System.Windows.Forms.ToolStripButton tspStats;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

