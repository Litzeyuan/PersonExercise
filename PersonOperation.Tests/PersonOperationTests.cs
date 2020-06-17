using Microsoft.EntityFrameworkCore;
using Moq;
using PersonOperation.Data;
using PersonOperation.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PersonOperation.Tests
{
    public class PersonOperationTests : PersonTestBase
    {
        public PersonOperationTests() : base(
            new DbContextOptionsBuilder<PersonDBContext>().UseInMemoryDatabase("Person").Options
            )
        {
        }

        [Fact]
        public async Task PersonOperation_ShouldAddAPersonWithProvidedData()
        {
            var firstName = "FirstName3";
            var lastName = "LastName3";
            var dbContext = new PersonDBContext(ContextOptions);
            var person = new Person(113, firstName, lastName);
            var result = await new AddPersonService().Execute(dbContext, person);

            Assert.Equal(firstName, dbContext.Person.Single(p => p.Id == 113).FirstName);
            Assert.Equal(lastName, dbContext.Person.Single(p => p.Id == 113).LastName);
        }

        [Fact]
        public async Task PersonOperation_ShoulUpdateThePersonWithProvidedData()
        {
            var newName = "New FirstName";
            var dbContext = new PersonDBContext(ContextOptions);
            var person = new Person
            {
                Id = 111,
                FirstName = newName
            };
            var result = await new UpdatePersonService().Execute(dbContext, person);

            Assert.Equal(newName, dbContext.Person.Single(p => p.Id == person.Id).FirstName);
        }

        [Fact]
        public async Task PersonOperation_ShoulDeleteThePersonByIdProvided()
        {
            var idToDelete = 111;
            var id = 112;
            var dbContext = new PersonDBContext(ContextOptions);
            var result = await new DeletePersonService().Execute(dbContext, idToDelete);

            Assert.Empty(dbContext.Person.Where(p => p.Id == idToDelete));
            Assert.Single(dbContext.Person.Where(p => p.Id == id));
        }

        [Fact]
        public async Task PersonOperation_ShouldReturnCorrectCountofAllPersons()
        {
            var dbContext = new PersonDBContext(ContextOptions);
            var result = await new CountPersonsService().Execute(dbContext);

            Assert.Equal(2,result.Value.NumberOfPersons);
        }

        [Fact]
        public async Task PersonOperation_ShouldReturnAllPersons()
        {
            var dbContext = new PersonDBContext(ContextOptions);
            var result = await new GetPersonsService().Execute(dbContext);

            Assert.Equal(2,result.Value.Count());
        }

    }
}
