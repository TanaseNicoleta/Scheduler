using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_Agenda_de_Activitati.Models
{
   public class EvenimentFirma : Activitati
    {
        public int Id {get; set;}
        public String Denumire { get; set; }
        public DateTime dataEveniment { get; set; }


        public void SetDetalii(String detalii)
        {
            Detalii = detalii;
        }

        override
        public String GetDetalii()
        {
            return Detalii;
        }

        public EvenimentFirma(String _denumire, String _loc, DateTime data)
        {
            Denumire = _denumire;
            SetLocatie(_loc);
            dataEveniment = data;
            tip = TipActivitate.EVENIMENT;

        }

        public EvenimentFirma()
        {
            tip = TipActivitate.EVENIMENT;
        }

    }
}
