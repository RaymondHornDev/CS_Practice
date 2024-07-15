using System;

namespace Main{
    class Book{
        public string? Title{get; private set;}
        public string? Author{ get; private set; }
        public int Pages{ get; private set; }
        private int currentPage;
        public int CurrentPage{
            get{
                return currentPage;
                }
            set { 
                if (value > 0 && value < Pages)
                currentPage = value;
            }
        }

        public Book(){
            Title = null;
            Author = null;
            Pages = 0;
            currentPage = 0;
        }

        public Book(string author, string title, int pages){
            Author = author;
            Title = title;
            Pages = pages;
            currentPage = 0;
        }
    }
}