


namespace PRACTICEAPP
{


    class Example_Constructor
    {
         int caryear;
         float manifacuture;
         string carmodel;

        private Example_Constructor(string model, int year, float mani)
        {

            carmodel = model;
            caryear = year;
            manifacuture = mani;


        }
        static void Main( )
        {
            Example_Constructor obj = new Example_Constructor("BMW", 2020, 12.11f);

            //write  constructor details to console

            Console.WriteLine(" Model: " + obj.carmodel);
            Console.WriteLine(" Year: " + obj.caryear);
            Console.WriteLine(" Manufacture: " + obj.manifacuture);
        }


    }
}



    



