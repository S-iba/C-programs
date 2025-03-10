using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CarDealer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            carList listOfCars = new carList();

            int choice = DisplayOptions();

            while (choice != 10)
            {
                switch (choice)
                {
                    case 1:
                        WriteLine("Add a car to the list:");
                        AddCar(listOfCars);
                        break;
                    case 2:
                        WriteLine("Delete a car:");
                        DeleteCar(listOfCars);
                        break;
                    case 3:
                        WriteLine("Display specific car details:");
                        DisplaySpecific(listOfCars);
                        break;
                    case 4:
                        WriteLine("Decrease the price of a car:");
                        DecreasePrice(listOfCars);
                        break;
                    case 5:
                        WriteLine("List of cheap cars:");
                        //Add method call(s) here
                        break;
                    case 6:
                        WriteLine("Display all cars - full details:");
                        //Add method call(s) here
                        break;
                    case 7:
                        WriteLine("List sorted on Registration number:");
                        //Add method call(s) here
                        break;
                    case 8:
                        WriteLine("List sorted on year in descending order:");
                        //Add method call(s) here
                        break;
                    case 9:
                        WriteLine("List sorted on price in descending order::");
                        //Add method call(s) here
                        break;
                    default:
                        WriteLine("Invalid choice: ");
                        break;
                }

                choice = DisplayOptions();
            }
            Console.ReadLine();
        }

        static int DisplayOptions()
        {
            WriteLine("Indicate your choice from the following options, 10 to quit.");
            WriteLine("1. Add a car to the list.");
            WriteLine("2. Delete a car - remove the car from the list.");
            WriteLine("3. Display details for a specific car.");
            WriteLine("4. Decrease the price of a car. ");
            WriteLine("5. Display the registration numbers and prices of cars below R 50 000. ");
            WriteLine("6. Display all cars - full details.");
            WriteLine("7. Sort the list in ascending order of registration number, then display the list. ");
            WriteLine("8. Sort the list in descending order of year, then display the list. ");
            WriteLine("9. Sort the list in descending order of price, then display the list. ");
            WriteLine("10. Quit. ");
            Write("Choice: ");
            int choice = int.Parse(ReadLine());
            WriteLine();
            return choice;
        }
        static void AddCar(carList listOfCars)
        {
            
        }

        static void DeleteCar(carList listOfCars)
        {
            
        }

        static void DecreasePrice(carList listOfCars)
        {
            
        }

        static void DisplaySpecific(carList listOfCars)
        {
            
        }
    }
}
