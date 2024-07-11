using Console_Project.Data;
using Console_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleCoreTesting
{

    public class TodoServiceTests
    {
        [Fact]
        public void Size_ShouldReturnZero_WhenNoOfTodos()
        {
            // Arrange
            TodoService service = new TodoService();
            service.Clear();

            // Act
            int size = service.Size();

            // Assert
            Assert.Equal(0, size);
        }

        [Fact]
        public void FindAll_ShouldReturnEmptyArray_WhenNoOfTodos()
        {
            // Arrange
            TodoService service = new TodoService();
            service.Clear(); // Ensure the array is empty

            // Act
            Todo[] todos = service.FindAll();

            // Assert
            Assert.Empty(todos);
        }

        [Fact]
        public void FindById_ShouldReturnNull_WhenTodoNotFound()
        {
            // Arrange
            TodoService service = new TodoService();
            service.Clear(); // Ensure the array is empty

            // Act
            Todo todo = service.FindById(1);

            // Assert
            Assert.Null(todo);
        }
        [Fact]
        public void CreateTodo_ShouldAddNewTodo_ToTheArray()
        {
            // Arrange
            TodoService service = new TodoService();
            service.Clear(); // Ensure the array is empty

            // Act
            Todo newTodo = service.CreateTodo("Test Description");

            // Assert
            Assert.Equal(1, service.Size());
            Assert.Equal("Test Description", newTodo.Description);
        }

        [Fact]
        public void Clear_ShouldRemoveAllTodos_FromTheArray()
        {
            // Arrange
            TodoService service = new TodoService();
            service.CreateTodo("Test Description");

            // Act
            service.Clear();

            // Assert
            Assert.Equal(0, service.Size());
        }

        [Fact]
        public void FindByDoneStatus_ShouldReturnMatchingTodos()
        {
            // Arrange
            TodoService service = new TodoService();
            service.Clear();
            Todo todo1 = service.CreateTodo("Test 1");
            Todo todo2 = service.CreateTodo("Test 2");
            todo2.Done = true;

            // Act
            Todo[] doneTodos = service.FindByDoneStatus(true);
            Todo[] notDoneTodos = service.FindByDoneStatus(false);

            // Assert
            Assert.Single(doneTodos);
            Assert.Equal("Test 2", doneTodos[0].Description);
            Assert.Single(notDoneTodos);
            Assert.Equal("Test 1", notDoneTodos[0].Description);
        }

        [Fact]
        public void FindByAssignee_ShouldReturnMatchingTodos_ByPersonId()
        {
            // Arrange
            TodoService service = new TodoService();
            service.Clear();
            Person person = new Person(1, "Riya", "Rawat");
            Todo todo1 = service.CreateTodo("Test 1");
            Todo todo2 = service.CreateTodo("Test 2");
            todo1.Assignee = person;

            // Act
            Todo[] assignedTodos = service.FindByAssignee(1);

            // Assert
            Assert.Single(assignedTodos);
            Assert.Equal("Test 1", assignedTodos[0].Description);
        }

        [Fact]
        public void FindByAssignee_ShouldReturnMatchingTodos_ByPerson()
        {
            // Arrange
            TodoService service = new TodoService();
            service.Clear();
            Person person = new Person(1, "Riya", "rawat");
            Todo todo1 = service.CreateTodo("Test 1");
            Todo todo2 = service.CreateTodo("Test 2");
            todo1.Assignee = person;

            // Act
            Todo[] assignedTodos = service.FindByAssignee(person);

            // Assert
            Assert.Single(assignedTodos);
            Assert.Equal("Test 1", assignedTodos[0].Description);
        }

        [Fact]
        public void FindUnassignedTodoItems_ShouldReturnTodos_WithoutAssignee()
        {
            // Arrange
            TodoService service = new TodoService();
            service.Clear();
            Todo todo1 = service.CreateTodo("Test 1");
            Todo todo2 = service.CreateTodo("Test 2");
            Person person = new Person(1, "Riya", "Rawat");
            todo2.Assignee = person;

            // Act
            Todo[] unassignedTodos = service.FindUnassignedTodoItems();

            // Assert
            Assert.Single(unassignedTodos);
            Assert.Equal("Test 1", unassignedTodos[0].Description);
        }


    }
}