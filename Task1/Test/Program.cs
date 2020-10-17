using System;
using System.Collections.Generic;
using System.Linq;
using Task1;
using Task1.Classes;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            var figures = Reader.ReadFigures("Figures.csv");
            //var figures = new List<Figure>()
            //{
            //    new Triagle(2,3,2),
            //    new Circle(8),
            //    new Rectangle(6,6),
            //    new Triagle(2,3,4),
            //    new Circle(9),
            //    new Rectangle(7,9),
            //    new Circle(10),
            //    new Circle(11),
            //    new Rectangle(10,11)
            //};
            figures.Average(o => o.Area());
            figures.Sum(o => o.Area());
            figures.Max();
            Figure.BiggestAveragePerimeter(figures);
        }
    }
}
