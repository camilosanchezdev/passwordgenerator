using System;

namespace PasswordGenerator
{
    class PassGenerator
    {
        static void Main(string[] args)
        {
            // Variables
            int passLength = 0;
            char ans;
            string result;
            string characters = "abcdefghijkmnopqrstuvwxyz";
            string capitalLetters= "ABCDEFGHJKLMNOPQRSTUVWXYZ";
            string numbers = "0123456789";
            string symbols = "!@$?_-";
            string allCharacters = characters;
            Random rnd = new Random();
            // Menu
            Console.WriteLine("Password Generator");
            Console.WriteLine("==================");
            // Pass Length
            Console.WriteLine("\n\nPassword Length (1 - 36)");
            passLength = int.Parse(Console.ReadLine());
            // Range check
            while (passLength < 1 || passLength > 36)
            {
                Console.WriteLine("Out of range number");
                Console.WriteLine("\n\nPassword Length (1 - 36)");
                passLength = int.Parse(Console.ReadLine());
            }
            // Options
            char[] passChar = new char[passLength];
            Console.WriteLine("Include Capitals Letters? Indicate y/n");
            char decUpp = char.Parse(Console.ReadLine());
            Console.WriteLine("Include Numbers? Indicate y/n");
            char decNum = char.Parse(Console.ReadLine());
            Console.WriteLine("Include Symbols? Indicate y/n");
            char decSim = char.Parse(Console.ReadLine());
            // Check options
            if (decUpp.Equals('y'))
            {
                allCharacters += capitalLetters;
            }
            if (decNum.Equals('y'))
            {
                allCharacters += numbers;
            }
            if (decSim.Equals('y'))
            {
                allCharacters += symbols;
            }
            // Generate password
            for (int i = 0; i < passLength; i++)
            {
                passChar[i] = allCharacters[rnd.Next(0, allCharacters.Length)];
            }
            result = new string(passChar);
            // Show password
            Console.Write("Password generated: " + result);
            // Generate another passwords
            do
            {
                Console.WriteLine("\nIndicate 'y' to generate another password or 'n' to finish");
                ans = char.Parse(Console.ReadLine());
                if (ans == 'y')
                {
                    for (int i = 0; i < passLength; i++)
                    {
                        passChar[i] = allCharacters[rnd.Next(0, allCharacters.Length)];
                    }
                    result = new string(passChar);
                    Console.Write("Password generated: " + result);
                }    
            } while (ans == 'y');

            Console.ReadKey();
        }
    }
}
