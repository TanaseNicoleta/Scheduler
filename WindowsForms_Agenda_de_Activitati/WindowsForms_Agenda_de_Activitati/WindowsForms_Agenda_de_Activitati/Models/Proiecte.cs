using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_Agenda_de_Activitati.Models
{
    [Serializable]
    public class Proiecte : Activitati
    {
        public int Id {get; set;}
        private String titluProiect;
        public DateTime dataIncepere { get; set; }
        public DateTime dataIncheiere { get; set; }

        public String GetTitluProiect()
        {
            return titluProiect;
        }

        public void SetTitluProiect(String titlu)
        {
            titluProiect = titlu;
        }

        public string DescrieProiect()
        {
            return  titluProiect + " este un proiect de " + this.Denumire;
        }

       

        public void SetDetalii(String detalii)
        {
            Detalii = detalii;
        }

        override
        public String GetDetalii()
        {
            return Detalii;
        }

        public Proiecte (String domeniu, String titlu, String locatie)
        {  
            this.Denumire = domeniu;
            this.SetTitluProiect(titlu);
            this.SetLocatie(locatie);
            this.Prioritate = "High";
            this.tip = TipActivitate.REALIZARE_PROIECT;
            dataIncepere = new DateTime(2020, 01, 01);
            dataIncheiere = new DateTime(2020, 12, 30);

            this.Detalii = "Client X, Deadline: 30.dec.2020";
            this.SetProgres(0);

        }


        public Proiecte(String domeniu, String titlu, String locatie, String prioritate, TipActivitate tip, DateTime incepere, DateTime incheiere, int progres)
        {
            this.Denumire = domeniu;
            this.SetTitluProiect(titlu);
            this.SetLocatie(locatie);
            this.Prioritate = prioritate;
            this.tip = tip;
            dataIncepere = incepere;
            dataIncheiere = incheiere;

            this.Detalii = "Client X, Deadline: 30.dec.2020";
            this.SetProgres(progres);

        }

        public Proiecte()
        {

        }

    }
}
