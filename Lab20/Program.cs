using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20
{
    class Program
    {
        delegate double MyDelegate(double radius);
        static void Main(string[] args)
        {
            Console.Write("Введите радиус: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            MyDelegate Delegate = Geometry.LengthCircle;
            double Long = Delegate(radius);
            Console.WriteLine("Длина окружности: {0:F2}", Long);
            MyDelegate Delegate2 = Geometry.SquareCircle;
            double square = Delegate2(radius);
            Console.WriteLine("Площадь круга: {0:F2}", square);
            MyDelegate Delegate3 = Geometry.VolumeBall;
            double volume = Delegate3(radius);
            Console.WriteLine("Объем шара: {0:F2}", volume);
            Console.ReadKey();
        }
    }
    static public class Geometry
    {
        static public double LengthCircle(double radius)
        {
            return 2 * Math.PI * radius;
        }
        static public double SquareCircle(double radius)
        {
            return Math.PI * radius * radius;
        }
        static public double VolumeBall(double radius)
        {
            return 4 * Math.PI * Math.Pow(radius, 3) / 3;
        }
    }
}