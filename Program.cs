using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16March_Methods
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.Write($"Area of a Circle - {CalculateArea(7)}" +
                $"\nArea of a Rectangle - {CalculateArea(8,9)}" +
                $"\nArea of a Rectagular Parallelepiped - {CalculateArea(5,7,10)}");
            Console.ReadLine();
        }
        #region Overloadings of the method CalculateArea
        #region Summary for The Method that calculates area of a circle
        /// <summary>
        /// Calculates area of a circle.
        /// </summary>
        /// <param name="r">represents radius of a circle</param>
        /// <returns>Area of the circule</returns>
        #endregion
        static int CalculateArea(int r)
        {
            int s, p = 3;
            s = (int)p * r;
            return s;
        }
        #region Summary for The Method that calculates area of a rectangle
        /// <summary>
        /// Calculates  area of a rectangle
        /// </summary>
        /// <param name="a">represents length of rectangle</param>
        /// <param name="b">represents width of rectangle</param>
        /// <returns>Area of the rectangle</returns>
        #endregion
        static int CalculateArea(int a, int b)
        {
            int s;
            s = a * b;
            return s;
        }
        #region Summary for The Method that calculates area of a rectangular parallelepiped
        /// <summary>
        /// Calculates area of rectangular parallelepiped
        /// </summary>
        /// <param name="a">represents length</param>
        /// <param name="b">represents width</param>
        /// <param name="c">represents height</param>
        /// <returns>Area of the rectangular parallelepiped</returns>
        #endregion
        static int CalculateArea(int a, int b, int c)
        {
            int s = 2 * (a * b + a * c + b * c);
            return s;
        }
        #endregion
    }
}
