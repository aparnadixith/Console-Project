using Console_Project.Data;
using Console_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Project.Tests
{
    public class PeopleServiceTests
    {
        [Fact]
        public void CreatePerson_ShouldAddPersonToArray()
        {
            // Arrange
            PeopleService service = new PeopleService();
            service.Clear();
            string firstName = "Riya";
            string lastName = "Rawat";

            // Act
            Person person = service.CreatePerson(firstName, lastName);

            // Assert
            Assert.Single(service.FindAll());
            Assert.Equal(firstName, person.FirstName);
            Assert.Equal(lastName, person.LastName);
        }

        [Fact]
        public void RemovePerson_ShouldRemovePersonFromArray()
        {
            // Arrange
            PeopleService service = new PeopleService();
            service.Clear();
            Person person1 = service.CreatePerson("Aparna", "Dixith");
            Person person2 = service.CreatePerson("Avani", "Hunagund");

            // Act
            service.RemovePerson(person1.Id);

            // Assert
            Assert.Single(service.FindAll());
            Assert.Equal(person2.Id, service.FindAll()[0].Id);
        }
    }
}