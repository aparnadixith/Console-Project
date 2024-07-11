using Console_Project.Models;
using Newtonsoft.Json.Bson;

namespace TestProject1
{
    public class PersonTest
    {
        [Fact]
        public void Constructor_ShouldInitializeFields()
        {
            //Arrage
            int expectedId = 1;
            string expectedFirstName = "Avani";
            string expectedLastName = "Hunagund";

            //Act
            Person person = new Person(expectedId, expectedFirstName, expectedLastName);

            //Assert
            Assert.Equal(expectedId, person.Id);
            Assert.Equal(expectedFirstName, person.FirstName);
            Assert.Equal(expectedLastName, person.LastName);
        }

        [Fact]

        public void FirstName_SetValidValue_ShouldUpdateValue()
        {
            //Arrange
            Person person = new Person(1, "Avani", "Hunagund");
            string newFirstName = "Aparna";

            //Act
            person.FirstName = newFirstName;

            //Assert
            Assert.Equal(newFirstName, person.FirstName);

        }
        [Fact]

        public void LastName_SetValidValue_ShouldUpdateValue()
        {
            //Arrange
            Person person = new Person(1, "Aparna", "Hunagund");
            string newLastName = "Dixith";

            //Act
            person.LastName = newLastName;

            //Assert
            Assert.Equal(newLastName, person.LastName);

        }
   
    }
}