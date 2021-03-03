using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms_Agenda_de_Activitati.Models;

namespace WindowsForms_Agenda_de_Activitati
{
    public partial class FormFamilie : Form
    {
        EF_ApplicationContext ctx = new EF_ApplicationContext();
        List<Persoane> persoaneParticipante = new List<Persoane>();

        public FormFamilie()
        {
            InitializeComponent();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            if (dgvFamilie.SelectedRows.Count != 0 && activitatiFamilieBindingSource.Current as ActivitatiFamilie != null)
            {
                ActivitatiFamilie af = activitatiFamilieBindingSource.Current as ActivitatiFamilie;

                af.Denumire = tbDenumire.Text;
                af.SetLocatie(tbLocatie.Text);
                DateTime.TryParse(dtpData.Value.ToString(), out DateTime data);
                af.dataActivitate = data;

                
                ctx.familie.Update(af);
            }
            else
            {

                ctx.familie.Add(new ActivitatiFamilie(tbDenumire.Text, tbLocatie.Text, dtpData.Value)
                );
                tssTotalAct_TextChanged(sender, e);
            }


            ctx.SaveChanges();
            activitatiFamilieBindingSource.DataSource = ctx.familie.ToList();
        }

        private void btnCurata_Click(object sender, EventArgs e)
        {
            if (dgvFamilie.SelectedRows.Count != 0)
            {
                if (MessageBox.Show("Doresti sa stergi intrarea?", "Stergere",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (dgvFamilie.SelectedRows.Count != 0)
                    {
                        if (MessageBox.Show("Doresti sa stergi intrarea?", "Stergere",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            ctx.familie.Remove(activitatiFamilieBindingSource.Current as ActivitatiFamilie);
                            ctx.SaveChanges();
                            tssTotalAct_TextChanged(sender, e);
                            activitatiFamilieBindingSource.DataSource = ctx.familie.ToList();
                        }
                    }

                }
            }
        }

        private void btnAddPers_Click(object sender, EventArgs e)
        {
            FormAdaugaPersoana add = new FormAdaugaPersoana(persoaneParticipante);
            if(add.ShowDialog()==DialogResult.OK)
            {
                lbPersoane.Items.Clear();
                String[] nume = new string[persoaneParticipante.Count];
                int index = 0;

                foreach(Persoane p in persoaneParticipante)
                {
                    lbPersoane.Items.Add(p.nume);
                    nume[index] = p.nume;
                    index++;
                }

                lbPersoane.DataSource = nume;
            }
;
            

        }

        #region navigare intre formulare
        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFamilie fam = new FormFamilie();
            fam.Show();
        }

        private void proiecteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agenda agendaProiecte = new Agenda();
            agendaProiecte.Show();
        }

        private void evenimenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListareEvenimenteBD eveniment = new FormListareEvenimenteBD();
            eveniment.Show();
        }





        #endregion

       
        private void dgvFamilie_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ActivitatiFamilie activitate = activitatiFamilieBindingSource.Current as ActivitatiFamilie;
            FormAdaugaPersoana add = new FormAdaugaPersoana(activitate.persoane);
            add.Show();
        }


        #region printare
        private void tsbPrint_Click(object sender, EventArgs e)
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

            int height = dgvFamilie.Height;
            dgvFamilie.Height = dgvFamilie.RowCount * dgvFamilie.RowTemplate.Height * 2;
            Bitmap bmp = new Bitmap(dgvFamilie.Width, dgvFamilie.Height);
            dgvFamilie.DrawToBitmap(bmp, new Rectangle(0, 0, dgvFamilie.Width, dgvFamilie.Height));
            dgvFamilie.Height = height;
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        #endregion

        private void tssTotalAct_TextChanged(object sender, EventArgs e)
        {
            tssTotalAct.Text = "Total activitati familie: " + (dgvFamilie.Rows.Count-1).ToString();
        }

        private void FormFamilie_Load(object sender, EventArgs e)
        {
            tssTotalAct_TextChanged(sender, e);
        }
    }
}


