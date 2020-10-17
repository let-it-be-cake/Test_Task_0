using System;
using System.Collections.Generic;
using Task1;
using Task1.Classes;
using Xunit;

namespace Tests
{
    public class BiggerThanAverageTest
    {
        public static IEnumerable<object[]> BiggerThenAverageData()
        {
            yield return new object[]
            {
                new List<Figure>() {
                    new Triangle(10,10,10),
                    new Triangle(10,10,10),
                    new Triangle(10,10,10),
                    new Circle(20),
                    new Circle(15),
                    new Circle(25),
                    new Rectangle(5,5),
                    new Rectangle(6,6),
                    new Rectangle(7,7),
                },
                "Circle",
            };

            yield return new object[]
            {
                new List<Figure>() {
                    new Triangle(10,10,10),
                    new Triangle(10,10,10),
                    new Triangle(10,10,10),
                    new Circle(1),
                    new Circle(2),
                    new Circle(1),
                    new Rectangle(1,1),
                    new Rectangle(1,2),
                    new Rectangle(2,1),
                },
                "Triangle",
            };
            yield return new object[]
{
                new List<Figure>() {
                    new Triangle(2,1,1),
                    new Triangle(1,2,1),
                    new Triangle(1,1,2),
                    new Circle(1),
                    new Circle(2),
                    new Circle(1),
                    new Rectangle(5,5),
                    new Rectangle(6,6),
                    new Rectangle(7,7),
                },
                "Rectangle",
};
        }
        [Theory]
        [MemberData(nameof(BiggerThenAverageData))]
        public void Bigger_Than_Average_Test_Figures_List(List<Figure> figures, string expected)
        {
            //arrage
            string actual;

            //act
            actual = Figure.BiggestAveragePerimeter(figures);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
