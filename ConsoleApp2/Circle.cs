using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Circle : IShape
    {
        public void CalculateArea(int r)
        {
            double Area = 3.14 * r * r;
            Console.WriteLine(Area);
            //Area = Convert.ToInt32(Console.ReadLine());
        }
    }
}
