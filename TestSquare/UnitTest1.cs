using Microsoft.VisualStudio.TestTools.UnitTesting;
using SquareLib;

namespace TestSquare
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
            public void TriangleMethod()
            {
                //Arrange
                var triangle = new Triangle(3, 4, 5);
                double expected = 6;

                //Act
                double result = triangle.GetArea();

                //Assert
                Assert.AreEqual(expected, result, "Метод выполняется некорректно");
            }

        [TestMethod]
            public void CircleMethod()
        {
            //Arrange
            var circle = new Сircle(5);
            double expected = 78.53981633974483;

            //Act
            double result = circle.GetArea();

            //Assert
            Assert.AreEqual(expected, result, "Метод выполняется некорректно");
        }
        }
    }