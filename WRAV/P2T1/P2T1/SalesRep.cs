using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace P2T1
{
    internal class SalesRep
    {
        string Name;
        double Rate;
        double Sales;

        public SalesRep(string name, double rate, double sales)
        {
            this.Name = name;
            this.Rate = rate;
            this.Sales = sales;

        }

        public string GetName() { return Name; }

        public double GetSales() { return Sales; }

        public void SetSale(double amount) { this.Sales = amount; }

        public void DisplayPerson() {
            WriteLine("Name: {0} \nRate: {1:F2} \nSales: {2:C2} \ns",Name,Rate,Sales);
        
        }
    }
}
