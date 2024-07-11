using Console_Project.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreTesting
{
    public class PersonSequencerTests
    {
        [Fact]
        public void NextPersonId_ShouldIncrementAndReturnNextValue()
        {
            // Arrange
            PersonSequencer.Reset();
            int expectedId = 1;

            // Act
            int actualId = PersonSequencer.NextPersonId();

            // Assert
            Assert.Equal(expectedId, actualId);
        }

        [Fact]
        public void NextPersonId_ShouldReturnIncrementedValues()
        {
            // Arrange
            PersonSequencer.Reset();
            int firstExpectedId = 1;
            int secondExpectedId = 2;

            // Act
            int firstActualId = PersonSequencer.NextPersonId();
            int secondActualId = PersonSequencer.NextPersonId();

            // Assert
            Assert.Equal(firstExpectedId, firstActualId);
            Assert.Equal(secondExpectedId, secondActualId);
        }

        [Fact]
        public void Reset_ShouldSetPersonIdToZero()
        {
            // Arrange
            PersonSequencer.NextPersonId();
            PersonSequencer.Reset();

            // Act
            int actualId = PersonSequencer.NextPersonId();

            // Assert
            Assert.Equal(1, actualId);
        }
    }


}
