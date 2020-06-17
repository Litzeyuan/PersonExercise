using Microsoft.AspNetCore.Mvc;
using PersonOperation.Data;
using System.Threading.Tasks;

namespace PersonOperation.Interfaces
{
    public interface IAddPersonService
    {
        Task<IActionResult> Execute(PersonDBContext _context, Person person);
    }
}
