using System;
using System.Collections.Generic;
using System.Text;

namespace oop1.Library
{
    class BookLibrary
    {
        public List<Shelf> Shelfs;

        public int ShelfCount => Shelfs.Count;

        public BookLibrary()
        {
            Shelfs = new List<Shelf>();
        }

        public void ShelfsInLibrary()
        {
            Console.WriteLine($"Книжных полок - {Shelfs.Count}");
        }
    }
}
