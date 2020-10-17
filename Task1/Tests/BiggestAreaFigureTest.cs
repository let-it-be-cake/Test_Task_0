using System.Collections.Generic;
using System.Linq;
using Task1;
using Task1.Classes;
using Xunit;

namespace Tests
{
    public class BiggestAreaFigureTest
    {
        public static IEnumerable<object[]> AreaFigureTest()
        {
            yield return new object[]
            {
                new List<Figure>() {
                    new Triangle(5,3,4),
                    new Triangle(3,4,5),
                    new Triangle(4,5,3),
                    new Rectangle(5,5),
                    new Rectangle(6,6),
                    new Rectangle(7,7),
                },
                new Rectangle(7,7),
            };

            yield return new object[]
            {
                new List<Figure>() {
                    new Triangle(25,15,20),
                    new Triangle(3,4,5),
                    new Triangle(4,5,3),
                    new Rectangle(2,1),
                    new Rectangle(1,2),
                    new Rectangle(2,1),
                },
                new Triangle(25,15,20),
            };
            yield return new object[]
{
                new List<Figure>() {
                    new Triangle(5,3,4),
                    new Triangle(6,8,10),
                    new Triangle(12,15,9),
                    new Circle(10),
                    new Circle(15),
                    new Circle(20),
                    new Rectangle(5,5),
                    new Rectangle(6,6),
                    new Rectangle(7,7),
                },
                new Circle(20),
};
        }

        /// <summary>
        /// Figure with the highest area
        /// </summary>
        /// <param name="figures"></param>
        /// <param name="expected"></param>
        [Theory]
        [MemberData(nameof(AreaFigureTest))]
        public void Biggest_Area_Test_Figures_List(List<Figure> figures, Figure expected)
        {
            //arrage
            Figure actual;

            //act
            actual = figures.Max();

            //assert
            Assert.Equal(expected, actual);
        }
    }
}