using System;
namespace Date {

    class Diff {
        public static void calcDiff(DateTime dates1, DateTime dates2) {
            TimeSpan interval = dates2 - dates1;
            System.Console.WriteLine("The TimeSpan difference is: " + interval);
        }
    }

    class Driver {
        static void Main(string[] args) {

            System.Console.WriteLine("Enter Year1: ");
            int year1 = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter Month1: ");
            int month1 = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter Date1: ");
            int date1 = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter Hour1: ");
            int hr1 = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter Minute1: ");
            int min1 = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter Second1: ");
            int sec1 = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Enter Year2: ");
            int year2 = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter Month2: ");
            int month2 = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter Date2: ");
            int date2 = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter Hour2: ");
            int hr2 = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter Minute2: ");
            int min2 = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter Second2: ");
            int sec2 = Convert.ToInt32(Console.ReadLine());
                    
            DateTime dates1 = new DateTime(year1, month1, date1, hr1, min1, sec1);
            DateTime dates2 = new DateTime(year2, month2, date2, hr2, min2, sec2);

            Date.Diff.calcDiff(dates1, dates2);
        }
    }
}