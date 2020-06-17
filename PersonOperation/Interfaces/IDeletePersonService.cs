using Microsoft.AspNetCore.Mvc;
using PersonOperation.Data;
using System.Threading.Tasks;

namespace PersonOperation.Interfaces
{
    public interface IDeletePersonService
    {
        Task<IActionResult> Execute(PersonDBContext _context, long id);
    }
}
