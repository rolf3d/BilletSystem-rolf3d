using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletSystemDLL
{
    public abstract class Køretøj
    {
        
        public abstract string Nummerplade { get; set; }
        public abstract bool Brobizz { get; set; }
        public DateTime Dato;
        public bool TurØresund;
        public bool TurStorebælt;
        public Køretøj(string nummerplade,bool brobizz,DateTime dato,bool turøresund,bool turstorebælt)
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

        

        public virtual int PrisStorebælt()
        {
            if (KøretøjType().Contains("Bil"))
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
            Console.WriteLine("MC Storebælt");
            return 125;

        }

        public virtual int PrisØresundbron()
        {
            if (KøretøjType().Contains("Bil"))
            {
                Console.WriteLine("Øresund Bil");
                return 410;
            }
            if (KøretøjType().Contains("Bil") && Brobizz)
            {
                Console.WriteLine("Øresund Bil med Brobizz");
                return 161;
            }
            if (KøretøjType().Contains("MC") && Brobizz)
            {
                Console.WriteLine("Øresund MC med Brobizz");
                return 73;

            }
            Console.WriteLine("Øresund MC");
            return 210;
        }

        public virtual string KøretøjType()
        {
            return "Base Køretøj";
        }

        //public virtual bool BrobizzFunk()
        //{
        //    return false;
        //}
    }
}
