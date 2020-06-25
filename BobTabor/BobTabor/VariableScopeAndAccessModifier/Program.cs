using System;

namespace VariableScopeAndAccessModifier
{
    class Program
    {
        private static string k = "";
        static void Main(string[] args)
        {
            string j = "";

            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();
                k = i.ToString();
                Console.WriteLine(i);
            }
            //Console.WriteLine(i);
            Console.WriteLine("Out side of for: " + j);
            Console.WriteLine("Out side of for: " + k);

            HelperMethod();

            Car myCar = new Car();
            myCar.DoSomething();

            Console.ReadLine();
        }

        static void HelperMethod()
        {
            Console.WriteLine("Value of k from HelperMethod(): " + k);
        }
    }
    class Car
    {
        public void DoSomething()
        {
            Console.WriteLine(helperMethod());
        }

        private string helperMethod()
        {
            return "Hello World!!";
        }
    }
    
}
