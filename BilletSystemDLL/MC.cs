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
        public override bool Brobizz { get; set; }
        public int McPriserKr = 210;

        public MC(string nummerplade,bool brobizz,DateTime Dato, bool turøresund, bool turstorebælt) : base(nummerplade,brobizz,Dato,turøresund,turstorebælt)
        {
            this.Nummerplade = nummerplade;
        }

        public override int PrisStorebælt()
        {
            if (Brobizz)
            {
                //Console.WriteLine("Du har Brobizz, og for 5% i rabat! ");
                //return 125 - (125 / 100 * 5);
                Console.WriteLine("Du har brobizz så prísen er fast 73 for Motorcykler,-");
                return 73;

            }
            return McPriserKr;
        }

        public override string KøretøjType()
        {
            return "Øresund MC";
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
