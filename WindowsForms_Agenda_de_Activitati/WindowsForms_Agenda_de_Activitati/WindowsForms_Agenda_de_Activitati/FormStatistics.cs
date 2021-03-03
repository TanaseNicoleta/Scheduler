using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Agenda_de_Activitati
{
    public partial class FormStatistics : Form
    {
        String richTXT;

        public FormStatistics()
        {
            InitializeComponent();
        }

        private void panel_DragEnter(object sender, DragEventArgs e)
        {

            e.Effect = DragDropEffects.Copy;
        }

        private void panel_DragDrop(object sender, DragEventArgs e)
        {
            string[] filePaths = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            foreach (String path in filePaths)
            {
                string[] content = File.ReadAllLines(path);

                TreeNode root = new TreeNode("Activitati");
                treeView.Nodes.Add(root);

                foreach (String line in content)
                {
                    string[] tokens = line.Split('\t');

                    TreeNode child = new TreeNode(tokens[0]);
                    root.Nodes.Add(child);

                    TreeNode _1grandchild = new TreeNode(tokens[1]);
                    TreeNode _2grandchild = new TreeNode(tokens[2]);
                    TreeNode _3grandchild = new TreeNode(tokens[3]);

                    child.Nodes.Add(_1grandchild);
                    child.Nodes.Add(_2grandchild);
                    child.Nodes.Add(_3grandchild);
                }

                treeView.ExpandAll();
            }
        }


   
        private void btnCopy_Click(object sender, EventArgs e)
        {
            TreeNode root = treeView.TopNode;
            richTXT += root.Text + "\r\n";
            foreach(TreeNode nod in root.Nodes)
            {
                
                richTXT += nod.Text + "\r\n";
                Clipboard.SetText(richTXT);
                
            }

        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            rtTree.Text = Clipboard.GetText();
        }
    }
}
