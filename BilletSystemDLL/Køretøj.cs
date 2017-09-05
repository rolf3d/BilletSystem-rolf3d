using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletSystemDLL
{
    public abstract class Køretøj : ITure
    {

        public abstract string Nummerplade { get; set; }
        public abstract bool Brobizz { get; set; }

        public DateTime Dato;
        public bool TurØresund;
        public bool TurStorebælt;
        public Køretøj(string nummerplade, bool brobizz, DateTime dato, bool turøresund, bool turstorebælt)
        {
            this.TurØresund = turøresund;
            this.TurStorebælt = turstorebælt;
            this.Dato = dato;
            this.Brobizz = brobizz;
            if (Brobizz)
            {
                Console.WriteLine("Dette køretøj har Brobizz! ");
            }
            else
            {
                Console.WriteLine("Dette køretøj har ikke Brobizz, desværre! ");
            }
            this.Nummerplade = nummerplade;
            if (Nummerplade.Length > 7)
            {
                throw new ArgumentException("Nummerpladen indenholder for mange tegn! ");
            }
        }


        public abstract int PrisStoreBælt();
        public virtual int PrisStorebælt()
        {
            if (TurStorebælt)
            {

                if (KøretøjType().Contains("Bil") && Brobizz == false)
                {
                    Console.WriteLine("Bil Storebælt");
                    return 240;
                }
                if (KøretøjType().Contains("Bil") && Brobizz)
                {
                    Console.WriteLine("Bil med Brobizz Storebælt");
                    return 230;
                }

                if (KøretøjType().Contains("MC") && Brobizz)
                {
                    Console.WriteLine("MC med Brobizz StoreBælt");
                    return 120;

                }
                if (KøretøjType().Contains("MC") && Brobizz == false)
                {
                    Console.WriteLine("MC uden Brobiz StoreBælt");
                    return 125;
                }

                Console.WriteLine("MC Storebælt");
            }
            Console.WriteLine("Du har ikke kørt over storebælt: " + KøretøjType());
            return 0;

        }

        public virtual int PrisØresundbron()
        {
            if (TurØresund)
            {
                if (KøretøjType().Contains("Bil") && Brobizz == false)
                {
                    Console.WriteLine("Øresund Bil");
                    return 410;
                }
                if (KøretøjType().Contains("Bil") && Brobizz)
                {
                    Console.WriteLine("Øresund Bil med Brobizz");
                    return 161;
                }

                Console.WriteLine("Øresund Bil");
            }

            return 0;
        }

        public virtual string KøretøjType()
        {
            return "Base Køretøj";
        }


    }
}
