﻿using System;
using System.Collections.Generic;
using oop1.Library;

namespace oop1
{
    class Program
    {
        static Book ManualSearch(Library.Library bookLibrary)
        {
            int output;
            string input;

            Console.Write("Введите номер шкафа: ");
            input = Console.ReadLine();

            if (!int.TryParse(input, out output))
            {
                Console.WriteLine("Нужно ввести число!");
                return null;
            }

            if (output >= bookLibrary.ShelfCount)
            {
                Console.WriteLine("Не найден шкаф с таким номером!");
                return null;
            }

            Shelf currentShelf = bookLibrary.Shelfs[output];
            currentShelf.PrintInfo();
            Console.Write("Введите номер книги: ");
            input = Console.ReadLine();

            if (!int.TryParse(input, out output))
            {
                Console.WriteLine("Нужно ввести число!");
                return null;
            }

            if (output >= currentShelf.BooksCount)
            {
                Console.WriteLine("Не найдено нигги с таким номером!");
                return null;
            }

            return currentShelf.Books[output];
        }

        static Book SearchByName(Library.Library library)
        {
            Console.Write("Введите название книги: ");
            string bookName = Console.ReadLine();

            foreach (var shelf in library.Shelfs)
            {
                foreach (var book in shelf.Books)
                {
                    if (book.Name.ToLower().IndexOf(bookName) >= 0)
                    {
                        return book;
                    }
                }
            }

            return null;
        }

        static void Main(string[] args)
        {
            Library.Library bookLibrary = LibraryParser.LoadLibrary();

            bool work = true;
            Book selectedBook;

            while (work)
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "autosearch":
                        selectedBook = SearchByName(bookLibrary);
                        if (selectedBook != null)
                        {
                            selectedBook.PrintInfo();
                        }

                        break;
                    case "search":
                        selectedBook = ManualSearch(bookLibrary);
                        if (selectedBook != null)
                        {
                            selectedBook.PrintInfo();
                        }

                        break;
                    case "stop":
                        work = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
