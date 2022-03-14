using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using RESTBooksForCD.Managers;
using RESTBooksForCD.Models;

namespace RESTBooksForCD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BooksManager _manager = new BooksManager();

        // GET: api/<BooksController>
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return _manager.GetAll();
        }

        // GET api/<BooksController>/5
        [HttpGet("{id}")]
        public Book Get(int id)
        {
            return _manager.GetById(id);
        }

        // POST api/<BooksController>
        /*[HttpPost]
        public Book Post([FromBody] Book value)
        {
            return _manager.Add(value);
        }*/

        // DELETE api/<BooksController>/5
        /*[HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/

        // PUT api/<BooksController>/5
        /*[HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }*/


    }
}
