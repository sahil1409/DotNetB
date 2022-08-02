using System.Text;
namespace Strings {
    class Program {
        public static void Main(string[] args) {
            StringBuilder addWord = new StringBuilder ("Sahil");
            addWord.Append("*Altaf");
            addWord.Append("*Shaikh");
            System.Console.WriteLine(addWord);
        }
    }
}