using Microsoft.AspNetCore.Mvc;
using PersonOperation.Data;
using PersonOperation.Models;
using System.Threading.Tasks;

namespace PersonOperation.Interfaces
{
    public interface ICountePersonsService
    {
        Task<ActionResult<PersonCount>> Execute(PersonDBContext _context);
    }
}
