using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Agenda_de_Activitati
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        private void btnProiecte_Click(object sender, EventArgs e)
        {
            Agenda agendaProiecte = new Agenda();
            agendaProiecte.Show();
        

        }

        private void btnEveniment_Click(object sender, EventArgs e)
        {
            FormListareEvenimenteBD eveniment = new FormListareEvenimenteBD();
            eveniment.Show();
        }

        private void btnFamilie_Click(object sender, EventArgs e)
        {
            FormFamilie fam = new FormFamilie();
            fam.Show();
        }
    }
}
