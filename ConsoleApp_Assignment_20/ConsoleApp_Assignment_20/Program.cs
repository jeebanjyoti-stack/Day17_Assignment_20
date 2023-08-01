using System;
using ClassLibrary_Assignment_20;

namespace ConsoleApp_Assignment_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookCollection bookCollection = new BookCollection();



            while (true)
            {
                Console.WriteLine("\n----- Library Management System -----");
                Console.WriteLine("1. Add a book");
                Console.WriteLine("2. View all books");
                Console.WriteLine("3. Search by ID");
                Console.WriteLine("4. Search by title");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice (1-5): ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Book obj = new Book();
                            Console.WriteLine("\nEnter book details:");
                            Console.Write("Book ID: ");
                            int bookId = int.Parse(Console.ReadLine());
                            Console.Write("Title: ");
                            string title = Console.ReadLine();
                            Console.Write("Author: ");
                            string author = Console.ReadLine();
                            Console.Write("Genre: ");
                            string genre = Console.ReadLine();
                            bookCollection.AddBook(obj);
                            Console.WriteLine("Book added successfully.");
                            break;
                        case 2:
                            Console.WriteLine("\n--- All Books ---");
                            bookCollection.ViewAllBooks();
                            break;
                        case 3:
                            Console.Write("\nEnter Book ID to search: ");
                            if (int.TryParse(Console.ReadLine(), out int searchById))
                            {
                                bookCollection.SearchBookById(searchById);
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid Book ID.");
                            }
                            break;
                        case 4:
                            Console.Write("\nEnter Title to search: ");
                            string searchByTitle = Console.ReadLine();
                            bookCollection.SearchBookByTitle(searchByTitle);
                            break;
                        case 5:
                            Console.WriteLine("Exiting the program.");
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please enter a valid option (1-5).");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter a valid option (1-5).");
                }
                Console.ReadKey();
            }


        }
    }
}
