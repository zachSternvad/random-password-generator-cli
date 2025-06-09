using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random_password_generator_cli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Random Password Generator--");

            Console.WriteLine("Enter desired password length: ");
            if (int.TryParse(Console.ReadLine(), out int length) && length > 0)
                {
                Console.WriteLine("Include lowercase (a-z)? (Y/N): ");
                bool includeLowercase = Console.ReadLine().ToLower() == "y";
                Console.WriteLine("Include uppercase (A-Z)? (Y/N): ");
                bool includeUppercase = Console.ReadLine().ToLower() == "y";
                Console.WriteLine("Include numbers (0-9)? (Y/N): ");
                bool IncludeNumbers = Console.ReadLine().ToLower() == "y";
                Console.WriteLine("Include symbols (!@#$€)? (Y/N): ");
                bool IncludeSymbols = Console.ReadLine().ToLower() == "y";

                Console.WriteLine("\nGenerating Password...");
            }
            else
            {
                Console.WriteLine("");
            }
        }
    }
}
