using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_Agenda_de_Activitati.Models
{
    class CustomException:Exception
    {
        public override string Message
        {
            get
            {
                return "Nu exista modificari. Activitatea va ramane la fel.";
            }
        }

    }
}
