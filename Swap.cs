using System;
namespace Swap {
    class Driver {
        public static void Main() {
            string a = "p";
            string b = "q";
            refClass obj = new refClass();
            obj.refMethod(ref a, ref b);
            System.Console.WriteLine("a = " + a + "\nb = " + b);
        }
    }
    class refClass {
        public void refMethod(ref string a, ref string b) {
            a = "q";
            b = "p";
        }
    }
}