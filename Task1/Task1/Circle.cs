using System;
using Task1.Classes;

namespace Task1
{
    /// <summary>
    /// Circle figure
    /// </summary>
    public class Circle : Figure
    {
        /// <summary>
        /// Basic constructor
        /// </summary>
        /// <param name="radius"></param>
        public Circle(double radius)
        {
            Radius = radius;
        }

        /// <summary>
        /// Circle radius
        /// </summary>
        public double Radius { get; private set; }

        /// <summary>
        /// Curcle area
        /// </summary>
        /// <returns>Area</returns>
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override bool Equals(object obj)
        {
            return obj is Circle circle &&
                   Radius == circle.Radius;
        }

        public override int GetHashCode()
        {
            return 598075851 + Radius.GetHashCode();
        }

        /// <summary>
        /// Circle perimeter
        /// </summary>
        /// <returns>Perimeter</returns>
        public override double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}