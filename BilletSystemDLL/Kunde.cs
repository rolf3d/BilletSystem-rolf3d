using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletSystemDLL
{
    public class Kunde
    {
        List<ITure> turene = new List<ITure>();

        Bil kundebil = new Bil("23", true, DateTime.Now, false, false);
        Bil kundebil2 = new Bil("987", true, DateTime.Now, true, false);

        public double Totalpris { get; set; }
        public string Fornavn { get; set; }
        public Bil KundensBil { get; set; }

        public Kunde(string fornavn,Bil kundensBil)
        {
            this.Fornavn = fornavn;
            this.KundensBil = kundensBil;
            turene = new List<ITure>();
            turene.Add(kundebil);
            turene.Add(kundebil2);

        }

        public double Totalberegner()
        {
            double sum1 = 0;
            double sum2 = 0;
            foreach (var itemTure in turene)
            {
                sum1 += itemTure.PrisØresundbron();
                sum2 += itemTure.PrisStorebælt();
                Totalpris = sum1 + sum2;

            }
            return Totalpris;
        }
        

    }
}
