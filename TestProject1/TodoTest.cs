using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class ToDoTest
    {
        [Fact]
        public void Constructor_ShouldInitializeFields()
        {
            //Arrange
            int expectedId = 1;
            string expectedDescription = "Test description";


            //Act
            Todo todo = new Todo(expectedId, expectedDescription);

            //Assert
            Assert.Equal(expectedId, todo.Id);
            Assert.Equal(expectedDescription, todo.Description);
            Assert.False(todo.Done);
            Assert.Null(todo.Assignee);


        }

        [Fact]

        public void Description_SetNullOrEmpty_ShouldThrowArgumentException()
        {
            //Arrange
            ToDo todo = new Todo(1, "Test Description");

            Assert.Throws<ArgumentException>(() => todo.Description = null);
            Assert.Throws<ArgumentException>(() => todo.Description = "");
        }

        [Fact]

        public void Done_SetValidValue_ShouldUpdateValue()
        {

            //Arrange
            Todo todo = new Todo(1, "Test Description");
            bool newDone = true;

            //Act
            todo.Done = newDone;
        }

    }       
}
