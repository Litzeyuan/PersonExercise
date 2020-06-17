using Microsoft.EntityFrameworkCore;
using PersonOperation.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonOperation.Data
{
    public interface IPersonDBContext
    {
        DbSet<Person> Person { get; set; }
    }

    public class PersonDBContext : DbContext, IPersonDBContext
    {
        public PersonDBContext(DbContextOptions<PersonDBContext> options) : base(options) { }
        public DbSet<Person> Person { get; set; }
    }
}
