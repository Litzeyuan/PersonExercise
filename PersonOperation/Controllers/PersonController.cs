using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonOperation.Data;
using PersonOperation.Interfaces;
using PersonOperation.Models;
using PersonOperation.Services;

namespace PersonOperation.Controllers
{
    [Route("api/person")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly PersonDBContext _context;
        private readonly IAddPersonService addPersonService;
        private readonly IUpdatePersonService updatePersonService;
        private readonly IDeletePersonService deletePersonService;
        private readonly ICountePersonsService countePersonsService;
        private readonly IGetPersonsService getPersonsService;

        public PersonController(PersonDBContext context,
            IAddPersonService addPersonService,
            IUpdatePersonService updatePersonService,
            IDeletePersonService deletePersonService,
            ICountePersonsService countePersonsService,
            IGetPersonsService getPersonsService)
        {
            _context = context;
            this.addPersonService = addPersonService;
            this.updatePersonService = updatePersonService;
            this.deletePersonService = deletePersonService;
            this.countePersonsService = countePersonsService;
            this.getPersonsService = getPersonsService;
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> AddPerson(Person person)
        {
            return await addPersonService.Execute(_context, person);
        }
        
        [HttpPut("edit")]
        public async Task<IActionResult> UpdatePerson(Person person)
        {
            return await updatePersonService.Execute(_context, person);
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeletePersonById(long id)
        {
            return await deletePersonService.Execute(_context, id);
        }

        [HttpGet]
        [Route("countAll")]
        public async Task<ActionResult<PersonCount>> GetPersonsCount()
        {
            return await countePersonsService.Execute(_context);
        }

        [HttpGet]
        [Route("getAll")]
        public async Task<ActionResult<IEnumerable<Person>>> GetPersons()
        {
            return await getPersonsService.Execute(_context);
        }
    }
}
