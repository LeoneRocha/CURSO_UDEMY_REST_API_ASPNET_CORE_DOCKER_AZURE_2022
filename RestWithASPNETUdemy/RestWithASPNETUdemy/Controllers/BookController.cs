using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Business;

namespace RestWithASPNETUdemy.Controllers
{

    [ApiVersion("1")]
    [ApiController]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class BookController : ControllerBase
    {

        private readonly ILogger<BookController> _logger;

        // Declaration of the service used
        private IBookBusiness _BookBusiness;

        // Injection of an instance of IBookService
        // when creating an instance of BookController
        public BookController(ILogger<BookController> logger, IBookBusiness BookBusiness)
        {
            _logger = logger;
            _BookBusiness = BookBusiness;
        }

        // Maps GET requests to https://localhost:{port}/api/Book
        // Get no parameters for FindAll -> Search All
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_BookBusiness.FindAll());
        }

        // Maps GET requests to https://localhost:{port}/api/Book/{id}
        // receiving an ID as in the Request Path
        // Get with parameters for FindById -> Search by ID
        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var Book = _BookBusiness.FindByID(id);
            if (Book == null) return NotFound();
            return Ok(Book);
        }

        // Maps POST requests to https://localhost:{port}/api/Book/
        // [FromBody] consumes the JSON object sent in the request body
        [HttpPost]
        public IActionResult Post([FromBody] Book Book)
        {
            if (Book == null) return BadRequest();
            return Ok(_BookBusiness.Create(Book));
        }

        // Maps PUT requests to https://localhost:{port}/api/Book/
        // [FromBody] consumes the JSON object sent in the request body
        [HttpPut]
        public IActionResult Put([FromBody] Book Book)
        {
            if (Book == null) return BadRequest();
            return Ok(_BookBusiness.Update(Book));
        }

        // Maps DELETE requests to https://localhost:{port}/api/Book/{id}
        // receiving an ID as in the Request Path
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _BookBusiness.Delete(id);
            return NoContent();
        }
    }
}
