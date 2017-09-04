using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletSystemDLL
{
    public class Kunde
    {
        List<IEnumerable<Bil>> Ture = new List<IEnumerable<Bil>>();

        public Kunde()
        {
            Bil kundebil01 = new Bil("123", true, DateTime.Now, true, true);

            Ture = new List<IEnumerable<Bil>>();
            
        }

        
        //public override string ToString()
        //{
        //    return this.kundebil01.Nummerplade + kundebil01.Brobizz + kundebil01.KøretøjType() +
        //           kundebil01.TurStorebælt + kundebil01.TurØresund;
        //}

    }
}
