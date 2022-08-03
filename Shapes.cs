using System;
namespace Shapes {
    class Area {
        public static void Main(string[] args) {
            System.Console.WriteLine("Enter length and breadth: ");
            int l = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Rect r = new Rect();
            r.rectArea(l, b);
            Square s = new Square();
            s.sqrArea(l);
        }
    }

    class Rect {
        public void rectArea(int l, int b) {
            int area = l * b;
            System.Console.WriteLine("Area of Rectangle is: " + area);
        }
    }
    class Square {
        public void sqrArea(int l) {
            int area = l * l;
            System.Console.WriteLine("Area of Square is: " + area);
        }
    }
}