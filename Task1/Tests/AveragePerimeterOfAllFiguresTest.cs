using System.Collections.Generic;
using System.Linq;
using Task1;
using Task1.Classes;
using Xunit;

namespace Tests
{
    public class AveragePerimeterOfAllFigures
    {
        public static IEnumerable<object[]> AveragePerimeterData()
        {
            yield return new object[]
            {
                new List<Figure>() {
                    new Triangle(10,10,10),
                    new Triangle(10,10,10),
                    new Triangle(10,10,10),
                    new Rectangle(5,5),
                    new Rectangle(6,6),
                    new Rectangle(7,7),
                },
                27,
            };

            yield return new object[]
            {
                new List<Figure>() {
                    new Triangle(5,3,4),
                    new Triangle(3,4,5),
                    new Triangle(4,5,3),
                    new Rectangle(2,1),
                    new Rectangle(1,2),
                    new Rectangle(2,1),
                },
                9,
            };
            yield return new object[]
{
                new List<Figure>() {
                    new Triangle(2,1,1),
                    new Triangle(1,2,1),
                    new Triangle(1,1,2),
                    new Rectangle(5,5),
                    new Rectangle(6,6),
                    new Rectangle(7,7),
                },
                14,
};
        }

        /// <summary>
        /// Average perimeter of all figures
        /// </summary>
        /// <param name="figures"></param>
        /// <param name="expected"></param>
        [Theory]
        [MemberData(nameof(AveragePerimeterData))]
        public void Average_Perimeter_Test_Figures_List(List<Figure> figures, double expected)
        {
            //arrage
            double actual;

            //act
            actual = figures.Average(o => o.Perimeter());

            //assert
            Assert.Equal(expected, actual);
        }
    }
}