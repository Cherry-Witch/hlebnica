﻿using System;
using System.Collections.Generic;
using System.Text;

namespace oop1.Library
{
    class Book
    {
        public string Name;
        public string Author;
        public int Pages;
        public bool Locked;

        public Book(string name, string author, int pages, bool locked)
        {
            Name = name;
            Author = author;
            Pages = pages;
            Locked = locked;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"[{Name}] | [{Author}] | [{Pages}] | [{Locked}]");
        }
    }
}