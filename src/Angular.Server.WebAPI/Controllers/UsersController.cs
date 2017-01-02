﻿namespace Angular.Server.WebAPI.Controllers
{
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;

    using global::AutoMapper;
    using global::AutoMapper.QueryableExtensions;

    using Angular.Server.Models.DomainModels;
    using Angular.Server.Services.Abstractions;
    using Angular.Server.WebAPI.Models;

    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private IPersonService personService;

        private readonly IMapper mapper;

        public UsersController(IPersonService personService, IMapper mapper)
        {
            this.personService = personService;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {

            var personsModels = this.personService.All().ProjectTo<PersonViewModel>().ToList();

            if (personsModels == null)
            {
                return NotFound();
            }

            return Ok(personsModels);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var currentPerson = this.personService.All().FirstOrDefault(person => person.Id == id);

            if (currentPerson == null)
            {
                return NotFound();
            }

            var personModel = mapper.Map<Person, PersonViewModel>(currentPerson);

            return Ok(personModel);
        }

        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
