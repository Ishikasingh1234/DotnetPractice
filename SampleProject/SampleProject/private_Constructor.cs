using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICEAPP
{
     class Private_Constructor{
   

        // Variables
        public static string name;
        public static int num;

        // Creating private Constructor
        // using private keyword
        private Private_Constructor()
        {

            Console.WriteLine("Welcome to Private Constructor");
        }

        // Default Constructor
        // with parameters
        public Private_Constructor(string a, int b)
        {

            name = a;
            num = b;
        }
    }

    // Driver Class
    class Constructor_Private
    {

        // Main Method
        static void Main()
        {

            // This line raises error because
            // the constructor is inaccessible

            // Here, the only default 
            // constructor will invoke
            Private_Constructor obj2 = new Private_Constructor("Eshika Singh", 2);

            // Here, the data members of Geeks
            // class are directly accessed
            // because they are static members
            // and static members are accessed 
            // directly with the class name
            Console.WriteLine(Private_Constructor.name + ", " + Private_Constructor.num);
        }
    }


}

