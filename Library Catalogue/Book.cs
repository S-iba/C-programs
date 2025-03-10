using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Book
    {
        int isbn;
        String title;
        String author;
        int publicationYear;

        public Book(int isbn, String title, String author, int publicationYear) 
        { 
            this.isbn = isbn;
            this.title = title;
            this.author = author;
            this.publicationYear = publicationYear;
        }
        public int GetIsbn()
        {
            return isbn;
        }
        public string GetTitle()
        {
            return title;
        }
        public string GetAuthor()
        {
            return author;
        }
        public int GetPubYear()
        {
            return publicationYear;
        }
        public void SetIsbn(int isbn)
        {
            this.isbn = isbn;
        }
        public void SetTitle(string title)
        {
            this.title = title;
        }
        public void SetAuthor(string author)
        {
            this.author = author;
        }
        public void SetPubYear(int publicationYear)
        {
            this.publicationYear = publicationYear;    
        }
        public void DisplayBook()
        {
            Console.WriteLine("{0}, {1}, {2}, {3}", isbn, title, author, publicationYear);
        }
    }
}
