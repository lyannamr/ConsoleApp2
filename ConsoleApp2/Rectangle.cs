using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Rectangle : IShape
    {
        public void CalculateArea(int r,int b)
        {
            int area2 = r * b;
            Console.WriteLine(area2);    
        }
    }
}
