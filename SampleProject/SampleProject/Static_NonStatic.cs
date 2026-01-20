using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICEAPP
{
   class Static_NonStatic
    {

        // Static variable
        static int s;

        // Non-static variable
        int ns;

        // Declaration of
        // static constructor
        static Static_NonStatic()
        {
            Console.WriteLine("It is static constructor");
        }

        // Declaration of
        // non-static constructor
        public Static_NonStatic()
        {
            Console.WriteLine("It is non-static constructor");
        }

        // Main Method
        static void Main(string[] args)
        {

            // Static constructor will call implicitly
            // as soon as the class start to execute
            // the first block of code to execute
            // will be static constructor

            // Calling non-static constructor
            Static_NonStatic obj1 = new Static_NonStatic();
        }
    }
}

