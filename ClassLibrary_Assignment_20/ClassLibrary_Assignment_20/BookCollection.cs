using System;
using System.Collections.Generic;

namespace ClassLibrary_Assignment_20
{
    public class BookCollection
    {
        static List<Book> books;
        public BookCollection()
        {
            books = new List<Book>()
            {
                new Book() {BookId=1,Title="The God of Small Things",Author="Arundhati Roy",Genre="Fiction",IsAvailable=true},
                new Book() {BookId=2,Title="Wings of Fire",Author="A.P.J. Abdul Kalam",Genre=" Autobiography",IsAvailable=true},
                new Book() {BookId=3,Title="1984",Author=" George Orwell",Genre="Science Fiction",IsAvailable=false},
                new Book() {BookId=4,Title="Harry Potter and the Sorcerer's Stone",Author=" J.K. Rowling",Genre="Fantasy",IsAvailable=true},
                new Book() {BookId=5,Title="The White Tiger",Author="Aravind Adiga",Genre="Fiction",IsAvailable=true},
            };
        }
        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void ViewAllBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books available in the library.");
                return;
            }

            foreach (var book in books)
            {
                Console.WriteLine($"Book ID: {book.BookId}, Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, Is Available: {(book.IsAvailable ? "Yes" : "No")}");
            }
        }
        public void SearchBookById(int bookId)
        {
            var book = books.Find(b => b.BookId == bookId);
            if (book != null)
            {
                Console.WriteLine($"Book ID: {book.BookId}, Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, Is Available: {(book.IsAvailable ? "Yes" : "No")}");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }
        public void SearchBookByTitle(string title)
        {
            var book = books.Find(b => b.Title.ToLower() == title.ToLower());
            if (book != null)
            {
                Console.WriteLine($"Book ID: {book.BookId}, Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, Is Available: {(book.IsAvailable ? "Yes" : "No")}");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }
    }
}
