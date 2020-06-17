using Microsoft.AspNetCore.Mvc;
using PersonOperation.Data;
using PersonOperation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonOperation.Services
{
    public class DeletePersonService : IDeletePersonService
    {
        public async Task<IActionResult> Execute(PersonDBContext _context, long id)
        {
            var person = await _context.Person.FindAsync(id);
            if (person == null)
            {
                return new NotFoundResult();
            }

            _context.Person.Remove(person);
            await _context.SaveChangesAsync();

            return new NoContentResult();
        }
    }
}
