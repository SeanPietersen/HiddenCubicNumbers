using System;
using Xunit;

namespace HiddenCubicNumbers.Test
{
    public class CalculateTheCubesTest
    {
        [Fact]
        public void SumOfCubesTest1()
        {
            //Arrange
            ICalculateTheCubes calculateTheCube = new CalculateTheCubes();

            string s = "0 9026315 -827&()";
            
            string expected = "0 0 Lucky";

            //Act

            var actual = calculateTheCube.isSumOfCubes(s);

            //Assert
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void SumOfCubesTest2()
        {
            //Arrange
            ICalculateTheCubes calculateTheCube = new CalculateTheCubes();

            string s = "aqdf&0#1xyz!22[153(777.777";

            string expected = "0 1 153 154 Lucky";

            //Act

            var actual = calculateTheCube.isSumOfCubes(s);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SumOfCubesTest3()
        {
            //Arrange
            ICalculateTheCubes calculateTheCube = new CalculateTheCubes();

            string s = "QK29a45[&erui9026315";

            string expected = "Unlucky";

            //Act

            var actual = calculateTheCube.isSumOfCubes(s);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
