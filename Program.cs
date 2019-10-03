using System;
using System.Collections.Generic;
using bookfair.Models;

namespace bookfair
{
  class Program
  {
    static void Main(string[] args)
    {

      Console.WriteLine("Welcome to the Library");
      Book LotR = new Book("Lord of The Rings", "Frodo Baggins");
      Book CitH = new Book("Cat In The Hat", "Cat Man");
      Book Swtor = new Book("Star Wars The Old Republic", "Jabba The Hut");
      Book BCW = new Book("Coding for Dummies", "Mark Ohnsman");

      Library lib = new Library("Boise", "yup");

      lib.AddBook(LotR);
      lib.AddBook(CitH);
      lib.AddBook(Swtor);
      lib.AddBook(BCW);

      lib.PrintBooks();

      // Books.AddRange(new Book[] { LotR, CitH, Swtor, BCW
      //   });

    }
  }
}
