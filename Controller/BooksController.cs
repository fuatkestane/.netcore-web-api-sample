using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using NetCoreWebApi.DataSource;

namespace NetCoreWebApi
{
    [Route("api/books")]
    public class BooksController : Controller
    {
        [HttpGet()]
        public IActionResult GetCategories()
        {
            return Ok(ApiDataSource.Current.categories);
        }

        [HttpGet("{Id}")]
        public IActionResult GetCategory(int Id)
        {
            var data = ApiDataSource.Current.categories.FirstOrDefault(c => c.Id == Id);

            if (data == null)
            {
                return NotFound();
            }
            return Ok(data);
        }

        [HttpGet("author/{Name}")]
        public IActionResult GetAuthors(string Name)
        {
            var data = ApiDataSource.Current.categories.
            SelectMany(b => b.booksOfInterest.
            Select(i => new { i.Id, i.Name, i.Author }).
            Where(a => a.Author == Name)).ToList();

            if (data == null)
            {
                return NotFound();
            }
            return Ok(data);
        }
    }
}