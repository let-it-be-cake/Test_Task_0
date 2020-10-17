using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using Task1.Classes;

namespace Test
{
    /// <summary>
    /// Read csv file
    /// </summary>
    public class Reader
    {
        /// <summary>
        /// Storing data from csv files
        /// </summary>
        private class Container
        {
            public string Type { get; set; }
            public double[] Arguments { get; set; }
        }

        /// <summary>
        /// Additional class for markup data 
        /// </summary>
        private class CustormContainer : ClassMap<Container>
        {
            public CustormContainer()
            {
                Map(m => m.Type).Index(0);
                Map(m => m.Arguments).Index(1);
            }
        }

        // I'm too lazy to make a switch case for each class, let it be so.
        /// <summary>
        /// Reading a csv document
        /// </summary>
        /// <param name="path">Path to read</param>
        /// <returns>Figure collection</returns>
        static public IEnumerable<Figure> ReadFigures(string path)
        {
            var read = ReadCsvFigures(path);
            var result = new List<Figure>();

            foreach (var figure in read)
            {
                result.Add((Figure)Activator.CreateInstance
                (
                    Type.GetType(figure.Type),
                    figure.Arguments
                        .Select(o => o as object)
                        .ToArray()
                ));
            }

            return result;
        }

        /// <summary>
        /// Standart CSVHelper settings
        /// </summary>
        /// <param name="fileName">Path to read</param>
        /// <returns></returns>
        static private IEnumerable<Container> ReadCsvFigures(string fileName)
        {
            using (var reader = new StreamReader(fileName))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Configuration.HasHeaderRecord = false;
                csv.Configuration.Delimiter = ":";
                csv.Configuration.RegisterClassMap<CustormContainer>();
                return csv.GetRecords<Container>().ToArray();
            }
        }
    }
}