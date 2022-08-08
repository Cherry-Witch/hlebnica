using System;
using System.Collections.Generic;
using oop1.Library;

namespace oop1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random pages = new Random();

            Book bookOne = new Book("Хлебный Остров", "Хлебович Х.Х.", pages.Next(80, 1000), false);
            Book bookTwo = new Book("Хлебная Миля", "Хлебович Х.Х.", pages.Next(80, 1000), false);
            Book bookThree = new Book("Весенний лес", "Пенькович М.С.", pages.Next(80, 1000), false);
            Book bookFour = new Book("Зимний барабан", "Лерой Р.Т.", pages.Next(80, 1000), false);
            Book bookFive = new Book("Пикник за школой", "Тиджей А.С.", pages.Next(80, 1000), false);
            Book bookSix = new Book("Домашний кот", "Некоарк Г.Н.", pages.Next(80, 1000), false);
            Book bookSeven = new Book("Крутящее общество", "Бериевский Н.Н.", pages.Next(80, 1000), true);

            Shelf shelfOne = new Shelf(1);
            shelfOne.Books.AddRange(new List<Book> {bookOne, bookTwo});

            Shelf shelfTwo = new Shelf(2);
            shelfTwo.Books.AddRange(new List<Book> {bookThree, bookFour, bookFive, bookSix, bookSeven});

            BookLibrary bookLibrary = new BookLibrary();
            bookLibrary.Shelfs.AddRange(new List<Shelf> {shelfOne, shelfTwo});

            shelfOne.PrintBooks();
            shelfTwo.PrintBooks();
            bookLibrary.ShelfsInLibrary();
            
            bool work = true;

            while (work)
            {
                string input = Console.ReadLine();

                int output;

                if (int.TryParse(input, out output))
                {
                    shelfOne.Books[output].PrintInfo();
                }
                else
                {
                    Console.WriteLine("Введите корректное число.");
                }

                work = input == "stop";


                Console.WriteLine("Привет мир!");
            }

        }
    }
}
