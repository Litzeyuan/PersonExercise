using Microsoft.AspNetCore.Mvc;
using PersonOperation.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonOperation.Interfaces
{
    public interface IGetPersonsService
    {
        Task<ActionResult<IEnumerable<Person>>> Execute(PersonDBContext _context);
    }
}
