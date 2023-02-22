using _2_Services.Interfaces;
using _2_Services.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace _1_UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonalDetailsController : ControllerBase
    {
        private readonly IPersonalDetailsService personalDetailsService;

        public PersonalDetailsController(IPersonalDetailsService personalDetailsService)
        {
            this.personalDetailsService = personalDetailsService;
        }


        // GET: api/<PersonalDetailsController>
        [HttpGet]
        public async Task<IEnumerable<PersonalDetailModel>> Get()
        {
            return await personalDetailsService.GetAllAsync();
        }

        // GET api/<PersonalDetailsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PersonalDetailModel>> Get(int id)
        {
            var personalDetails = await personalDetailsService.GetByIdAsync(id);
            if (personalDetails is null)
            {
                return NotFound();
            }
            return personalDetails;
        }


        // POST api/<PersonalDetailsController>
        [HttpPost]
        public async Task<ActionResult<PersonalDetailModel>> Post([FromBody] PersonalDetailModel model)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return await personalDetailsService.AddAsync(new PersonalDetailModel()
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                IdNumber=model.IdNumber,
                DateOfBirth = model.DateOfBirth,
                Gender = model.Gender,
                HMO = model.HMO,
                Childrens = model.Childrens,
            });

        }


        // PUT api/<PersonalDetailsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PersonalDetailsController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await personalDetailsService.DeleteAsync(id);
        }
    }
}
