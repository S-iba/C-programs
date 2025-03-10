using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2T2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Recipient Xola = new Recipient("Xola", 90);
            Recipient Sandy = new Recipient("Sandy", 90);
            Recipient David = new Recipient("David", 60);
            //Retreiving number of hours from the object:
            int xHour, sHour, dHour;
            xHour = Xola.GetHours();
            sHour = Sandy.GetHours();
            dHour = David.GetHours();
            //Subtracting the number of hours worked:
            xHour = xHour - 20;
            sHour = sHour - 16;
            dHour = dHour - 10;
            //Updating the hours:
            Sandy.SetHours(sHour);
            David.SetHours(dHour);
            Xola.SetHours(xHour);
            //Displaying the info:
            Xola.DisplayRecipient();
            Sandy.DisplayRecipient();
            David.DisplayRecipient();
            Console.ReadLine();


        }
    }
}
