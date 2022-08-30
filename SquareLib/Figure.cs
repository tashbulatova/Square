using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareLib
{
    public class Figure
    {
        public double Area { get; set; }

        public virtual double GetArea()
        {
            return Area;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Площадь фигуры = {Math.Round(GetArea(), 4)}");            
        }
    }
}
