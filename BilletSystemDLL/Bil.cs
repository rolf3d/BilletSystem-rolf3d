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
        public override bool Brobizz { get; set; }

       

        //public string Nummerplade { get; set; }
        //public DateTime Dato;

        public Bil(string nummerplade,bool brobizz): base(nummerplade,brobizz)
        {
            this.Nummerplade = nummerplade;
            
        }

        public override int Pris()
        {
            if (Brobizz)
            {
                Console.WriteLine("Du har Brobizz, og for 5% i rabat! ");
                return 240 - (240 / 100 * 5);
            }
            else
            {
                return 240;
            }
            
        }

        public override string KøretøjType()
        {
            return "Bil";
        }


        //public int Pris()
        //{
        //    return 240;
        //}

        //public string Køretøj()
        //{
        //    return "Bil";
        //}

        public override string ToString()
        {
            return this.Brobizz.ToString() + Nummerplade.ToString();
        }
    }
}
