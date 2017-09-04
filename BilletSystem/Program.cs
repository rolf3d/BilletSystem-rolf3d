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

            List<Kunde> kunde_Peter = new List<Kunde>();

            Bil kundebil01 = new Bil("123", true, DateTime.Now, true, true);
            


            Console.WriteLine();
            //Bil bil01 = new Bil("AB123",true,new DateTime(2017,09,03),true,true);
            

            //billiste.Add(bil01);
            Console.WriteLine("I Biletsystem");
            

            

            Console.ReadLine();
        }
    }

   
}
