using System;

namespace PasswordGenerator
{
    class PassGenerator
    {
        static void Main(string[] args)
        {
            int passLength = 0;
            char ans;
            string result;
            string characters = "abcdefghijkmnopqrstuvwxyz";
            string capitalLetters= "ABCDEFGHJKLMNOPQRSTUVWXYZ";
            string numbers = "0123456789";
            string symbols = "!@$?_-";
            string allCharacters = "";


            Random rnd = new Random();

            Console.WriteLine("Password Generator");
            Console.WriteLine("==================");

            Console.WriteLine("\n\nPassword Length (1 - 36)");
            passLength = int.Parse(Console.ReadLine());

            while (passLength < 1 || passLength > 36)
            {
                Console.WriteLine("Out of range number");
                Console.WriteLine("\n\nPassword Length (1 - 36)");
                passLength = int.Parse(Console.ReadLine());
            }

            char[] passDividido = new char[passLength];

            Console.WriteLine("Include Capitals Letters? Indicate y/n");
            char decMay = char.Parse(Console.ReadLine());

            Console.WriteLine("Include Numbers? Indicate y/n");
            char decNum = char.Parse(Console.ReadLine());

            Console.WriteLine("Include Symbols? Indicate y/n");
            char decSig = char.Parse(Console.ReadLine());

            if (decMay.Equals('n') && decNum.Equals('n') && decSig.Equals('n'))
            {
                allCharacters = characters;   
            }
            else if (decMay.Equals('n') && decNum.Equals('n') && decSig.Equals('y'))
            {
                allCharacters = characters + symbols;
            }
            else if (decMay.Equals('y') && decNum.Equals('y') && decSig.Equals('n'))
            {
                allCharacters = characters + capitalLetters + numbers;
            }
            else if (decMay.Equals('y') && decNum.Equals('n') && decSig.Equals('y'))
            {
                allCharacters = characters + capitalLetters + symbols;
            }
            else if (decMay.Equals('y') && decNum.Equals('n') && decSig.Equals('n'))
            {
                allCharacters = characters + capitalLetters;
            }

            else if (decMay.Equals('n') && decNum.Equals('y') && decSig.Equals('y'))
            {
                allCharacters = characters + numbers + symbols;
            }
            else if (decMay.Equals('y') && decNum.Equals('y') && decSig.Equals('y'))
            {
                allCharacters = characters + capitalLetters + numbers + symbols;      
            }
            for (int i = 0; i < passLength; i++)
            {
                passDividido[i] = allCharacters[rnd.Next(0, allCharacters.Length)];
            }
            result = new string(passDividido);
            Console.Write("Password generated: " + result);
            
            do
            {
                Console.WriteLine("\nIndicate 'y' to generate another password or 'n' to finish");
                ans = char.Parse(Console.ReadLine());
                if (ans == 'y')
                {
                    for (int i = 0; i < passLength; i++)
                    {
                        passDividido[i] = allCharacters[rnd.Next(0, allCharacters.Length)];
                    }
                    result = new string(passDividido);
                    Console.Write("Password generated: " + result);
                }    
            } while (ans == 'y');

            Console.ReadKey();
        }
    }
}