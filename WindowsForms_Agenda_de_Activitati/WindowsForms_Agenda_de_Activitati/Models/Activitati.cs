using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_Agenda_de_Activitati.Models
{
   public abstract class Activitati : Domenii
    {
        public TipActivitate tip { get; set; }
        
        public Hashtable Detalii;
        public String Prioritate;
        private String Locatie;
        private int Progres;

        public String GetLocatie()
        {
            return Locatie;
        }

        public void SetLocatie(String oLocatie)
        {
            Locatie = oLocatie;

        }

        public int GetProgres()
        {
            return Progres;
        }
        public void SetProgres(int prog)
        {
            Progres = prog;
        }

        public virtual String GetDetalii()
        {
           return "Nu sunt detalii de afisat";
        }
    }
}
