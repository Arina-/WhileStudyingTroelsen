using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWhileStudyingTroelsen
{
    class ObjectInitialization
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
            // по сути является сокращенной версией инициализации первой точки
            Point point3 = new Point { X = 3, Y = 3 };
            point3.DisplayStats();

            Point point4 = new Point(4, 4) { Y = 5 };
            point4.DisplayStats();

            Rectangle rect1 = new Rectangle() { TopLeft = point4, BottomRight = point1 };
            rect1.DisplayStats();

            // классы - ссылочный тип данных
            // поэтому изменение в rect1.TopLeft.X 
            // приведет к изменению в point4.X
            rect1.TopLeft.X = 2;
            point4.DisplayStats();

            Rectangle rect2 = new Rectangle()
            {
                TopLeft = new Point(10, 10),
                BottomRight = new Point(0, 0)
            };
            rect2.DisplayStats();

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

    class Rectangle
    {
        //автоматические свойства устанавливают все внутренние переменные классов в null
        //поэтому нужно использовать традиционный синтаксис свойств
        private Point prTopLeft;
        private Point prBottomRight;

        public Point TopLeft
        {
            get { return prTopLeft; } 
            set { prTopLeft = value; }
        }

        public Point BottomRight
        {
            get { return prBottomRight; }
            set { prBottomRight = value; }
        }

        public Rectangle() { }

        public void DisplayStats()
        {
            Console.WriteLine("TopLeft: ({0}, {1}). BottomRight: ({2}, {3}).", prTopLeft.X, prTopLeft.Y, 
                                                                               prBottomRight.X, prBottomRight.Y);
        }

    }
}
