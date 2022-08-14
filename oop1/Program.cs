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

            BookLibrary bookLibrary = new BookLibrary("Ул. Пушкина, Дом Колотушкина");
            bookLibrary.Name = "Хлебная Библеотека";
            bookLibrary.Shelfs.AddRange(new List<Shelf> {shelfOne, shelfTwo});

            List<IPrintble> printble = new List<IPrintble>
            {
                shelfOne,shelfTwo,bookLibrary
            };

            for (int i = 0; i < printble.Count; i++)
            {
                printble[i].PrintInfo();
            }
            
            bool work = true;

            while (work)
            {
                Console.Write("Введите номер шкафа: ");
                string input = Console.ReadLine();

                int output;

                if (int.TryParse(input, out output))
                {
                    if (output < bookLibrary.ShelfCount)
                    {
                        Shelf currentShelf = bookLibrary.Shelfs[output];
                        currentShelf.PrintInfo();
                        Console.Write("Введите номер книги: ");
                        input = Console.ReadLine();
                        if (int.TryParse(input, out output))
                        {
                            if (output < currentShelf.BooksCount)
                            {
                                Book currentBook = currentShelf.Books[output];
                                currentBook.PrintInfo();
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine("Ну нет такой книги с таким номером!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Нужно ввести число.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Нет полки с таким номером.");
                    }
                }
                else
                {
                    Console.WriteLine("Нужно ввести число.");
                }

                work = input != "stop";
            }

        }
    }
}
