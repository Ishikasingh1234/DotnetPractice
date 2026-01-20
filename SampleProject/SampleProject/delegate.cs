using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICEAPP
{


    // 1. DECLARE a delegate type
    delegate void GreetDelegate(string name);

    class DelegateEXAMPLE
    {
        // 2. CREATE methods that match the delegate signature
        static void SayHello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

        static void SayWelcome(string name)
        {
            Console.WriteLine($"Welcome, {name}!");
        }

        static void Main()
        {
            // 3. CREATE a delegate instance
            GreetDelegate greeter;

            // 4. POINT it to a method
            greeter = SayHello;

            // 5. CALL it
            greeter("Alice");  // Output: Hello, Alice!

            // 6. CHANGE what it points to
            greeter = SayWelcome;
            greeter("Bob");    // Output: Welcome, Bob!
        }
    }
}

