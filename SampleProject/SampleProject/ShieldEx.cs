using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICEAPP
{
    // Sealed class
    sealed class SealedClass
    {
        // Calling Function
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
    public class SealedClasstest
    {
        const int valConst = 100;
        readonly int valReadOnly = 101;
        // Calling Function

        public SealedClasstest() {
            valReadOnly = 102;
            //valConst = 200;

        }
        public int Substrct(int a, int b)
        {
            return a - b;
        }

        static void Main(string[] args)
        {
            //valConst = 200;
            //valReadOnly = 102;
            int c = SealedClass.Add(10, 20);
            //int multyply = res * 100;
            //Console.WriteLine("Multyply value is :" + multyply);
            int age;
            string name;

            Console.WriteLine("Enter your name: ");

            // using the method
            // typecasting not needed 
            // as ReadLine returns string
            name = Console.ReadLine();

            Console.WriteLine("Enter your age: ");

            // Converted string to int
            age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("Hello " + name + "!"
                            + " You can vote");
            }
            else
            {
                Console.WriteLine("Hello " + name + "!"
                    + " Sorry you can't vote");
            }
        }
    }

}

