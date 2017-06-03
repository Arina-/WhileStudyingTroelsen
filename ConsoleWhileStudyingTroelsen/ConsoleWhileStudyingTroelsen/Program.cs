using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWhileStudyingTroelsen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Object Initialization *****");

            Point point1 = new Point();
            point1.X = 1;
            point1.Y = 1;
            point1.DisplayStats();

            Point point2 = new Point(2, 2);
            point2.DisplayStats();

            // новый способ инициализации
            Point point3 = new Point { X = 3, Y = 3 };
            point3.DisplayStats();

            Console.ReadLine();
        }

        // использование автоматических свойств для инкапсулирования полей данный класса
        // можно использовать prop + 2xTAB
        // private int currValue;
        // public int Value { get; set; }

    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int xVal, int yVal) { X = xVal; Y = yVal; }
        public Point() {}
        public void DisplayStats()
        {
            Console.WriteLine("({0}, {1})", X, Y);
        }
    }
}
