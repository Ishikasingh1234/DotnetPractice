using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICEAPP
{
class Reverse
        {
        // METHOD DEFINITION
        static string ReverseString(string text)
        {
            // 1. Create empty result
            string reversed = "";

            // 2. Loop BACKWARDS through the string
            //    Start: last character
            //    End: first character  
            //    Step: move one step left each time
            for (int i = text.Length - 1; i >= 0; i--)
            {
                // 3. Add current character to result
                reversed += text[i];
            }

            // 4. Return the reversed string
            return reversed;
        }

        static void Main()
        {
            // METHOD CALL
            string original = "Hello World";
            string reversed = ReverseString(original);

            Console.WriteLine($"Original: {original}");
            Console.WriteLine($"Reversed: {reversed}");
            // Output: Original: Hello World
            //         Reversed: dlroW olleH
        }
    }
}

