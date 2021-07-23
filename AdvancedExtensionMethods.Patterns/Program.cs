using System;
using System.Text;

namespace AdvancedExtensionMethods.Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stringbuilder = new();
            stringbuilder.AppendLine("First Line");
            stringbuilder.AL("Second Line but with Shorthand of AppendLine");

            string myName = "Armin";
            bool isMyNameNullOrEmpty = myName.IsNullOrEmpty();
            bool isMyNameNullOrWhiteSpace = myName.IsNullOrWhiteSpace();
            Console.WriteLine($"Is My Name Null Or Empty? {isMyNameNullOrEmpty}");
            Console.WriteLine($"Is My Name Null Or WhiteSpace? {isMyNameNullOrWhiteSpace}");

            Console.WriteLine();

            string emptyString = string.Empty;
            Console.WriteLine($"Is provided string is Empty or NULL? {emptyString.IsNullOrEmpty()}");
            Console.WriteLine($"Is provided string is Empty or NULL or WhiteSpace? {emptyString.IsNullOrWhiteSpace()}");

            string nullString = default;
            Console.WriteLine($"Is provided string is Empty or NULL? {nullString.IsNullOrEmpty()}");
            Console.WriteLine($"Is provided string is Empty or NULL or WhiteSpace? {nullString.IsNullOrWhiteSpace()}");



            Console.WriteLine("Hello World!");
        }
    }
}
