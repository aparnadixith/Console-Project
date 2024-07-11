using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console_Project.Model;

namespace ConsoleCoreTesting
{
    public class PersonTest
    {
        [Fact]
        public void Constructor_ShouldInitializeFields()
        {
            // Arrange
            int expectedId = 1;
            string expectedFirstName = "Aparna";
            string expectedLastName = "Dixith";

            // Act
            Person person = new Person(expectedId, expectedFirstName, expectedLastName);

            // Assert
            Assert.Equal(expectedId, person.Id);
            Assert.Equal(expectedFirstName, person.FirstName);
            Assert.Equal(expectedLastName, person.LastName);
        }

        [Fact]

        public void FirstName_SetValidValue_ShouldUpdateValue()
        {
            // Arrange
            Person person = new Person(1, "Aparna", "Dixith");
            string newFirstName = "Avani";

            // Act
            person.FirstName = newFirstName;

            // Assert
            Assert.Equal(newFirstName, person.FirstName);
        }

        [Fact]

        public void LastName_SetValidValue_ShouldUpdateValue()
        {
            // Arrange
            Person person = new Person(1, "Avani", "Dixith");
            string newLastName = "Hunagund";

            // Act
            person.LastName = newLastName;

            // Assert
            Assert.Equal(newLastName, person.LastName);
        }
    }
}
