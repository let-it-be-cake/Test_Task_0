using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1.Classes
{
    /// <summary>
    /// Base class for figures
    /// </summary>
    public abstract class Figure : IComparable
    {
        /// <summary>
        /// Finds the collection with the largest average perimeter
        /// </summary>
        /// <param name="figures">Figure collection</param>
        /// <returns>Name of the final collection</returns>
        public static string BiggestAveragePerimeter(IEnumerable<Figure> figures)
        {
            var dictionary = new Dictionary<string, List<Figure>>();
            var figureName = "";
            var templeCollection = new List<Figure>();

            foreach (var figure in figures)
            {
                figureName = figure.GetType().Name;
                if (dictionary.ContainsKey(figureName))
                    dictionary[figureName].Add(figure);
                else
                    dictionary.Add(figureName, new List<Figure>() { figure });
            }

            (string Name, double Value) maxPair =
                (
                    dictionary.First().Key,
                    dictionary.First().Value.Average(o => o.Perimeter())
                );

            foreach (var pair in dictionary)
            {
                var averageValue = pair.Value.Average(o => o.Perimeter());
                if (maxPair.Value < averageValue)
                    maxPair = (pair.Key, averageValue);
            }
            return maxPair.Name;
        }

        /// <summary>
        /// The area of the figure
        /// </summary>
        /// <returns>Area</returns>
        public abstract double Area();

        /// <summary>
        /// The perimeter of the shape
        /// </summary>
        /// <returns>Perimeter</returns>
        public abstract double Perimeter();

        public int CompareTo(object obj)
        {
            return (int)(Area() - ((Figure)obj).Area());
        }
    }
}