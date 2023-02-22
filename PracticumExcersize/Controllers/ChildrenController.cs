using _2_Services.Interfaces;
using _2_Services.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace _1_UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChildrenController : ControllerBase
    {
        private readonly IChildrenService childrenService;
        public ChildrenController(IChildrenService childrenService)
        {
            this.childrenService = childrenService;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<IEnumerable<ChildrenModel>> Get()
        {
            return await childrenService.GetAllAsync();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChildrenModel>> Get(int id)
        {
            var child = await childrenService.GetByIdAsync(id);
            if (child is null)
            {
                return NotFound();
            }
            return child;
        }

        // POST api/<ValuesController>
        [HttpPost]
        public async Task<ActionResult<ChildrenModel>> Post([FromBody] ChildrenModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return await childrenService.AddAsync(new ChildrenModel()
            {

                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                IdNumber = model.IdNumber,
                DateOfBirth=model.DateOfBirth
            });
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await childrenService.DeleteAsync(id);
        }
    }
}
