using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using console_library3.Models;
using console_library3.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace console_library3.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class BooksController : ControllerBase
  {

    private readonly BookService _service;

    public BooksController(BookService service)
    {
      _service = service;
    }

    [HttpPost]
    public ActionResult<Book> Create([FromBody] Book newBook)
    {
      try
      {
        return Ok(_service.Create(newBook));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpGet]
    public ActionResult<IEnumerable<Book>> GetAll()
    {
      try
      {
        return Ok(_service.Get());
      }
      catch (Exception e)
      {
        return BadRequest(e);
      }
    }
    [HttpGet("available")]
    public ActionResult<IEnumerable<Book>> GetAvail()
    {
      try
      {
        return Ok(_service.Get());
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpGet("{id}")]
    public ActionResult<Book> GetById(string id)
    {
      try
      {
        return Ok(_service.GetById(id));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }


    [HttpPut("{id}")]
    public ActionResult<Book> Edit([FromBody] Book editBook, string id)
    {
      try
      {
        return Ok(_service.Edit(editBook, id));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpDelete("{bookId}")]
    public ActionResult<Book> Delete(string bookId)
    {
      try
      {
        return Ok(_service.Delete(bookId));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}
