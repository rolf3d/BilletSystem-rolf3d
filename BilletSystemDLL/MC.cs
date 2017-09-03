using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletSystemDLL
{
    public class MC : Køretøj
    {

        public override string Nummerplade { get; set; }

        public MC(string nummerplade) : base(nummerplade)
        {
            this.Nummerplade = nummerplade;
        }

        public override int Pris()
        {
            return 125;
        }

        public override string KøretøjType()
        {
            return "MC";
        }

        // Inden arv

        //public string Nummerplade { get; set; }
        //public DateTime dato;

        //public MC(string nummerplade)
        //{
        //    this.Nummerplade = nummerplade;
        //}

        //public int Pris()
        //{
        //    return 125;
        //}

        //public string Køretøj()
        //{
        //    return "MC";
        //}


    }
}
