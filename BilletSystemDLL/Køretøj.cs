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
        public Køretøj(string nummerplade,bool brobizz,DateTime dato)
        {
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

        

        public virtual int Pris()
        {
            
            return 100;
        }

        public virtual string KøretøjType()
        {
            return "Base Køretøj";
        }

        public virtual bool BrobizzFunk()
        {
            return false;
        }
    }
}
