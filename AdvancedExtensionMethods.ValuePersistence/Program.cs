using System;

namespace AdvancedExtensionMethods.ValuePersistence
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "Armin";

            myName.SetTag("Shoeibi");
            object myNameTag = myName.GetTag();
            Console.WriteLine(myNameTag);

            myName.SetTag("Override old tag");
            myNameTag = myName.GetTag();
            Console.WriteLine(myNameTag);
        }
    }
}
