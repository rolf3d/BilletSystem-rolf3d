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

        public Køretøj(string nummerplade)
        {
            this.Nummerplade = nummerplade;
            if (Nummerplade.Length > 7)
            {
                throw new ArgumentException("Nummerpladen indenholder for mange tegn! ");
            }
        }

        public DateTime Dato;

        public virtual int Pris()
        {
            return 100;
        }

        public virtual string KøretøjType()
        {
            return "Base Køretøj";
        }
    }
}
