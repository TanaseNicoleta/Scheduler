using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_Agenda_de_Activitati.Models
{
   public class Proiecte : Activitati
    {
        private String titluProiect;

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

        public DateTime dataIncepere;
        public DateTime dataIncheiere;

        public Proiecte (String domeniu, String titlu, String locatie)
        {  
            this.Denumire = domeniu;
            this.SetTitluProiect(titlu);
            this.SetLocatie(locatie);
            this.Prioritate = "High";
            this.tip = TipActivitate.REALIZARE_PROIECT;
            dataIncepere = new DateTime(2020, 01, 01);
            dataIncheiere = new DateTime(2020, 12, 30);

            this.Detalii = new Hashtable()
                {
                {"Client", "X" },
                {"Numar colegi proiect", "20" },
                {"Resurse", "Niciuna" },
                {"Deadline: ", "31.dec.2020" }

                };
            this.SetProgres(0);

        }

    }
}
