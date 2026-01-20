using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICEAPP

  {

        

class ReverseArray
    {
        static string ReverseString(string text)
        {
            // Method 1: Manual swap with array
            char[] chars = text.ToCharArray();

            for (int i = 0; i < chars.Length / 2; i++)
            {
                // Swap i-th character from start with i-th from end
                char temp = chars[i];
                chars[i] = chars[chars.Length - 1 - i];
                chars[chars.Length - 1 - i] = temp;
            }

            return new string(chars);
        }

        static void Main()
        {
            string original = "ISHIKA SINGH";
            string reversed = ReverseString(original);

            Console.WriteLine($"Original: {original}");
            Console.WriteLine($"Reversed: {reversed}");
            // Output: Original: ABCDE
            //         Reversed: EDCBA
        }
    }
}

