using Task1.Classes;

namespace Task1
{
    /// <summary>
    /// Rectangle figure
    /// </summary>
    public class Rectangle : Figure
    {
        /// <summary>
        /// Basic constructor
        /// </summary>
        /// <param name="radius"></param>
        public Rectangle(double side1, double side2)
        {
            Side1 = side1;
            Side2 = side2;
        }

        /// <summary>
        /// First side of the rectangle
        /// </summary>
        public double Side1 { get; private set; }
        /// <summary>
        /// Second side of the rectangle
        /// </summary>
        public double Side2 { get; private set; }

        /// <summary>
        /// Rectangle area
        /// </summary>
        /// <returns>Area</returns>
        public override double Area()
        {
            return Side1 * Side2;
        }

        public override bool Equals(object obj)
        {
            return obj is Rectangle rectangle &&
                   Side1 == rectangle.Side1 &&
                   Side2 == rectangle.Side2;
        }

        public override int GetHashCode()
        {
            int hashCode = 820215177;
            hashCode = hashCode * -1521134295 + Side1.GetHashCode();
            hashCode = hashCode * -1521134295 + Side2.GetHashCode();
            return hashCode;
        }

        /// <summary>
        /// Rectangle perimeter
        /// </summary>
        /// <returns>Area</returns>
        public override double Perimeter()
        {
            return (Side1 + Side2) * 2;
        }
    }
}