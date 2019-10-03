using System;
using System.Collections.Generic;
namespace book_store.Models
{

  class Library
  {
    public string Name { get; set; }
    public string Address { get; set; }

    public Library(string name, string address)
    {
      Name = name;
      Address = address;
    }
    private List<Book> Books { get; set; }


    public void PrintBooks()
    {
      for (int i = 0; i < Books.Count; i++)
      {
        Console.WriteLine($"{i + 1} {Books[i].Title} - {Books[i].Author}");
      }
    }
    public void AddBook(Book book)
    {
      Books.Add(book);
    }

  }
}

