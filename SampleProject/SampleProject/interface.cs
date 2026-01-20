using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICEAPP
{


    // Define interface
    public interface ICalculator
    {
        int Add(int a, int b);
        int Subtract(int a, int b);
    }

    // Implement interface
    public class BasicCalculator : ICalculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }
    }

    class InteritanceExample
    {
        static void Main()
        {
            // Create instance using interface type
            ICalculator calc = new BasicCalculator();

            // Use interface methods
            int sum = calc.Add(10, 5);
            int difference = calc.Subtract(10, 5);

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Difference: {difference}");

            // Real-world example
            Console.WriteLine("\nReal example:");
            PaymentProcessor processor = new PaymentProcessor();
            processor.ProcessPayment(new CreditCardPayment(), 100);
            processor.ProcessPayment(new PayPalPayment(), 50);
        }
    }

    // Another practical example
    public interface IPayment
    {
        bool Pay(decimal amount);
    }

    public class CreditCardPayment : IPayment
    {
        public bool Pay(decimal amount)
        {
            Console.WriteLine($"Paid ${amount} with Credit Card");
            return true;
        }
    }

    public class PayPalPayment : IPayment
    {
        public bool Pay(decimal amount)
        {
            Console.WriteLine($"Paid ${amount} with PayPal");
            return true;
        }
    }

    public class PaymentProcessor
    {
        public void ProcessPayment(IPayment payment, decimal amount)
        {
            payment.Pay(amount);
        }
    }
}