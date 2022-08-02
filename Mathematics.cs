using System;
namespace Mathematics {

    public class Add {
        public Add (int num1, int num2) {
            System.Console.WriteLine("Addition: " + num1 + " + " + num2 + " = " + (num1 + num2));
        }
    }

    public class Sub {
        public Sub (int num1, int num2) {
            System.Console.WriteLine("Subtraction: " + num1 + " - " + num2 + " = " + (num1 - num2));
        }
    }

    public class Mul {
        public Mul (int num1, int num2) {
            System.Console.WriteLine("Multiplication: " + num1 + " * " + num2 + " = " + (num1 * num2));
        }
    }

    public class Div {
        public Div (int num1, int num2) {
            System.Console.WriteLine("Division: " + num1 + " / " + num2 + " = " + (num1 / num2));
        }
    }

    class Operations {
        static void Main(string[] args) {
            Console.WriteLine("Enter Two Numbers: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Add addObj = new Add(num1, num2);
            Sub subObj = new Sub(num1, num2);
            Mul mulObj = new Mul(num1, num2);
            Div divObj = new Div(num1, num2);
        }
    }
}