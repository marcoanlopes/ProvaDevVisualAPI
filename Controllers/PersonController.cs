using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProvaDevVisualAPI.Data;
using ProvaDevVisualAPI.Models;

namespace ProvaDevVisualAPI.Controllers
{

        [ApiController]
        [Route("api/person")]

        public class PersonController : ControllerBase
        {
            private readonly DataContext _context;

            public PersonController(DataContext context){
                _context = context;
            }

            [HttpPost]
            [Route("create")]
            public IActionResult Create(Person person){
                _context.Person.Add(person);
                _context.SaveChanges();
                return Created("Objeto Criado!", person);
            }

            [HttpGet]
            [Route("list")]
            public IActionResult List() => Ok(_context.Person.ToList());

        }
    
}