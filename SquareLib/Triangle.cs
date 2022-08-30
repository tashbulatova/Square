using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareLib
{
    public class Triangle : Figure
    {
        public double sideA { get; set; }
        public double sideB { get; set; }
        public double sideC { get; set; }
        public Triangle(double a, double b, double c)
        {
            sideA = a;
            sideB = b;
            sideC = c;

            //проверка треугольника (по теореме Пифагора)
            if (Math.Pow(sideA, 2) + Math.Pow(sideB, 2) == Math.Pow(sideC, 2))
            {
                Console.WriteLine("Прямоугольный треугольник");
            }
        }
        public override double GetArea()
        {
            //вычисление площади по формуле Герона
            double p = (sideA + sideB + sideC) / 2;
            Area = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
            return Area;
        }
    }
}
