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
    public partial class FormDetalii : Form
    {
        Proiecte _instance ;
        EvenimentFirma _eveniment;

        public FormDetalii(Proiecte proiect)
        {
            InitializeComponent();
            _instance = proiect;
            
        }


        public FormDetalii(EvenimentFirma ev)
        {
            InitializeComponent();
            _eveniment = ev;

        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            rtDetalii.Text = String.Empty;
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            if (_instance != null)
            {
                _instance.SetDetalii(rtDetalii.Text);
            }
            else
                if (_eveniment != null)
                 {
                _eveniment.SetDetalii(rtDetalii.Text);
                 }


        }

      
    }
}
