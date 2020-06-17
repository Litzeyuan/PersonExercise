using System;
using System.ComponentModel.DataAnnotations;

namespace PersonOperation.Data
{
    public class Person
    {
        [Required]
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Because deserialization of reference types without parameterless constructor is not supported,
        // one solution is to create a polymorphic deserialization custom converter ,
        // but for the simplicity of this exercise, here I just simply put a parameterless constructor for the 
        public Person() { }

        public Person(long id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
