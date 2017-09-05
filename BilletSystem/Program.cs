using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BilletSystemDLL;


namespace BilletSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Bil> billiste = new List<Bil>();
            Bil kundebilbent = new Bil("23", true, DateTime.Now, false, false);
            Bil kundebilhans = new Bil("987", true, DateTime.Now, true, false);

            List<Kunde> kundeliste = new List<Kunde>();
            Kunde kunde1 = new Kunde("Bent",kundebilbent);
            Kunde kunde2 = new Kunde("Hans",kundebilhans);

            

            kundeliste.Add(kunde1);
            kundeliste.Add(kunde2);

            foreach (var kunder in kundeliste)
            {
                Console.WriteLine(kunder.Fornavn);
            }
            

            
            kunde1.Totalberegner();

            Console.WriteLine("Totalberegner fra kunde klassen");
            Console.WriteLine(kunde1.Totalberegner() + " Total pris for kunde " + kunde1.Fornavn);
            


            Console.WriteLine();
            //Bil bil01 = new Bil("AB123",true,new DateTime(2017,09,03),true,true);
            

            //billiste.Add(bil01);
            Console.WriteLine("I Biletsystem");
            

            

            Console.ReadLine();
        }
    }

   
}
