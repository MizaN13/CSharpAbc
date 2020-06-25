using System;

namespace IfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isHungry = true;
            int charge = 77;
            bool isCloudy = true;

            if (isHungry)
            {
                Console.WriteLine("I am Hungry");
            }
            else
            {
                Console.WriteLine("I am not Hungry");
            }
            if (charge <= 5)
            {
                Console.WriteLine("Battery is dying");
            }
            else
            {
                Console.WriteLine("Battery is fine");
            }
            if (isCloudy)
            {
                Console.WriteLine("Bring my Umbralla");
            }
            else
            {
                Console.WriteLine("It is sunny");
            }

            bool isMale = true;
            bool isTall = true;

            if (!isMale && !isTall)
            {
                Console.WriteLine("You are a Tall Male");
            }
            else if (isMale && !isTall)
            {
                Console.WriteLine("You are a Short Male");
            }
            else if (!isMale && isTall)
            {
                Console.WriteLine("You are Tall but not Male");
            }
            
            else
            {
                Console.WriteLine("You are neither male nor tall or both");
            }

            Console.WriteLine(GetMax(4, 2, 9));

            Console.ReadLine();
        }

        static int GetMax(int num1, int num2,int num3)
        {
            int result;
            if (num1 > num2 && num1 > num3)
            {
                result = num1;
            }
            else if (num2 > num1 && num2 > num3)
            {
                result = num2;
            }
            else
            {
                result = num3;
            }

            return result;
        }
    }
}
