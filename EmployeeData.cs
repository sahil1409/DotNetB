using System.Text;
using System;
namespace EmployeeData {
    class Driver {
        public static void Main() {
            Employee emp = new Employee();
            emp.Records();
        }
    }
    class Employee {
        public void Records(){
            string choice = "";
            StringBuilder res = new StringBuilder ("");
            while(true) {
                System.Console.Write("Enter employee name: ");
                string name = Console.ReadLine();
                System.Console.Write("Enter employee address: ");
                string address = Console.ReadLine();
                res.Append(name + "\t" + address + "\n");
                System.Console.WriteLine("Do you want to conitnue? (Y/N) : ");
                choice = (Console.ReadLine()).ToUpper();
                if(choice != "Y") {
                    break;
                }
            }
            System.Console.WriteLine();
            System.Console.WriteLine(res);;
        }
    }
}
