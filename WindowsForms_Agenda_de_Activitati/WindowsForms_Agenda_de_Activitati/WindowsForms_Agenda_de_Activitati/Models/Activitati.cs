using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace WindowsForms_Agenda_de_Activitati.Models
{
 [Serializable]
    public abstract class Activitati : Domenii
    {
        public int Id { get; set; }
        public TipActivitate tip { get; set; }
        
        public String Detalii { get; set; }
        public String Prioritate { get; set; }
        private String Locatie;
        private int Progres { get; set; }

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

        public Activitati()
        {

        }
    }
}
