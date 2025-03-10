using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace P2T1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SalesRep John = new SalesRep("John", 0.08, 8000);
            SalesRep Susan = new SalesRep("Susan", 0.08, 0);

            Susan.SetSale(7560.38);

            if (John.GetSales() > Susan.GetSales())
            {
                WriteLine("John has the highest sales... ");

            }
            else 
            {
                WriteLine("Susan has thr highest sales... ");
            }

            Console.WriteLine();
            Susan.DisplayPerson();
            John.DisplayPerson();

            Console.ReadLine();

        }
    }
}
