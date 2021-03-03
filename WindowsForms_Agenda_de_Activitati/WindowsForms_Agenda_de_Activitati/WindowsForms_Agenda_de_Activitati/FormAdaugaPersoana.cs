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
    public partial class FormAdaugaPersoana : Form
    {
        
        List<Persoane> persoane = new List<Persoane>();

        public FormAdaugaPersoana(List<Persoane> lista)
        {
            InitializeComponent();
            persoane = lista;
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            Persoane pers = new Persoane(tbNume.Text, tbGradRud.Text);
            persoane.Add(pers);

            MessageBox.Show("Adaugare cu succes!");
            this.Close();

        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            tbNume.Clear();
            tbGradRud.Clear();


        }
    }
}
