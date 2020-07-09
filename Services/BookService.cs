using System;
using System.Collections.Generic;
using console_library3.FAKEDB;
using console_library3.Models;

namespace console_library3.Services
{
  public class BookService
  {
    internal Book Create(Book newBook)
    {
      FakeDb.Books.Add(newBook);
      return newBook;
    }
    internal IEnumerable<Book> Get()
    {
      return FakeDb.Books;
    }

    internal Book GetById(string id)
    {
      var found = FakeDb.Books.Find(b => b.Id == id);
      if (found == null)
      {
        throw new Exception("Invalid Id");
      }
      return found;
    }

    internal Book Edit(Book editBook, string id)
    {
      var original = FakeDb.Books.Find(b => b.Id == id);
      if (original == null)
      {
        throw new Exception("Invalid Id");
      }
      editBook.Id = original.Id;
      editBook.Title = editBook.Title != null ? editBook.Title : original.Title;
      editBook.Author = editBook.Author != null ? editBook.Author : original.Author;
      editBook.Available = editBook.Available != true ? editBook.Available : !editBook.Available;
      FakeDb.Books.Remove(original);
      FakeDb.Books.Add(editBook);
      return editBook;
    }
    internal Book Delete(string bookId)
    {
      var found = FakeDb.Books.Find(b => b.Id == bookId);
      if (found == null)
      {
        throw new Exception("Invalid Id");
      }
      FakeDb.Books.Remove(found);
      return found;
    }
  }
}