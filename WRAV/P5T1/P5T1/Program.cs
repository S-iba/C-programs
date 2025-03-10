using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace P5T1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            carList car= new carList();
            int choice = -1;
            while (choice != 9)
            {
                Console.WriteLine("Indicate your choice from the following options, 4 to quit");
                Console.WriteLine("1. Add a car to the list");
                Console.WriteLine("2. Display the reg num and price for all available cars");
                Console.WriteLine("3. Display everything");
                Console.WriteLine("4. Display cheap cars");
                Console.WriteLine("5. Sell a car -->");
                Console.WriteLine("6. Decrease price of car");
                Console.WriteLine("7. Display Expensive cars");
                Console.WriteLine("8. Delete car");
                Console.WriteLine("Choice: ");
                choice  = int.Parse(Console.ReadLine());

                if (choice == 1 )
                {
                    car.Add();
                }
                else 
                if (choice == 2) {
                    car.DisplayAvailable();
                }
                else
                if (choice == 3)
                {
                    car.DisplayAll();
                }
                else if (choice == 4) {
                    car.NotCheap();
                }
                else if (choice == 5) {
                    sellCar(car);
                    
                }else if (choice == 6)
                {
                    car.DecreasePrice();
                }else if(choice == 7)
                {
                    car.DisplayExpensive();
                }
                else if (choice == 8)
                {
                    car.DeleteCar();
                }
                if (choice == 9) { break; }
          

            }
            car.WriteData();
        }

        static void sellCar(carList car)
        {
            WriteLine("Enter the registration number: ");
            string want = ReadLine();
            want = want.ToUpper();
            int idx = car.FindCar(want);
            if (idx > -1 )
            {
                car.SellCar(idx);
            }
           

        }

    }
}
