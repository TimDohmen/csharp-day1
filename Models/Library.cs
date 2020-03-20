using System;
using System.Collections.Generic;

namespace bookfair.Models
{
  public class Library
  {

    public string Location { get; set; }
    public string Name { get; set; }
    private List<Book> AvailableBooks { get; set; }
    private List<Book> checkedOut { get; set; }




    public void AddBook(Book book)
    {
      AvailableBooks.Add(book);
    }
    public void PrintBooks()
    {
      Console.WriteLine("Books Available");
      for (int i = 0; i < AvailableBooks.Count; i++)
      {
        Console.WriteLine($"{i + 1}. {AvailableBooks[i].Title} - {AvailableBooks[i].Author}");
      }
    }
    public void Checkout(string selection)
    {
      Book selectedBook = ValidateBook(selection, AvailableBooks);
      if (selectedBook == null)
      {
        Console.Clear();
        System.Console.WriteLine(@"Invalid Selection
                ");
        return;
      }
      int index = Int32.TryParse(selection, out bookIndex);

      if (index < checkedOut.Count)
      {
        Book book = checkedOut[index];
        selectedBook.Available = false;
        AvailableBooks.Remove(book);
        checkedOut.Add(book);
        System.Console.WriteLine($"You Gots a {selectedBook.Title}");
      }
    }
    private Book ValidateBook(string selection, List<Book> bookList)
    {
      int bookIndex = 0;
      bool valid = Int32.TryParse(selection, out bookIndex);
      if (!valid || bookIndex < 1 || bookIndex > bookList.Count)
      {
        return null;
      }
      return bookList[bookIndex - 1];
    }
    public Library(string location, string name)
    {
      Location = location;
      Name = name;
      AvailableBooks = new List<Book>();
      checkedOut = new List<Book>();

    }


  }
}