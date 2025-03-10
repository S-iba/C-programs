using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer
{
    internal class Car
    {
        String regNr, model, colour;
        int year;
        double price;

        public Car(String regNr, String model, int year, String colour, double price)
        {
            this.regNr = regNr;
            this.model = model;
            this.year = year;
            this.colour = colour;
            this.price = price;
        }

        public String GetRegNr()
        {
            return regNr;
        }

        public String GetModel()
        {
            return model;
        }

        public String GetColour()
        {
            return colour;
        }

        public double GetPrice()
        {
            return price;
        }
        public int GetYear()
        {
            return year;
        }
        public void SetPrice(double price)
        {
            this.price = price;
        }
        public void DisplayCar()
        // displays the Registration Number and Price of a car
        {
            Console.WriteLine("Reg Nr {0}; Price {1:F2}", regNr, price);
        }
        public void DisplayDetailCar()
        // displays all the fields for a car
        {
            Console.WriteLine("{0}, {1}, {2}, {3}, {4:F2}", regNr, model, year, colour, price);
        }

        public bool IsCheap()
        // returns TRUE if the car is selling for under R50000.00
        {
            bool cheap;
            if (price < 50000)
                cheap = true;
            else
                cheap = false;
            return cheap;
        }
        public void DecreasePrice(double amount)
        // decreases the selling price by Amount
        {
            price = price - amount; //price -= amount
        }
    }
}
