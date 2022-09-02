using System;

namespace MethodOverloading
{
    class Program
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public static string Add(int num1, int num2, bool isTrue)
        {
            var sum = num1 + num2;

            if (isTrue == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (isTrue == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else if (isTrue == true && sum < 1)
            {
                return $"{sum} dollars";
            }
            else return sum.ToString();
          
        }
        
        static void Main(string[] args)
        {
            var firstAnswer = Add(3, 3);

            var secondAnswer = Add(3.4m, 8.4m);

            var thirdAnswer = Add(0, 1, true);

            Console.WriteLine($"int add:{firstAnswer}");
            Console.WriteLine($"decimal add:{secondAnswer}");
            Console.WriteLine($"{thirdAnswer}");

        }


    }
}

