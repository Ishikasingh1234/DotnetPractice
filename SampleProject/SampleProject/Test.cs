using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICEAPP
{
    public partial class test
    {

        public void display()
        {
            Console.WriteLine("This is");
        }

    }
    public partial class test
    {

        public void display1()
        {
            Console.WriteLine(" first part of partial class");
        }

        static void Main(string[] args)

        {
            test objtest = new test();
            objtest.display();
            objtest.display1();
        }


    }


}
