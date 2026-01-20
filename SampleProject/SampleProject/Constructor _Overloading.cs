using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICEAPP
{
    internal class Constructor__Overloading
    {

        int caryear;
        float manifacuture;
        string carmodel;
        public int testcount;

        public  Constructor__Overloading(string model, int year, float mani, int testcount)
        {
            // this is initialization of variables
            carmodel = model;
            caryear = year;
            manifacuture = mani;

            this.testcount = testcount;
        }
         public  Constructor__Overloading( int year, string model,float mani)
        {

            
            caryear = year;
            carmodel = model;
            manifacuture = mani;


        }

        static void   Main( string[] args )

        {

            Constructor__Overloading obj = new Constructor__Overloading(1999, "lamborgingi",56.56f);

            //write  constructor details to console

            Console.WriteLine(" Model: " + obj.carmodel);
            Console.WriteLine(" Year: " + obj.caryear);
            Console.WriteLine(" Manufacture: " + obj.manifacuture);
        }


    }

}

