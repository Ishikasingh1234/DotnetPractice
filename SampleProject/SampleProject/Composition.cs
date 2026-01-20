using System;


namespace PRACTICEAPP
{

    // Composition: A Car HAS AN Engine
    public class Engine
    {
        public void Start()
        {
            Console.WriteLine("Engine roaring to life...");
        }

        public void Stop()
        {
            Console.WriteLine("Engine shutting down...");
        }
    }

    public class Wheels
    {
        public void Rotate()
        {
            Console.WriteLine("Wheels turning...");
        }
    }

    // Car is composed of Engine and Wheels
    public class MOtarVehicle
    {
        public string Brand { get; set; }
        private Engine engine;  // HAS-A Engine (composition)
        private Wheels wheels;  // HAS-A Wheels (composition)

        public MOtarVehicle(string brand)
        {
            Brand = brand;
            engine = new Engine();
            wheels = new Wheels();
        }

        public void Drive()
        {
            Console.WriteLine($"{Brand} is driving");
            engine.Start();
            wheels.Rotate();
        }
    }

    // Using composition
    class Program
    {
        static void Main()
        {
            Car myCar = new Car("Honda");
            myCar.Drive();
        }
    }
}
