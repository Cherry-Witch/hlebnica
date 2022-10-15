using System;
using System.Collections.Generic;
using System.Text;

namespace oop1.Library
{
    public class Library : IPrintble
    {
        private string _address;

        public string Name;
        public List<Shelf> Shelfs;

        public string Address => _address;

        public int ShelfCount => Shelfs.Count;

        public Library(string address)
        {
            _address = address;
            Shelfs = new List<Shelf>();
        }

        private Library()
        {

        }

        public void PrintInfo()
        {
            Console.WriteLine($"Адрес библеотеки - {Address}");
            Console.WriteLine($"Название библеотеки - {Name}");
            Console.WriteLine($"Книжных полок - {Shelfs.Count}");
        }
    }
}
