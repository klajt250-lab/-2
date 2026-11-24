using System.Globalization;
using System;

namespace Massiv
   
    {
        class Math
        {
        internal int sum(double num1, int num2)
        {
            return (int)(num1 + num2);
        }
        internal int Sub(double num1, int num2)
        {
            return (int)(num1 - num2);

        }

        internal int Mul(double num1, int num2)
        {
            return (int)(num1 * num2);
        }
        internal int Div(double num1, int num2)
            {
                if (num2 == 0)
                {
                    throw new DivideByZeroException("Division by zero!");
                }
            return (int) num1 / num2;
            }
        internal int IntDiv(double num1, int num2)
            {
                if (num2 == 0)
                {
                    throw new DivideByZeroException("Division by zero!");
                }
                return (int) num1 / num2;
            }
        public static double Percent(double total, double percent)
        {
            return (int) total * percent / 100;
        }

        public double DePercent(double part, double percent)
            {
               
                return part * 100 / percent;
            }
        internal int Count(List<double> numbers)
            {
                int count = 0;
                foreach (double n in numbers)
                {
                    count++;
                }
                return count;
            }
        internal int Max(List<double> numbers)
            {
                double max = numbers[0];
                for (int i = 1; i < numbers.Count; i++)
                {
                    if (numbers[i] > max)
                    {
                        max = numbers[i];
                    }
                }
                return max;
            }

        internal int Min(List<double> numbers)
            {
                double min = numbers[0];
                for (int i = 1; i < numbers.Count; i++)
                {
                    if (numbers[i] < min)
                    {
                        min = numbers[i];
                    }
                }
                return min;
            }

        internal int Factorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("The factorial of a negative number does not exist!");
            }
            if (n > 20)
            {

                throw new ArgumentException("The number is too large; an overflow will occur!");
            }

            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result = result * i;
            }
            return result;
        }

     
    
    }
}
            