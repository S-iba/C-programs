using System; 
using System.Collections;
using System.Collections.Generic;
using System.Linq; 
using System.Text; 
using System.Threading.Tasks;
using static System.Console;
using System.IO;
using System.Runtime.ConstrainedExecution;
using System.Runtime.CompilerServices;

namespace P7T1 
{ 
    internal class PatientList 
    {
        ArrayList MyList;
        string filename;
        const char DELIM = ',';

        //Constructor:
        public PatientList(string File)
        {
            filename = File;
            MyList = new ArrayList();
            ReadData();
        }
        //Count:
        public int Count { get { return MyList.Count; } }

        //add method:
        public void Add()
        {
            WriteLine("Enter patient number: ");
            int pNum = int.Parse(ReadLine());
            WriteLine("Enter Surname: ");
            string sur = ReadLine();
            WriteLine("Enter initials: ");
            string ini = ReadLine();
            WriteLine("Enter balance: ");
            double bal = double.Parse(ReadLine());

            Patient newPatient = new Patient(pNum,sur,ini,bal);
            MyList.Add(newPatient);

            WriteLine("Patient successfully added");
        }

        //Delete method:
        public void Delete(int pos)
        {
            Patient newP = GetPatient(pos);
            WriteLine("Balance: {0:C2}", newP.getBalance());
            WriteLine("Do you wish to continue? y/n");
            string choice = ReadLine();
            choice = choice.ToUpper();
            if (choice == "Y")
            {
                MyList.RemoveAt(pos - 1);
                WriteLine("Patient successfully deleted");
            }
            else
            {
                WriteLine("Delete process aborted");
            }
            
        }

        //Find patient:
        public int Find(int wanted) 
        {
            for (int i = 0; i <= MyList.Count -1 ;i++)
            {

                Patient curr = (Patient)MyList[i];
                if (wanted == curr.getNum())
                    return i;
            }
            
            return -1;

        }

        //Get Patient:
        public Patient GetPatient(int pos) 
        {
            pos--;
            if ((pos >= 0) && (pos <= MyList.Count-1))
                return (Patient)MyList[pos];

            return null;
        }

        //Display All:
        public void DisplayAll() 
        { 
            for (int i = 0; i < MyList.Count ; i++)
            {
                Patient curPatient = (Patient)MyList[i];
                WriteLine("Position {0}: ", i + 1);
                curPatient.Display();
                
            }
        }

        //Display Above:
        public void DispAbove()
        {
            WriteLine("Enter the minimum amount: ");
            double amt = double.Parse(ReadLine());

            for (int i = 0; i < MyList.Count ; i++)
            {
                Patient curPatient = (Patient)MyList[i];
                if (!curPatient.isAbove(amt))
                {
                    WriteLine("Position {0}: ", i + 1);
                    curPatient.Display();
                    
                }

            }
        }

        //Display Single:
        public void DispSelect()
        {
            WriteLine("Enter the patient number: ");
            int pNum = int.Parse(ReadLine());
            if (Find(pNum) > -1)
            {
                Patient curr = (Patient)MyList[Find(pNum)];
                WriteLine("Position {0}: ", Find(pNum) + 1);
                curr.Display();
            }
            else
                WriteLine("Patient could not be found...");
        }
        //ReadData:
        public void ReadData()
        {
            StreamReader SR = new StreamReader(filename);
            string Line, surname, initials;
            string[] strings;
            int pNum;
            double balance;

            Line = SR.ReadLine();
            while (Line != null)
            {
                strings = Line.Split(DELIM);
                pNum = int.Parse(strings[0]);
                surname = strings[1];
                initials = strings[2];
                balance = double.Parse(strings[3]);
                Patient newOne = new Patient(pNum,surname,initials,balance);
                MyList.Add(newOne);
                Line = SR.ReadLine();
            }
            SR.Close();
        }

        //WriteData:
        public void WriteData() 
        {
            StreamWriter wr = new StreamWriter("Data.txt");
            for (int i = 0; i < MyList.Count; i++)
            {
                Patient curr = (Patient)MyList[i];
                wr.Write(curr.getNum()+",");
                wr.Write(curr.getSurname()+",");
                wr.Write(curr.getInitials()+",");
                wr.WriteLine(curr.getBalance());

            }
            wr.Close();
        }

        //Close:
        public void Close()
        {
            WriteData();
        }
    } 
}

