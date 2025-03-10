using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2T2
{
    internal class Recipient : IComparable
    {
        String Name;
        int Hours;

        public Recipient(String Name, int Hours) 
        {
            this.Name = Name;
            this.Hours = Hours;
        }
        //Getters:
        public String GetName() { return Name; }
        public int GetHours() { return Hours; }
        //Setters:
        public void SetHours(int H) {  this.Hours = H; }
        public void DecreaseHours(int H) { this.Hours -= H; }    
        //Output:
        public void DisplayRecipient() 
        {
            Console.WriteLine("Name: {0} \nHours: {1} \n",Name,Hours);
        }

        //Interface:
        int IComparable.CompareTo(object obj) {
            int returnVal;
            Recipient temp = (Recipient)obj;
            if (string.Compare(this.Name, temp.Name) > 0)
                returnVal = 1;
            else
                if (string.Compare(this.Name, temp.Name) < 0)
                returnVal = -1;
            else
                returnVal = 0;
            return returnVal;
            
        }

    }
}
