using System;
using AdvancedExtensionMethods.MaybeMonad.Models;

namespace AdvancedExtensionMethods.MaybeMonad
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new();
            p.LastName = "Shoeibi";
            p.FirstName = "Armin";

            string lastName = p.With(p => p.LastName);
            string firstName = p.With(p => { return p.FirstName; });
        }
    }
}
