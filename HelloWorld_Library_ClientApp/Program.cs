using System;
using McMathLib;
using Humanizer;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Read first number   
            Console.Write("Enter Number 1: ");
            var var1 = Console.ReadLine();
            // Convert string to int  
            int num1 = Convert.ToInt32(var1);
            // Read second number  
            Console.Write("Enter Number 2: ");
            var var2 = Console.ReadLine();
            // Convert string to int  
            int num2 = Convert.ToInt32(var2);
            // Read operation type - operator  
            Console.Write("Enter one Operator (Add/Sub/Mul/Div): ");
            var op = Console.ReadLine();

            // Create a class library object and call the Calculate method  
            MathClass math = new MathClass();
            double result = math.Calculate(num1, num2, op);

            Console.WriteLine("Result: {0}", result);

            Console.WriteLine(123.ToWords());//Added Humenizer Package into My project and consumed in-built function.


            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);

        }
    }
}
