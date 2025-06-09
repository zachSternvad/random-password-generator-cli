using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random_password_generator_cli
{
    internal class Program
    {
        public class PasswordGenerator
        {
            private const string LowercaseChars = "abcdefghijklmnopqrstuvwxyz";
            private const string UppercaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            private const string NumberChars = "0123456789";
            private const string SymbolChars = "!@#$%^&*()-_=+[]{}|;:,.<>?";
        }
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
                Console.WriteLine("Include symbols (!@#$)? (Y/N): ");
                bool IncludeSymbols = Console.ReadLine().ToLower() == "y";

                Console.WriteLine("\nGenerating Password...");
            }
            else
            {
                Console.WriteLine("Error, Input a positive number for the length!");
            }
            Console.WriteLine("\nPress a key to exit");
            Console.ReadKey();
        }
    }


}
