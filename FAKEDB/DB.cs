using System.Collections.Generic;
using console_library3.Models;

namespace console_library3.FAKEDB
{
  public static class FakeDb
  {
    public static List<Book> Books { get; set; } = new List<Book>()
    {
      new Book("The Hobbit", "J.R.R. Tolkien"),
      new Book("Where the Sidewalk Ends", "Shel Silverstein"),
      new Book("The Lion, The Witch, and the Wardrobe", "C.S. Lewis"),
      new Book("Harry Potter and the Sorcerer's Stone", "J.K. Rowling")
    };
  }
}

