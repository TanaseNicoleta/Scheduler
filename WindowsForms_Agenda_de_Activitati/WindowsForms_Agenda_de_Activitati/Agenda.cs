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
    
     public partial class Agenda : Form
    {
        List<Proiecte> lista = new List<Proiecte>();
        public Agenda()
        {
            InitializeComponent();
        }

        //
        //Buton adaugare activitate in lista
        //
        private void btnAdauga_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            String Denumire = cbDomenii.Text;
            if(String.IsNullOrEmpty(Denumire))
            {
                isValid = false;
            }
            String Activitate = cbTip.Text;
            String Titlu = tbTitlu.Text;
            if (isValid && (string.IsNullOrWhiteSpace(Titlu) || Titlu.Length < 3))
            {
                isValid = false;
            }
            String Locatie = tbLocatie.Text;
            if(isValid && String.IsNullOrWhiteSpace(Locatie) || Locatie.Length < 3)
            {
                isValid = false;
            }
            DateTime Incepere = dtpInceput.Value;
            DateTime Incheiere = dtpIncheiere.Value;
            if(isValid && DateTime.Compare(Incepere, Incheiere) > 0)
            {
                isValid = false;
            }
            String Prioritate = cbPrioritate.Text;
            try
            {
                if (int.Parse(tbProgres.Text) >= 0 && int.Parse(tbProgres.Text) <= 100)
                {
                    int Progress = int.Parse(tbProgres.Text);
                }
            }
            catch(Exception ex)
            {
                isValid = false;
               
                MessageBox.Show("Introduceti o valoare intre 0 si 100.");

            }

            epDomenii.Clear();
            
            if(isValid)
            {
                
                    Proiecte proiect = new Proiecte(Denumire, Titlu, Locatie);
                    lista.Add(proiect);
                    populeazaListView();

                    curataCampuri();
            }
            else
            {
                
                MessageBox.Show("Formularul nu este valid!", "Eroare", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }

        private void curataCampuri()
        {
            cbDomenii.Text = String.Empty;
            cbTip.SelectedIndex = -1;
            tbTitlu.Text = String.Empty;
            tbLocatie.Text = String.Empty;

            dtpInceput.Value = DateTime.Now;
            dtpIncheiere.Value = DateTime.Now;

            cbPrioritate.Text = String.Empty;
            tbProgres.Text = String.Empty;
        }

        public void populeazaListView()
        {
            lvAgenda.Items.Clear();

            foreach (Proiecte each in lista)
            {
                ListViewItem item = new ListViewItem(new String[] { each.Denumire, each.tip.ToString(), each.GetTitluProiect(), 
                                            each.Prioritate});
                lvAgenda.Items.Add(item);

            }
        }

        private void btnCurata_Click(object sender, EventArgs e)
        {
            curataCampuri();
        }

        private void btnEditare_Click(object sender, EventArgs e)
        {
            if(lvAgenda.SelectedItems.Count != 0)
            {
                Proiecte proiect = lista.ElementAt(lvAgenda.SelectedIndices[0]);

                EditeazaActivitate editare = new EditeazaActivitate(proiect);
                editare.ShowDialog();

                populeazaListView();

            }
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            if(lvAgenda.SelectedItems.Count != 0)
            {
               if( MessageBox.Show("Doresti sa stergi activitatea?", "Sterge activitate", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    lista.RemoveAt(lvAgenda.SelectedIndices[0]);

                    populeazaListView();
                }
            }
        }

        private void lvAgenda_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left && lvAgenda.FocusedItem.Bounds.Contains(e.Location.X, e.Location.Y))
            {
                btnEditare_Click(sender, e);
            }
        }

        private void cmsEditeaza_Click(object sender, EventArgs e)
        {
            
                btnEditare_Click(sender, e);
        }

        private void cmsSterge_Click(object sender, EventArgs e)
        {
            btnSterge_Click(sender, e);
        }

        private void lvAgenda_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                cms.Show(Cursor.Position.X + 5, Cursor.Position.Y + 5);
            }
        }

        private void cbDomenii_Validating(object sender, CancelEventArgs e)
        {
            String dom = cbDomenii.Text;
            String[] domenii = { "MARKETING", "FINANȚE", "DESIGN", "DEZVOLTARE", "CONTABILITATE", "RESURSE", "VÂNZĂRI", "CLIENȚI" };
            
            if(domenii.Contains(dom) == false || String.IsNullOrWhiteSpace(dom))
            {
                epDomenii.SetError((Control)sender, "Te rog selecteaza un domeniu!");
                e.Cancel = true;
            }
        }

        private void cbDomenii_Validated(object sender, EventArgs e)
        {
            epDomenii.Clear();
        }

        private void cmsAdd_Click(object sender, EventArgs e)
        {
            FormDetalii form = new FormDetalii();
            form.ShowDialog();
        }


        private void editareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                btnEditare_Click(sender, e);
            
        }

        private void detaliiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDetalii form = new FormDetalii();
            form.ShowDialog();
        }

        private void adaugaONouaInregistrareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAdauga_Click(sender, e);
        }

        private void ltsDelete_Click(object sender, EventArgs e)
        {
            btnSterge_Click(sender, e);
        }

        private void ltsDeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Doresti sa stergi activitatea?", "Sterge activitate", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lista.Clear();

                populeazaListView();
            }
        }



        
    }
}
