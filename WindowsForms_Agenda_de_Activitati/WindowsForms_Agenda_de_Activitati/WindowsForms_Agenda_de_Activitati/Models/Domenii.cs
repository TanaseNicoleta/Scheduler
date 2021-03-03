using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_Agenda_de_Activitati.Models
{
 [Serializable]
    public class Domenii
    {
        private String _Denumire;

        public String Denumire
        {
            get
            {
                return _Denumire;
            }
            set
            {
                _Denumire = value;
            }
        }

       public Domenii()
        {
            Denumire = "Poiect";
        }
    }
}
