using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace P5T1
{
    internal class carList
    {
        const int SIZE = 10;
        Car[] cars;
        int nrEl = 0;

        public carList() {
            cars = new Car[SIZE];
            ReadData();
        }
        //Read Data to Array:
        public void ReadData()
        {
            StreamReader SR = new StreamReader("carData.txt");
            const char DELIM = ',';
            string Line, rNum,model,cCol,sStatus;
            string[] strings;
            int year;
            double price;

            Line = SR.ReadLine();
            while (Line != null)
            {
                strings = Line.Split(DELIM);
                rNum = strings[0];
                model = strings[1];
                year = int.Parse(strings[2]);
                cCol = strings[3];
                price= double.Parse(strings[4]);
                sStatus = strings[5];
                cars[nrEl] = new Car(rNum,model,cCol,year,price,sStatus);
                nrEl++;
                Line = SR.ReadLine();
            }
            SR.Close();
        }

        //Delete Method:
        public void DeleteCar()
        {
            WriteLine("Enter the registration for the car you want to remove...");
            string regNum = ReadLine();
            int idx = -1;
 
                if (FindCar(regNum) > -1 )
                {
                    idx = FindCar(regNum);
                for (int i = idx; i < nrEl - 1; i++)
                {
                    cars[idx] = cars[idx++];
                }
                nrEl--;
            }
            else
            {
                WriteLine("Car is not on the list");
            }
            
        }

        public int Count() { return nrEl; }
        public void Add() {
            if (nrEl < SIZE)
            {
                Console.WriteLine("Enter registration: ");
                string rNum = Console.ReadLine();
                rNum = rNum.ToUpper();
                Console.WriteLine("Enter model: ");
                string model = Console.ReadLine();
                Console.WriteLine("Enter year: ");
                int year = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter colour: ");
                string Col = Console.ReadLine();
                Console.WriteLine("Enter price");
                double price = double.Parse(Console.ReadLine());
                string status = "available";
                cars[nrEl] = new Car(rNum,model,Col,year,price,status);
                nrEl++;
            }
        }
        //List Displays:
        public void DisplayAvailable() {
            for (int i = 0; i < nrEl; i++)
            {
                if (cars[i].getStatus() == "available")
                {
                    cars[i].DisplayCar();
                }
            }
        }
        public void NotCheap()
        {
            for (int i = 0;i < nrEl;i++)
            {
                if (cars[i].IsCheap())
                {
                    cars[i].DisplayCar();
                }
            }

        }
        public void DisplayExpensive() {
            for (int i = 0; i < nrEl; i++)
            {
                if (!cars[i].IsCheap())
                {
                    cars[i].DisplayCar();
                }
            }

        }
        public void DisplayAll()
        {
            for (int i = 0; i < nrEl; i++)
            {
                cars[i].DisplayDetailCar();
            }
        }
        //Find Car:
        public int FindCar(string wanted) {
            for (int i = 0; i < nrEl; i++)
            {
                if (cars[i].getRegNum() == wanted)
                {
                    return i;
                }

            }
            return -1;
        }
        //Sell Car:
        public void SellCar(int idx)
        {
            cars[idx].setStatus("Sold");
        }

        public void DecreasePrice()
        {
            WriteLine("Enter regitration for the car you wis to lower...");
            string regNum = ReadLine();
            int idx = FindCar(regNum);
            if (idx > -1)
            {
                WriteLine("Enter the amount you wish to lower with");
                double amt = double.Parse(ReadLine());
                cars[idx].DecreasePrice(amt);

            }
        }



        //Writing to Text File:
        public void WriteData()
        {
            StreamWriter wr = new StreamWriter("carData.txt");
            for (int i = 0; i < nrEl; i++)
            {
                wr.Write(cars[i].getRegNum() + ",");
                wr.Write(cars[i].getModelName() + ",");
                wr.Write(cars[i].getYear() + ",");
                wr.Write(cars[i].getColour() + ",");
                wr.Write(cars[i].getPrice() + ",");
                wr.WriteLine(cars[i].getStatus());
            }
            wr.Close();

        }
    }
}
