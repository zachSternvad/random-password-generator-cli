namespace random_password_generator_cli
{
    internal class Program
    {
        private const string LowercaseChars = "abcdefghijklmnopqrstuvwxyz";
        private const string UppercaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string NumberChars = "0123456789";
        private const string SymbolChars = "!@#$%^&*()-_=+[]{}|;:,.<>?";


        static void Main(string[] args)
        {
            Console.WriteLine("--Random Password Generator--");

            Console.Write("Enter desired password length: ");
            if (int.TryParse(Console.ReadLine(), out int length) && length > 0)
            {
                Console.Write("Include lowercase (a-z)? (y/n): ");
                bool includeLowercase = Console.ReadLine().ToLower() == "y";

                Console.Write("Include uppercase (A-Z)? (y/n): ");
                bool includeUppercase = Console.ReadLine().ToLower() == "y";

                Console.Write("Include numbers (0-9)? (y/n): ");

                bool includeNumbers = Console.ReadLine().ToLower() == "y";

                Console.Write("Include symbols (!@#$)? (y/n): ");
                bool includeSymbols = Console.ReadLine().ToLower() == "y";

                string password = GeneratePassword(length, includeLowercase, includeUppercase, includeNumbers, includeSymbols);

                if (string.IsNullOrEmpty(password))
                {
                    Console.WriteLine("\nError, You must select at least one character type!");
                }
                else
                {
                    Console.WriteLine($"\nYour new random password is: {password}");
                }
            }
            else
            {
                Console.WriteLine("Error, Input a positive number for the length!");
            }

            Console.WriteLine("\nPress a key to exit");
            Console.ReadKey();
        }

        public static string GeneratePassword(int length, bool includeLowercase, bool includeUppercase, bool includeNumbers, bool includeSymbols)
        {
            var allowedChars = new StringBuilder();
            if (includeLowercase) allowedChars.Append(LowercaseChars);
            if (includeUppercase) allowedChars.Append(UppercaseChars);
            if (includeNumbers) allowedChars.Append(NumberChars);
            if (includeSymbols) allowedChars.Append(SymbolChars);

            if (allowedChars.Length == 0)
            {
                return null;
            }

            var password = new StringBuilder(length);
            var random = new Random();

            for (int i = 0; i < length; i++)
            {
                int randomIndex = random.Next(0, allowedChars.Length);
                char randomChar = allowedChars[randomIndex];
                password.Append(randomChar);
            }

            return password.ToString();
        }
    }
}