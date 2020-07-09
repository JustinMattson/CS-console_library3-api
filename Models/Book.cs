using System;
using System.ComponentModel.DataAnnotations;

namespace console_library3.Models
{
  public class Book
  {
    public string Id { get; set; }

    [Required]
    public string Title { get; set; }

    [Required]
    public string Author { get; set; }

    public bool Available { get; set; }

    public Book(string title, string author)
    {
      Id = Guid.NewGuid().ToString();
      Title = title;
      Author = author;
      Available = true;
    }

    public Book()
    {
      Id = Guid.NewGuid().ToString();
    }
  }
}