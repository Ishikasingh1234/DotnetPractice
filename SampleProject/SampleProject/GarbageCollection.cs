using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICEAPP
{
    class GarbageCollection
    {

        static void Main(string[] args)
        {
            // Creating an object of the class
            for ( double i= 0; i<10000000; i++)
            {
                               GarbageCollection obj = new GarbageCollection();
            }Console.WriteLine("Garbage Collection Invoked");


        }


    }
}



