using System.Text;
namespace Strings {
    class Program {
        public static void Main(string[] args) {
            string str1 = "Sahil ";
            string str2 = "Altaf ";
            string str3 = "Shaikh ";

            StringBuilder s1 = new StringBuilder (str1);
            StringBuilder s2 = new StringBuilder (str2);
            StringBuilder s3 = new StringBuilder (str3);

            Strings.Concate.concateStr(str1, str2, str3);
            System.Console.WriteLine();
            Strings.Append.appendStr(s1, s2, s3);
        }
    }
    class Concate {
        public static void concateStr(string str1, string str2, string str3) {
            System.Console.WriteLine("The concatinated string is: " + str1 + str2 + str3);
        }
    }
    class Append {
        public static void appendStr(StringBuilder s1, StringBuilder s2, StringBuilder s3) {
            System.Console.Write("Appended String is: ");
            s1.Append(s2);
            s1.Append(s3);
            System.Console.WriteLine(s1);
        }
    }
    
}