using Microsoft.AspNetCore.Mvc;
using PersonOperation.Data;
using PersonOperation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonOperation.Services
{

    public class AddPersonService : IAddPersonService
    {
        public async Task<IActionResult> Execute(PersonDBContext _context, Person person)
        {
            _context.Person.Add(person);
            await _context.SaveChangesAsync();
            return new NoContentResult();
        } 
    }
}
