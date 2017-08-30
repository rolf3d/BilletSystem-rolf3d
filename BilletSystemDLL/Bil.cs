using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletSystemDLL
{
    public class Bil
    {
        public string Nummerplade { get; set; }
        public DateTime Dato;

        public Bil(string nummerplade)
        {
            this.Nummerplade = nummerplade;
        }

        public int Pris()
        {
            return 240;
        }

        public string Køretøj()
        {
            return "Bil";
        }
    }
}
