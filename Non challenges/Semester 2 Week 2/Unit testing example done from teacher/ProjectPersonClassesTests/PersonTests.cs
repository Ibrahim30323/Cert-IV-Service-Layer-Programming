using System;
using Xunit;
using ProjectPersonClassesTests;

namespace ProjectPersonClassesTests
{
    public class PersonTests
    {
        public PersonTests TestPerson { get; set;}

        public PersonTests() {
            this.TestPerson = new PersonTests();
            this.TestPerson.Name = "Jon";
            this.TestPerson.Id = 12345;
        }        

        [Fact]

        public void GetInfoTest() {
            Assert.Equal("Jon 12345", this.TestPerson.GetInfo();
        }
             
        }
    }

