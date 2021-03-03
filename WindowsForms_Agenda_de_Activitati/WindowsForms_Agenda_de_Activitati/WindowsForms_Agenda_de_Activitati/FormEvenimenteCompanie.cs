using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms_Agenda_de_Activitati.Models;

namespace WindowsForms_Agenda_de_Activitati
{
    public partial class FormListareEvenimenteBD : Form
    {

        EF_ApplicationContext ctx = new EF_ApplicationContext();
        List<EvenimentFirma> evenimente = new List<EvenimentFirma>();

        public FormListareEvenimenteBD()
        {
            InitializeComponent();
            
        }

        private void FormListareEvenimenteBD_Load(object sender, EventArgs e)
        {
            evenimentFirmaBindingSource.DataSource = ctx.evenimente.ToList();
            tssTotalAct_TextChanged(sender,  e);
        }

        #region butoane
        private void btnAdauga_Click(object sender, EventArgs e)
        {
            if (dgvEvenimente.SelectedRows.Count != 0 && evenimentFirmaBindingSource.Current as EvenimentFirma != null)
            {
                EvenimentFirma ef = evenimentFirmaBindingSource.Current as EvenimentFirma;

                ef.Denumire = tbDenumire.Text;
                ef.SetLocatie(tbLocatie.Text);
                DateTime.TryParse(dtpData.Value.ToString(), out DateTime data);
                ef.dataEveniment = data;

                ef.Prioritate = cbPrioritate.Text;
                ctx.evenimente.Update(ef);
            }
            else
            {
                
                ctx.evenimente.Add(new EvenimentFirma(tbDenumire.Text, tbLocatie.Text, dtpData.Value));
                evenimente.Add(new EvenimentFirma(tbDenumire.Text, tbLocatie.Text, dtpData.Value));
            }

            tssTotalAct_TextChanged(sender, e);
            ctx.SaveChanges();
            evenimentFirmaBindingSource.DataSource = ctx.evenimente.ToList();
        }

        private void btnCurata_Click(object sender, EventArgs e)
        {
            if (dgvEvenimente.SelectedRows.Count != 0)
            {
                if (MessageBox.Show("Doresti sa stergi intrarea?", "Stergere",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (dgvEvenimente.SelectedRows.Count != 0)
                    {
                        if (MessageBox.Show("Doresti sa stergi intrarea?", "Stergere",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            ctx.evenimente.Remove(evenimentFirmaBindingSource.Current as EvenimentFirma);
                            ctx.SaveChanges();

                            evenimentFirmaBindingSource.DataSource = ctx.evenimente.ToList();
                        }
                    }
                    tssTotalAct_TextChanged(sender, e);
                }
            }
        }

        private void btnDetalii_Click(object sender, EventArgs e)
        {
            EvenimentFirma eveniment = new EvenimentFirma(tbDenumire.Text, tbLocatie.Text, dtpData.Value);
            FormDetalii form = new FormDetalii(eveniment);
            form.ShowDialog();
        }
        #endregion

        #region navigare intre formulare
        private void proiecteToolStripMenuItem_Click(object sender, EventArgs e) //item start
        {
            FormStart start = new FormStart();
            start.Show();
        }

        private void proiecteToolStripMenuItem1_Click(object sender, EventArgs e)   //item proiecte
        {
            Agenda agendaProiecte = new Agenda();
            agendaProiecte.Show();
        }

        private void familieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFamilie fam = new FormFamilie();
            fam.Show();
        }
        #endregion


        #region printare
        private void btnPrint_Click(object sender, EventArgs e)
        {
            pageSetupDialog.Document = printDocument;
            pageSetupDialog.PageSettings = printDocument.DefaultPageSettings;

            if (pageSetupDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.DefaultPageSettings = pageSetupDialog.PageSettings;
                printPreviewDialog.Document = printDocument;
                printPreviewDialog.ShowDialog();
            }

        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

             
            int height = dgvEvenimente.Height;
            dgvEvenimente.Height = dgvEvenimente.RowCount * dgvEvenimente.RowTemplate.Height * 2;
            Bitmap bmp = new Bitmap(dgvEvenimente.Width, dgvEvenimente.Height);
            dgvEvenimente.DrawToBitmap(bmp, new Rectangle(0, 0, dgvEvenimente.Width, dgvEvenimente.Height));
            dgvEvenimente.Height = height;
            e.Graphics.DrawImage(bmp, 0, 0);



        }

        #endregion

        private void tspStats_Click(object sender, EventArgs e)
        {
            FormStatistics form = new FormStatistics();
                form.Show();
        }

      

        private void tssTotalAct_TextChanged(object sender, EventArgs e)
        {
            tssTotalAct.Text = "Total evenimente: " + (dgvEvenimente.Rows.Count-1).ToString();
        }
    }
}

