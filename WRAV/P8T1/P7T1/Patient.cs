using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace P7T1
{
    internal class Patient
    {
        int pNum;
        String surname;
        string initials;
        double bOwed;
        public Patient(int num,string sur,string ini,double ammount) {
        
            this.pNum = num;
            this.surname = sur;
            this.initials = ini;
            this.bOwed = ammount;
        }

        //Setters:
        public void setNum(int num) { this.pNum = num; }
        public void setSurname(string surname) { this.surname = surname; }  
        public void setInitials(string ini) { this.initials = ini; }
        public void setBalance(double amt) { this.bOwed = amt; }

        //Getters:
        public int getNum() { return pNum; }
        public String getSurname() {  return surname; }
        public string getInitials() { return this.initials; }
        public double getBalance() {  return bOwed; }

        //Display:
        public void Display()
        {
            WriteLine("************************************************");
            WriteLine("> Patient number :{0} ",pNum);
            WriteLine("> Initials       :{0} ",initials);
            WriteLine("> Surname        :{0} ",surname);
            WriteLine("> Balance owed   :{0:C2} ",bOwed);
            WriteLine("************************************************");
            WriteLine();
        }

        //Comparing:
        public bool isAbove(double amt)
        {
            if (amt > bOwed)
                return true;
            return false;
        }



    }
}
