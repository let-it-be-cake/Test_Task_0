using System;
using Task1.Classes;

namespace Task1
{
    /// <summary>
    /// Triangle figure
    /// </summary>
    public class Triangle : Figure
    {
        /// <summary>
        /// Basic constructor
        /// </summary>
        /// <param name="radius"></param>
        public Triangle(double side1, double side2, double side3)
        {
            if (Side1 + Side2 > Side3 &&
                Side2 + Side3 > Side1 &&
                Side3 + Side1 > Side2)
                throw new ArgumentException("Wrong sides of a triangle.");
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }
        /// <summary>
        /// First side of the triangle
        /// </summary>
        public double Side1 { get; private set; }
        /// <summary>
        /// Second side of the triangle
        /// </summary>
        public double Side2 { get; private set; }
        /// <summary>
        /// Third side of the triangle
        /// </summary>
        public double Side3 { get; private set; }

        /// <summary>
        /// Triangle area
        /// </summary>
        /// <returns>Area</returns>
        public override double Area()
        {
            var p = (Side1 + Side2 + Side3) / 2;
            return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
        }

        public override bool Equals(object obj)
        {
            return obj is Triangle triangle &&
                   Side1 == triangle.Side1 &&
                   Side2 == triangle.Side2 &&
                   Side3 == triangle.Side3;
        }

        public override int GetHashCode()
        {
            int hashCode = -1402209752;
            hashCode = hashCode * -1521134295 + Side1.GetHashCode();
            hashCode = hashCode * -1521134295 + Side2.GetHashCode();
            hashCode = hashCode * -1521134295 + Side3.GetHashCode();
            return hashCode;
        }

        /// <summary>
        /// Triangle perimeter
        /// </summary>
        /// <returns>Perimeter</returns>
        public override double Perimeter()
        {
            return Side1 + Side2 + Side3;
        }
    }
}