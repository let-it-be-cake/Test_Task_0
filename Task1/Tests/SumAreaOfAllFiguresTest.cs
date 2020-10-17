using System.Collections.Generic;
using System.Linq;
using Task1;
using Task1.Classes;
using Xunit;

namespace Tests
{
    public class SumAreaOfAllFigures
    {
        public static IEnumerable<object[]> SumAreaData()
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
                128,
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
                24,
            };
            yield return new object[]
{
                new List<Figure>() {
                    new Triangle(5,3,4),
                    new Triangle(6,8,10),
                    new Triangle(12,15,9),
                    new Rectangle(5,5),
                    new Rectangle(6,6),
                    new Rectangle(7,7),
                },
                194,
};
        }

        /// <summary>
        /// Sum of the areas of all figures
        /// </summary>
        /// <param name="figures"></param>
        /// <param name="expected"></param>
        [Theory]
        [MemberData(nameof(SumAreaData))]
        public void Sum_Area_Test_Figures_List(List<Figure> figures, double expected)
        {
            //arrage
            double actual;

            //act
            actual = figures.Sum(o => o.Area());

            //assert
            Assert.Equal(expected, actual);
        }
    }
}