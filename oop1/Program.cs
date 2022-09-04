using System;
using System.Collections.Generic;
using oop1.Library;

namespace oop1
{
    class Program
    {
        static void Main(string[] args)
        {
            Library.Library bookLibrary = LibraryParser.LoadLibrary();

            bool work = true;

            while (work)
            {
                int output;

                Console.Write("Поиск книги ручной или по названию? [0|1]: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out output))
                {
                    if (output == 0)
                    {
                        Console.Write("Введите номер шкафа: ");
                        input = Console.ReadLine();

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
                    }
                    else if (output == 1)
                    {
                        Console.WriteLine("[Поиск книги по названию.]");
                    }
                    else
                    {
                        Console.WriteLine("Введите однин из вариантов: 0 или 1.");
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
