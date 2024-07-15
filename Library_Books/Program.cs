using System;

namespace Main{
    class Program {

        static void Main(){
            Library lib = new Library();

            Fill(GlobalStorage.myArr, lib, 0);
            Empty(lib);
        }

        static void Fill(string[,] info, Library passLib, int iter){
            if(iter < info.GetLength(0)){
                passLib.AddBook(new Book(info[iter, 0], info[iter, 1], Convert.ToInt32(info[iter, 2])));
                Fill(info, passLib, iter + 1);
            }
        }

        static void Empty(Library passedLib){
            Book retBook;
            if(passedLib.books.Count() > 0){
                retBook = passedLib.RemoveBook(0);
                passedLib.ViewBook(retBook);
                Empty(passedLib);
            }
        }
    }
}