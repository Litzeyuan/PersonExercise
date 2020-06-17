using Microsoft.EntityFrameworkCore;
using PersonOperation.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonOperation.Tests
{
    public class PersonTestBase
    {
        protected DbContextOptions<PersonDBContext> ContextOptions { get; }
        protected PersonTestBase(DbContextOptions<PersonDBContext> contextOptions)
        {
            ContextOptions = contextOptions;
    
            Seed();
        }


        private void Seed()
        {
            var context = new PersonDBContext(ContextOptions);
            context.Database.EnsureDeleted();

            context.AddRange(
                    new Person(111, "FirstName1", "LastName1"),
                    new Person(112, "FirstName1", "LastName2")
           );
            context.SaveChanges();
            

        }
    }
}
