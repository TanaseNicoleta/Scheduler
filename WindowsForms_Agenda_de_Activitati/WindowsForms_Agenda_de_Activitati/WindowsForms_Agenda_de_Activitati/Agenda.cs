using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
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

        #region metode utilitare
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


            tssTotalAct.Text = "Total activitati: " + lista.Count.ToString();
        }
        #endregion

        #region butoane
        //
        //Buton adaugare activitate in lista
        //
        private void btnAdauga_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            String Denumire = cbDomenii.Text;
            if (String.IsNullOrEmpty(Denumire))
            {
                isValid = false;
            }
            Enum.TryParse(cbTip.Text, out TipActivitate Activitate);
            String Titlu = tbTitlu.Text;
            if (isValid && (string.IsNullOrWhiteSpace(Titlu) || Titlu.Length < 3))
            {
                isValid = false;
            }
            String Locatie = tbLocatie.Text;
            if (isValid && String.IsNullOrWhiteSpace(Locatie) || Locatie.Length < 3)
            {
                isValid = false;
            }
            DateTime Incepere = dtpInceput.Value;
            DateTime Incheiere = dtpIncheiere.Value;
            if (isValid && DateTime.Compare(Incepere, Incheiere) > 0)
            {
                isValid = false;
            }
            String Prioritate = cbPrioritate.Text;
            int prog = 0;
            try
            {
                if (int.Parse(tbProgres.Text) >= 0 && int.Parse(tbProgres.Text) <= 100)
                {
                    prog = int.Parse(tbProgres.Text);
                }
            }
            catch (Exception ex)
            {
                isValid = false;

                MessageBox.Show("Introduceti o valoare intre 0 si 100.");

            }

            epDomenii.Clear();

            if (isValid)
            {

                Proiecte proiect = new Proiecte(Denumire, Titlu, Locatie, Prioritate, Activitate, Incepere, Incheiere, prog);
                lista.Add(proiect);
                populeazaListView();

                curataCampuri();
            }
            else
            {

                MessageBox.Show("Formularul nu este valid!", "Eroare", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }



        }
        private void btnCurata_Click(object sender, EventArgs e)
        {
            curataCampuri();
        }

        private void btnEditare_Click(object sender, EventArgs e)
        {
            if (lvAgenda.SelectedItems.Count != 0)
            {
                Proiecte proiect = lista.ElementAt(lvAgenda.SelectedIndices[0]);

                EditeazaActivitate editare = new EditeazaActivitate(proiect);
                editare.ShowDialog();

                populeazaListView();

            }
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            if (lvAgenda.SelectedItems.Count != 0)
            {
                if (MessageBox.Show("Doresti sa stergi activitatea?", "Sterge activitate", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    lista.RemoveAt(lvAgenda.SelectedIndices[0]);

                    populeazaListView();
                }
            }
        }

        #endregion


        private void lvAgenda_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && lvAgenda.FocusedItem.Bounds.Contains(e.Location.X, e.Location.Y))
            {
                btnEditare_Click(sender, e);
            }
        }

        private void cbDomenii_Validating(object sender, CancelEventArgs e)
        {
            String dom = cbDomenii.Text;
            String[] domenii = { "MARKETING", "FINANȚE", "DESIGN", "DEZVOLTARE", "CONTABILITATE", "RESURSE", "VÂNZĂRI", "CLIENȚI" };

            if (domenii.Contains(dom) == false || String.IsNullOrWhiteSpace(dom))
            {
                epDomenii.SetError((Control)sender, "Te rog selecteaza un domeniu!");
                e.Cancel = true;
            }
        }

        private void cbDomenii_Validated(object sender, EventArgs e)
        {
            epDomenii.Clear();
        }


        #region menu strips

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
            if (e.Button == MouseButtons.Right)
            {
                cms.Show(Cursor.Position.X + 5, Cursor.Position.Y + 5);
            }
        }

        private void cmsAdd_Click(object sender, EventArgs e)
        {
            Proiecte proiect = lista.ElementAt(lvAgenda.SelectedIndices[0]);
            FormDetalii form = new FormDetalii(proiect);
            form.ShowDialog();
        }


        private void editareToolStripMenuItem_Click(object sender, EventArgs e)
        {

            btnEditare_Click(sender, e);

        }

        private void detaliiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proiecte proiect = lista.ElementAt(lvAgenda.SelectedIndices[0]);
            FormDetalii form = new FormDetalii(proiect);
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
        #endregion


        #region salvare fisiere
        //Fisier Binar
        private void fisierBinarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            FileStream stream = new FileStream("binary.dat", FileMode.Create);
            binaryFormatter.Serialize(stream, lista);

            stream.Close();
            MessageBox.Show("Fisierul binary.dat salvat cu succes");
        }

        //Fisiet TEXT
        private void fisierTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Title = "Salveaza in fisier text";
            sfd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            sfd.FilterIndex = 1;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                foreach (Proiecte each in lista)
                {
                    sw.Write(each.Denumire + '\t' + each.tip.ToString() + '\t' + each.GetTitluProiect().ToString() + '\t' +
                        each.dataIncepere.ToString() + '\t' + each.dataIncheiere.ToString() + '\t' + each.GetLocatie() + '\t' +
                       each.Prioritate + '\t' + each.GetProgres().ToString() + '\t'+ each.GetDetalii()+'\n');
                }
                sw.Close();
            }
        }


        //Fisier XML
        private void fisierXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {

            XmlSerializer serializer = new XmlSerializer(typeof(List<Proiecte>));

            FileStream fs = File.Create("lista.xml");
            serializer.Serialize(fs, lista);

            fs.Close();
            MessageBox.Show("Fisierul lista.xml salvat cu succes");


        }



        #endregion


        #region import fisiere

        //BINAR
        private void binarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Selecteaza fisierul binar pentru deserializare";
            ofd.Filter = "Text files (*.txt)|*.txt|Binary files (*.dat)|*.dat|All files (*.*)|*.*";
            ofd.FilterIndex = 2;


            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = File.OpenRead(ofd.FileName);
                lista = binaryFormatter.Deserialize(fs) as List<Proiecte>;
           
                fs.Close();
                populeazaListView();
            }
        }

       
        //TEXT
        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Importa dintr-un fisier text";
            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            ofd.FilterIndex = 1;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(ofd.FileName);

                String line = string.Empty;


                //Asa am exportat tot asa le ctesc
                //sw.Write(each.Denumire + '\t' + each.tip.ToString() + '\t' + each.GetTitluProiect() + '\t' +
                //       each.dataIncepere.ToString() + '\t' + each.dataIncheiere.ToString() + '\t' + each.GetLocatie() + '\t' +
                //      each.Prioritate + '\t' + each.GetProgres() + '\n');


                while ((line = sr.ReadLine()) != null)
                {

                    string[] vect = line.Split('\t');

                    String denumire = vect[0];
                    Enum.TryParse(vect[1], out TipActivitate tip);
                    String titlu = vect[2];
                    DateTime.TryParse(vect[3], out DateTime inceput);
                    DateTime.TryParse(vect[4], out DateTime incheiere);

                    String locatie = vect[5];
                    String prioritate = vect[6];
                    int progres = Convert.ToInt32(vect[7]);

                    Proiecte proiect = new Proiecte(denumire, titlu, locatie, prioritate, tip, inceput, incheiere, progres);

                    lista.Add(proiect);

                }

                populeazaListView();

                sr.Close();

            }
        }

        //XML
        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Proiecte>));

            try
            {
                FileStream fs = File.OpenRead("lista.xml");

                lista = serializer.Deserialize(fs) as List<Proiecte>;

                fs.Close();
                populeazaListView();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        #endregion

        private void lvAgenda_KeyDown(object sender, KeyEventArgs e)
        {
            //Ctrl + D ----->Detalii

            if(e.KeyCode == Keys.D && e.Control)
            {
                Proiecte proiect = lista.ElementAt(lvAgenda.SelectedIndices[0]);
                FormDetalii detalii = new FormDetalii(proiect);
                detalii.Show();
            }

            //Ctrl + E ----->Editeaza
            if(e.KeyCode == Keys.E && e.Control)
            {
                btnEditare_Click(sender, e);
            }

        }
  

        private void tssTotalAct_TextChanged(object sender, EventArgs e)
        {
            tssTotalAct.Text = "Total activitati: " + lista.Count.ToString();
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
            Graphics graphics = e.Graphics;
            Font font = new Font("Timen New Roman", 15);
            Brush brush = Brushes.DarkBlue;
            Pen pen = new Pen(brush);

            PageSettings settings = printDocument.DefaultPageSettings;
            var totalDrawableW = settings.PaperSize.Width - settings.Margins.Left - settings.Margins.Right;
            var totalDrawableH = settings.PaperSize.Height - settings.Margins.Top - settings.Margins.Bottom;

            if (settings.Landscape)
            {
                var temp = totalDrawableW;
                totalDrawableW = totalDrawableH;
                totalDrawableH = temp;
            }

            int cellWidth = totalDrawableW / 3;
            int cellHeight = 40;

            int x = settings.Margins.Left;
            int y = 100;

            graphics.DrawString("Lista Proiecte  " + tbTitlu.Text, font, brush, totalDrawableW / 2, y);

            y += 100;

            // desenare format cap de tabel
            graphics.DrawRectangle(pen, x, y, cellWidth, cellHeight);
            graphics.DrawRectangle(pen, x + cellWidth, y, cellWidth, cellHeight);
            graphics.DrawRectangle(pen, x + 2 * cellWidth, y, cellWidth, cellHeight);

            // desenare continut cap de tabel
            graphics.DrawString("Titlu", font, brush, x, y);
            graphics.DrawString("Data Incepere", font, brush, x + cellWidth, y);
            graphics.DrawString("Data Incheiere", font, brush, x + 2 * cellWidth, y);
            y += cellHeight;


            foreach (Proiecte p in lista)
            {
                // desenare format cap de tabel
                graphics.DrawRectangle(pen, x, y, cellWidth, cellHeight);
                graphics.DrawRectangle(pen, x + cellWidth, y, cellWidth, cellHeight);
                graphics.DrawRectangle(pen, x + 2 * cellWidth, y, cellWidth, cellHeight);

                // desenare continut cap de tabel
                graphics.DrawString(p.GetTitluProiect(), font, brush, x, y);
                graphics.DrawString(p.dataIncepere.ToString(), font, brush, x + cellWidth, y);
                graphics.DrawString(p.dataIncheiere.ToString(), font, brush, x + 2 * cellWidth, y);

                y += cellHeight;
            }
        }
        #endregion

        #region navigare intre formulare
        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStart start = new FormStart();
            start.Show();
        }

        private void evenimenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListareEvenimenteBD ev = new FormListareEvenimenteBD();
            ev.Show();
        }

        private void familieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFamilie fam = new FormFamilie();
            fam.Show();
        }




        #endregion

        private void tspStats_Click(object sender, EventArgs e)
        {
            FormStatistics form = new FormStatistics();
            form.Show();
        }

      
    }
}
