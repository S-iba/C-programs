using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LibraryCatalog catalogue = new LibraryCatalog();

            DisplayOptions();
            int choice = int.Parse(ReadLine());
            ProcessOption(catalogue, choice);
            while (choice != 8)
            {
                DisplayOptions();
                choice = int.Parse(ReadLine());
                ProcessOption(catalogue, choice);
            }
            ReadLine();
        }

        static void DisplayOptions()
        {
            WriteLine("Choose one of the following options: ");
            WriteLine("1. Add a new book");
            WriteLine("2. Delete a book");
            WriteLine("3. Display book details");
            WriteLine("4. List all books");
            WriteLine("5. Sort catalogue in ascending order of ISBN number, then display list");
            WriteLine("6. Sort catalogue in ascending order of Author then display list");
            WriteLine("7. Sort catalogue in ascending order of publication year, then display list");
            WriteLine("8. Save data and quit");
            Write("Choice: ");
        }

        static void ProcessOption(LibraryCatalog catalogue, int choice)
        {
            WriteLine();

            switch (choice)
            {
                case 1:
                    AddBook(catalogue);
                    WriteLine();
                    break;
                case 2:
                    DeleteBook(catalogue);
                    WriteLine();
                    break;
                case 3:
                    DisplayBookDetail(catalogue);
                    WriteLine();
                    break;
                case 4:
                    catalogue.DisplayAll();
                    WriteLine();
                    break;
                case 5:
                    catalogue.AscBubbleSort();
                    catalogue.DisplayAll();
                    WriteLine();
                    break;
                case 6:
                    catalogue.AscSelectionSort();
                    catalogue.DisplayAll();
                    WriteLine();
                    break;
                case 7:
                    catalogue.AscInsertionSort();
                    catalogue.DisplayAll();
                    WriteLine();
                    break;
                default:
                    WriteLine("Goodbye, the data will now be written to the text file");
                    catalogue.WriteData();
                    break;
            }
        }
        static void AddBook(LibraryCatalog catalogue)
        {
            Console.Write("Enter the isbn number: ");
            int isbn = int.Parse(Console.ReadLine());
            Write("Enter the book title: ");
            string title = Console.ReadLine();
            Write("Enter the author of the book: ");
            string author = Console.ReadLine();
            Write("Enter the publication year: ");
            int publicationYear = int.Parse(Console.ReadLine());
            Book newOne = new Book(isbn, title, author, publicationYear);
            catalogue.AddOne(newOne);
            WriteLine("The book was added to the collections");
        }

        static void DeleteBook(LibraryCatalog catalogue)
        {
            Write("Enter the isbn number of the book you want to delete: ");
            int isbn = int.Parse(ReadLine());
            int pos = catalogue.FindBook(isbn);
            if (pos ==0)
            {
                Console.WriteLine("The book was not found");
            }
            else
            {
                catalogue.DeleteOne(pos);
                Console.WriteLine("The book was deleted");
            }
        }
        static void DisplayBookDetail(LibraryCatalog catalogue)
        {
            Write("Enter the isbn number of the book you want to display: ");
            int isbn = int.Parse(ReadLine());
            int pos = catalogue.FindBook(isbn);
            if (pos == 0)
            {
                Console.WriteLine("the book was not found");
            }
            else
            {
                Book currOne = catalogue.GetBook(pos);
                currOne.DisplayBook();
            }
        }
    }
}
