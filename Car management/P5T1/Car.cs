using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace P5T1
{
    internal class Car
    {
        String regNumber;
        string ModelName;
        string Colour;
        int year;
        double Price;
        string Status;

        //Constructor:
        public Car(String rNum,string mName,string Col,int iYear,double dPrice,String bStat) { 
            this.regNumber = rNum;
            this.ModelName = mName;
            this.Colour = Col;
            this.year= iYear;
            this.Price = dPrice;
            this.Status = bStat;
        
        }
        //Mutators:
        public void setRegNum(String rNum) { this.regNumber = rNum; }
        public void setModel(String mName) { this.ModelName = mName; }
        public void setColour(String mColour) { this.Colour = mColour; }
        public void setYear(int iYear) { this.year= iYear; }
        public void setPrice(double dPrice) { this.Price = dPrice; }
        public void setStatus(String bStat) { this.Status = bStat; }

        //Accessors:
        public string getRegNum() { return regNumber; }
        public string getModelName() { return ModelName;}
        public string getColour() { return Colour;}
        public int getYear() { return year;}
        public double getPrice() { return Price;}
        public string getStatus() { return Status;}

        //Other Methods:

        public void DisplayCar() {
            Console.WriteLine("Registration: {0} \nPrice: {1:C2} \n", regNumber, Price);
        }
        public void DisplayDetailCar() {
            Console.WriteLine("Registration: {0} \nPrice: {1:C2} \nModel: {2} \nColour: {3} \nYear: {4} \nStatus: {5} \n",regNumber,Price,ModelName,Colour,year, Status);


        }
        public bool IsCheap() {
            if (this.Price < 50000)
            {
                return true;
            }
            return false;
        }
        public void DecreasePrice(double amount) { 
            this.Price -= amount;
            Console.WriteLine("Price successfully lowered...");
        }

    }   


}
