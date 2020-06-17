using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonOperation.Data;
using PersonOperation.Interfaces;
using PersonOperation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonOperation.Services
{

    public class CountPersonsService : ICountePersonsService
    {
        public async Task<ActionResult<PersonCount>> Execute(PersonDBContext _context)
        {
            var persons = await _context.Person.ToListAsync();
            return new PersonCount {
                NumberOfPersons = persons.Count()
            }; 
        }
    }
}
