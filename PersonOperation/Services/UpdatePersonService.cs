using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonOperation.Data;
using PersonOperation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonOperation.Services
{
    public class UpdatePersonService : IUpdatePersonService
    {
        public async Task<IActionResult> Execute(PersonDBContext _context, Person person)
        {
            _context.Entry(person).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (! _context.Person.Any(e => e.Id == person.Id))
                {
                    return new NotFoundResult();
                }
                else
                {
                    throw;
                }
            }
            return new NoContentResult();
        }
    }
}
