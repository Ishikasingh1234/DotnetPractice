using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICEAPP
{
    
// Inheritance: A Car IS A Vehicle
public class Inhertance
    {
        public string Brand { get; set; }

        public Inhertance(string brand)
        {
            Brand = brand;
        }

        public void Start()
        {
            Console.WriteLine($"{Brand} is starting...");
        }
    }

    // Car inherits from Vehicle
    public class Car : Inhertance // Car IS A Vehicle
    {
        public Car(string brand) : base(brand) { }

        public void Honk()
        {
            Console.WriteLine($"{Brand} goes BEEP BEEP!");
        }

        internal void Drive()
        {
            throw new NotImplementedException();
        }
    }

    // Using inheritance
    class Vechicletest
    {
        static void Main()
        {
            Car myCar = new Car("Toyota");
            myCar.Start();  // Inherited from Vehicle
            myCar.Honk();   // Car's own method
        }
    }
}

