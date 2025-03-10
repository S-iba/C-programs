using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks;
using static System.Console;
namespace P7T1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            PatientList myPatients = new PatientList("Data.txt");

            int choice = -1;

            while (choice != 6)
            {
                DispOptions(myPatients);
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        myPatients.Add();
                        break;
                    case 2:
                        WriteLine("Enter the position: ");
                        int pos = int.Parse(Console.ReadLine());    
                        myPatients.Delete(pos);
                        break;
                    case 3:
                        myPatients.DispSelect();
                        break;
                    case 4:
                        myPatients.DispAbove();
                        break;
                    case 5:
                        myPatients.DisplayAll();
                        break;
                    case 6:
                        myPatients.Close();
                        WriteLine("Thank you Goodbye :0");
                        break;
                    default:
                        WriteLine("Enter a valid choice");
                        DispOptions(myPatients);
                        break;

                }
            }
        }

        static void DispOptions(PatientList p)
        {
            WriteLine("Choose one of the following options: ");
            WriteLine("NB: Number of Patients is >>> {0}",p.Count);
            WriteLine("1. Add a new patient");
            WriteLine("2. Delete a patient");
            WriteLine("3. Display patient details");
            WriteLine("4. Display records with outstanding balance above...");
            WriteLine("5. Display all patients");
            WriteLine("6. Save data and quit");
            WriteLine("Choice >>>");
        }

    }
}
