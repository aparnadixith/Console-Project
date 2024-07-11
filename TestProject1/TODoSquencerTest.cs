using Console_Project.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreTesting
{
    public class TodoSequencerTests
    {
        [Fact]
        public void NextTodoId_ShouldIncrementAndReturnNextValue()
        {
            // Arrange
            TodoSequencer.Reset();
            int expectedId = 1;

            // Act
            int actualId = TodoSequencer.NextTodoId();

            // Assert
            Assert.Equal(expectedId, actualId);
        }

        [Fact]
        public void NextTodoId_ShouldReturnIncrementedValues()
        {
            // Arrange
            TodoSequencer.Reset();
            int firstExpectedId = 1;
            int secondExpectedId = 2;

            // Act
            int firstActualId = TodoSequencer.NextTodoId();
            int secondActualId = TodoSequencer.NextTodoId();

            // Assert
            Assert.Equal(firstExpectedId, firstActualId);
            Assert.Equal(secondExpectedId, secondActualId);
        }

        [Fact]
        public void Reset_ShouldSetTodoIdToZero()
        {
            // Arrange
            TodoSequencer.NextTodoId();
            TodoSequencer.Reset();

            // Act
            int actualId = TodoSequencer.NextTodoId();

            // Assert
            Assert.Equal(1, actualId);
        }
    }
}
