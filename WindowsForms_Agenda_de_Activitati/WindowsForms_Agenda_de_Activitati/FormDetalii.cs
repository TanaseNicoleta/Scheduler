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
        Proiecte _instance;

        public FormDetalii()
        {
            InitializeComponent();
            
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            rtDetalii.Text = String.Empty;
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {

        }
    }
}
