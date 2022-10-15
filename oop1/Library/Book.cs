using System;
using System.Collections.Generic;
using System.Text;

namespace oop1.Library
{
    public class Book : IPrintble
    {
        public string Name;
        public string Author;
        public int Pages;
        public bool Locked;

        private Book()
        {

        }

        public Book(string name, string author, int pages, bool locked)
        {
            Name = name;
            Author = author;
            Pages = pages;
            Locked = locked;
        }

        public void PrintInfo()
        {
            if (Locked)
            {
                Console.WriteLine("Книга недоступна.");
                return;
            }

            Console.WriteLine($"[{Name}] | [{Author}] | [{Pages}]");
        }
    }
}
