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
    public class GetPersonsService : IGetPersonsService
    {
        public async Task<ActionResult<IEnumerable< Person>>> Execute(PersonDBContext _context)
        {
            return await _context.Person.ToListAsync();
        }
    }
}
