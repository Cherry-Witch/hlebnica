using System;
using System.Collections.Generic;
using System.Text;

namespace oop1.Library
{
    class Shelf : IPrintble
    {
        public int Number;
        public List<Book> Books;

        public int BooksCount => Books.Count;

        public Shelf(int number)
        {
            Books = new List<Book>();
            Number = number;
        }

        public void PrintInfo()
        {
            Console.Write($"Шкаф № {Number} — ");
            foreach (var book in Books)
            {
                Console.Write($"{book.Name} | ");
            }

            Console.Write($"Кол-во книг: {BooksCount}");
            Console.WriteLine();
        }
    }
}
