using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_Agenda_de_Activitati.Models
{
   public class ActivitatiFamilie: Activitati
    {
        public int Id { get; set; }
        public String Denumire { get; set; }
        public DateTime dataActivitate { get; set; }
        public List<Persoane> persoane { get; set; }


        public void SetDetalii(String detalii)
        {
            Detalii = detalii;
        }

        override
        public String GetDetalii()
        {
            return Detalii;
        }

        public ActivitatiFamilie(String _denumire, String _loc, DateTime data)
        {
            Denumire = _denumire;
            SetLocatie(_loc);
            dataActivitate = data;
            tip = TipActivitate.FAMILIE;
            persoane = new List<Persoane>();

        }

        public ActivitatiFamilie()
        {
            persoane = new List<Persoane>();
            tip = TipActivitate.FAMILIE;
        }

    }
}
