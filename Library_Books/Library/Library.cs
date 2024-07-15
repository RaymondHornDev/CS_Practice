using System;
using static System.Console;

namespace Main{
    class Library{
        public List<Book>? books;
        public int bookCount;

        public Book? highlightedBook;

        public Library(){
            books = new List<Book>();
            bookCount = 0;
            highlightedBook = null;
        }

        public void ViewBook(Book book){
            WriteLine($"The book's author is: {book.Author}");
            WriteLine($"The book's title is: {book.Title}");
            WriteLine($"The book has {book.Pages} pages");
            WriteLine("\n\n");
        }

        public void AddBook(Book passedBook){
            if(passedBook != null){
                books.Add(passedBook);
            }
        }

        public Book RemoveBook(){
            Book? retBook = null;
            if (books.Count > 0) { 
                retBook = books[0];
                this.books.RemoveAt(0);
            }
            return retBook;
        }
    }
}