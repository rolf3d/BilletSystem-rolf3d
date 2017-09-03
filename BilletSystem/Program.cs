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
            List<Bil> billiste = new List<Bil>();
            Bil bil01 = new Bil("AB123",true,new DateTime(2017,09,03),true,true);

            billiste.Add(bil01);
            Console.WriteLine(bil01.Nummerplade);
            Console.WriteLine("I Biletsystem");
            
            Console.ReadLine();
        }
    }

   
}
