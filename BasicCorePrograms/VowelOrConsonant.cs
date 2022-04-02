using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class VowelOrConsonant
    {
        public static void CheckAlphabet()
        {
            char character;
            Console.WriteLine("Enter the character : ");
            character = Convert.ToChar(Console.ReadLine());
            
            if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u' ||
                character == 'A' || character == 'E' || character == 'I' || character == 'O' || character == 'Y')
            {
                Console.WriteLine("{0} is vowel.",character);
            }
            else
            {
                Console.WriteLine("{0} is consonant.", character);
            }
        }
    }
}
