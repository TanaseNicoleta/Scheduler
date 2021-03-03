namespace WindowsForms_Agenda_de_Activitati
{
    partial class FormStatistics
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
            this.treeView = new System.Windows.Forms.TreeView();
            this.panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.rtTree = new System.Windows.Forms.RichTextBox();
            this.btnPaste = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(396, 43);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(317, 249);
            this.treeView.TabIndex = 0;
            // 
            // panel
            // 
            this.panel.AllowDrop = true;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Location = new System.Drawing.Point(24, 43);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(317, 249);
            this.panel.TabIndex = 3;
            this.panel.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_DragDrop);
            this.panel.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Drag and Drop";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(481, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Evenimente/Activitati";
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.SystemColors.Menu;
            this.btnCopy.Location = new System.Drawing.Point(396, 303);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(107, 43);
            this.btnCopy.TabIndex = 6;
            this.btnCopy.Text = "Copiază";
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // rtTree
            // 
            this.rtTree.Location = new System.Drawing.Point(24, 352);
            this.rtTree.Name = "rtTree";
            this.rtTree.Size = new System.Drawing.Size(689, 221);
            this.rtTree.TabIndex = 7;
            this.rtTree.Text = "";
            // 
            // btnPaste
            // 
            this.btnPaste.BackColor = System.Drawing.SystemColors.Menu;
            this.btnPaste.Location = new System.Drawing.Point(606, 303);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(107, 43);
            this.btnPaste.TabIndex = 8;
            this.btnPaste.Text = "Atașează";
            this.btnPaste.UseVisualStyleBackColor = false;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // FormStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(743, 585);
            this.Controls.Add(this.btnPaste);
            this.Controls.Add(this.rtTree);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.treeView);
            this.MaximizeBox = false;
            this.Name = "FormStatistics";
            this.Text = "Statistics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.RichTextBox rtTree;
        private System.Windows.Forms.Button btnPaste;
    }
}