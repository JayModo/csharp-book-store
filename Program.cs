using System;
using book_store.Models;

namespace book_store
{
  class Program
  {
    static void Main(string[] args)
    {
      Book book = new Book();
      Book hatchet = new Book("Hatchet", "Gary Paulsen");
      Book gb = new Book("Great Gatsby", "Gary Paulsen");
      Book mm = new Book("Mice of men", "Gary Paulsen");
      Console.WriteLine("Hello World!");

    }

  }
}
