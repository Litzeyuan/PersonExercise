using Microsoft.AspNetCore.Mvc;
using PersonOperation.Data;
using System.Threading.Tasks;

namespace PersonOperation.Interfaces
{
    public interface IUpdatePersonService
    {
        Task<IActionResult> Execute(PersonDBContext _context, Person person);
    }
}
