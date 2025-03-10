using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Net;

namespace Library
{
    internal class LibraryCatalog
    {
        ArrayList BookList;
        int sortedState = 0;

        public LibraryCatalog()
        {
            BookList = new ArrayList();
            ReadData();
        }
        public void Close()
        {
            WriteData();
        }
        public void AddOne(Book newOne)
        {
            BookList.Add(newOne);
            sortedState = 0;
        }
        public void DeleteOne(int wanted)
        {
            BookList.RemoveAt(wanted-1);
        }
        public void DisplayAll()
        {
            for(int x = 0; x < BookList.Count; x++)
            {
                Book currone = (Book)BookList[x];
                currone.DisplayBook();
            }
        }
        public int BinarySearch(int wanted)
        {
            int first = 0;
            int last = BookList.Count - 1;
            while (first <= last)
            {
                int midpoint = (first + last) / 2;
                Book currOne = (Book)BookList[midpoint];
                if (currOne.GetIsbn() == wanted)
                    return midpoint;
                else if (currOne.GetIsbn() < 0)
                    last = midpoint - 1;
                else
                    first = midpoint + 1;
            }
            return -1;
        }
        public int Lineearsearch(int wanted)
        {
            int pos = -1;
            for(int x = 0; x < BookList.Count; x++)
            {
                Book currOne = (Book)BookList[x];
                if (currOne.GetIsbn() == wanted)
                {
                    pos = x;
                }
            }
            return pos;
        }
        public Book GetBook(int pos)
        {
            pos--;
            if (pos >= 0 && pos < BookList.Count)
                return (Book)BookList[pos];
            else
                return null;
        }
        public int FindBook(int wanted)
        {
            if (sortedState == 1)
            {
                Console.WriteLine("Using binary search");
                return BinarySearch(wanted) + 1;
            }
            else
            {
                Console.WriteLine("Using linear search");
                return Lineearsearch(wanted) + 1;
            }
        }
        public void ReadData()
        {
            string[] fields;
            string inputline;
            int isbn;
            String title;
            String author;
            int publicationYear;
            const char DELIM = ',';
            StreamReader reader = new StreamReader("BookData.txt");
            inputline = reader.ReadLine();
            while (inputline != null)
            {
                fields = inputline.Split(DELIM);
                isbn = int.Parse(fields[0]);
                title = fields[1];
                author = fields[2];
                publicationYear = int.Parse(fields[3]);
                Book newOne = new Book(isbn, title, author, publicationYear);
                BookList.Add(newOne);
                inputline = reader.ReadLine();
            }
            reader.Close();
        }
        public void WriteData()
        {
            StreamWriter writer = new StreamWriter("OutComes.txt");
            for(int x = 0; x < BookList.Count; x++)
            {
                Book currOne = (Book)BookList[x];
                writer.Write(currOne.GetIsbn() + ",");
                writer.Write(currOne.GetTitle() + ",");
                writer.Write(currOne.GetAuthor() + ",");
                writer.WriteLine(currOne.GetPubYear());
            }
            writer.Close();
        }
        public void InsertionSort()
        {
            for(int pass = 1; pass < BookList.Count; pass++)
            {
                Book newOne = (Book)BookList[pass];
                int currPos = pass - 1;
                Book currOne = (Book)BookList[currPos];
                while (currPos != -1 && newOne.GetPubYear() < currOne.GetPubYear())
                {
                    currPos--;
                    if (currPos != -1)
                    {
                        currOne = (Book)BookList[currPos];
                    }
                }
                BookList.RemoveAt(pass);
                BookList.Insert(currPos + 1, newOne);
            }
        }
        public void BubbleSortISBN()
        {
            for (int pass = 1; pass < BookList.Count; pass++)
            {
                for (int compare = 1; compare <= BookList.Count - pass; compare++)
                {
                    Book first = (Book)BookList[compare - 1];
                    Book second = (Book)BookList[compare];
                    if (first.GetIsbn() > second.GetIsbn())
                        swop(compare - 1, compare);
                }
            }
        }
        public void SelectionSortAuthor()
        {
            int minPos = 0;
            for (int pass = 1; pass < BookList.Count; pass++)
            {
                for (int compare = pass; compare < BookList.Count; compare++)
                {
                    Book first = (Book)BookList[compare ];
                    Book second = (Book)BookList[minPos];
                    if (first.GetAuthor().CompareTo(second.GetAuthor()) < 0)
                        minPos = compare;
                }
                swop(pass - 1, minPos);
                minPos = pass;
            }
        }
        private void swop(int swop1,int swop2)
        {
            Book currOne = (Book)BookList[swop2];
            BookList[swop2] = BookList[swop1];
            BookList[swop1] = currOne;
        }
        public void AscInsertionSort()
        {
            InsertionSort();
            sortedState = 3;
        }
        public void AscBubbleSort()
        {
            BubbleSortISBN();
            sortedState = 1;
        }
        public void AscSelectionSort()
        {
            SelectionSortAuthor();
            sortedState = 2;
        }
    }
}
