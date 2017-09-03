using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletSystemDLL
{
    public class Bil : Køretøj , IWeekendRabat
    {

        public override string Nummerplade { get; set; }
        public override bool Brobizz { get; set; }

        private int bilpriserkr = 410;





        //public string Nummerplade { get; set; }
        //public DateTime Dato;

        public Bil(string nummerplade,bool brobizz,DateTime Dato,bool turøresund,bool turstorebælt): base(nummerplade,brobizz,Dato,turøresund,turstorebælt)
        {
            this.Nummerplade = nummerplade;
            
        }

        //public override int PrisStorebælt()
        //{
        //    if (Brobizz)
        //    {
        //        //Console.WriteLine("Du har Brobizz, og for 5% i rabat! ");
        //        //return bilpriserkr - (bilpriserkr / 100 * 5);
        //        Console.WriteLine("Du har brobizz så prísen er fast 161,-");
        //        return 161;
        //    }
        //    else
        //    {
        //        return bilpriserkr;
        //    }
            
        //}

        //public override int PrisØresundbron()
        //{
        //    if (Brobizz)
        //    {
        //        Console.WriteLine("Du har Brobizz, og skal betale 161,- ");
        //        return 161;
        //    }
        //    else
        //    {
        //        return bilpriserkr;
        //    }
        //}

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

        /// <summary>
        /// Til interface
        /// </summary>
        /// // I opgave 8 er der ingen weekend rabatter.
        public int WeekendRabat { get; set; }
        public int WeekendRabatter()
        {
            //List<DayOfWeek> RabatDage = new List<DayOfWeek>() { DayOfWeek.Saturday, DayOfWeek.Sunday };

            //if (RabatDage.Contains(DayOfWeek.Saturday) || RabatDage.Contains(DayOfWeek.Sunday))
            //{
            //    Console.WriteLine("Du for rabat fordi det er weekend! ");
            //    if (Brobizz)
            //    {
            //        return bilpriserkr - (bilpriserkr / 100 * 5) - (bilpriserkr / 100 * 20);
            //    }
            //    return bilpriserkr - (bilpriserkr / 100 * 20);

            //}
            //return bilpriserkr;
            return 0;

        }
    }
}
