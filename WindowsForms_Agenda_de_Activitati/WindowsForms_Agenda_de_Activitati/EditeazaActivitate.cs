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
    public partial class EditeazaActivitate : Form
    {
        Proiecte _instance;

        public EditeazaActivitate( Proiecte proiect)
        {
            InitializeComponent();
            _instance = proiect;
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            bool isDifferent = true;
            CustomException ex = new CustomException();

            if(_instance.Denumire == cbDomenii.Text)
                isDifferent = false;

            Enum.TryParse(cbTip.Text, out TipActivitate tip);
            if (_instance.tip == tip && isDifferent)
                isDifferent = false;               
            if (_instance.GetTitluProiect() == tbTitlu.Text && isDifferent)
                isDifferent = false;
            if (_instance.GetLocatie() == tbLocatie.Text && isDifferent)
                isDifferent = false;
            if (_instance.dataIncepere == dtpInceput.Value && isDifferent)
                isDifferent = false;
            if (_instance.dataIncheiere == dtpIncheiere.Value && isDifferent)
                isDifferent = false;
            if (_instance.Prioritate == cbPrioritate.Text && isDifferent)
                isDifferent = false;
            if (_instance.GetProgres() == int.Parse(tbProgres.Text) && isDifferent)
                isDifferent = false;

            if (isDifferent == true)
            {
                _instance.Denumire = cbDomenii.Text;
                _instance.tip = tip;
                _instance.SetTitluProiect(tbTitlu.Text);
                _instance.SetLocatie(tbLocatie.Text);
                _instance.dataIncepere = dtpInceput.Value;
                _instance.dataIncheiere = dtpIncheiere.Value;
                _instance.Prioritate = cbPrioritate.Text;
                _instance.SetProgres(int.Parse(tbProgres.Text));
            }
            else
                MessageBox.Show(ex.Message);
            this.Close();

        }

        private void btnAnuleaza_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditeazaActivitate_Load(object sender, EventArgs e)
        {
            cbDomenii.Text = _instance.Denumire;
            Enum.TryParse(cbTip.Text, out TipActivitate tip);
            tip = _instance.tip;
            tbTitlu.Text = _instance.GetTitluProiect();
            tbLocatie.Text = _instance.GetLocatie();
            dtpInceput.Value = _instance.dataIncepere;
            dtpIncheiere.Value = _instance.dataIncheiere;
            cbPrioritate.Text = _instance.Prioritate;
            tbProgres.Text = _instance.GetProgres().ToString();

        }
    }
}
