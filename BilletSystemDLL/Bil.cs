using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletSystemDLL
{
    public class Bil : Køretøj
    {

        public override string Nummerplade { get; set; }

        public override int Pris()
        {
            return 240;
        }

        public override string KøretøjType()
        {
            return "Bil";
        }

        //public string Nummerplade { get; set; }
        //public DateTime Dato;

        public Bil(string nummerplade): base(nummerplade)
        {
            this.Nummerplade = nummerplade;
        }

        //public int Pris()
        //{
        //    return 240;
        //}

        //public string Køretøj()
        //{
        //    return "Bil";
        //}

    }
}
