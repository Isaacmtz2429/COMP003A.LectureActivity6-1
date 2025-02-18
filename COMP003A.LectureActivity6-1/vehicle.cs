using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.LectureActivity6_1
{
    /// <summary>
    /// Represents a general vechile.
    /// </summary>
    class Vehicle
    {
        // Fields
        private string _brand;

        // Properties
        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }
        public int Year { get; set; }

        /// <summary>
        /// Displays vechile details
        /// </summary>
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Year: {Year}");
        }
    }
}
