using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICEAPP
{
     class Destructor
    {
        public Destructor()
        {
            Console.WriteLine("Constructor called: Object is being created.");
        }

        ~Destructor()
        {
            {
                //string type = GetType().Name;
                //Console.WriteLine($"Object {type} is Destroyed");
            }

            Console.WriteLine("Destructor called: Object is being destroyed.");

        }

        static void Main(string[] args)
        {
            Destructor obj1 = new Destructor();

            //Making obj1 for Garbage Collection


            // Forcing garbage collection to see the destructor in action

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }

}
