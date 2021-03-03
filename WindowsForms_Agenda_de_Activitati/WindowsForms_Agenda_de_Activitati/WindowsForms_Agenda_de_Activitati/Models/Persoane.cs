using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_Agenda_de_Activitati.Models
{
    public class Persoane
    {
        public int Id { get; set; }
        public String nume {get; set; }
        public String grad_rudenie { get; set; }

        public Persoane()
        {

        }

        public Persoane(String _nume, String grad )
        {
            nume = _nume;
            grad_rudenie = grad;
        }
    }
}
