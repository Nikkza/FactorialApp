using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Threading;

namespace FactorialApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = Console.ReadLine();
            BigInteger getReturnedNumber = 0;

            bool s = BigInteger.TryParse(value, out BigInteger number);
            if (!string.IsNullOrEmpty(value) && s)
            {
                try
                {
                    getReturnedNumber = DisplayNumber(number);

                }
                catch (InsufficientExecutionStackException ex)
                {
                    Console.WriteLine("Out of limit");
                    for (int i = 3; i >= 0; i--)
                    {
                        Thread.Sleep(1000);
                        Console.WriteLine($"Out of limi closing program in {i} SEC");
                    }
                    return; 
                }

                string subString = string.Empty;
                string trimmedValue = string.Empty;
                if (!getReturnedNumber.Equals(null))
                {
                    string str = Convert.ToString(getReturnedNumber);
                    try
                    {
                        if (str.Length <= 3 && !string.IsNullOrEmpty(str))
                            Console.WriteLine(str);
                        else
                        {
                            if (str.EndsWith("0"))
                                trimmedValue = str.TrimEnd('0');

                            subString = trimmedValue.Substring(trimmedValue.Length - 3);
                            if (!string.IsNullOrEmpty(subString))
                                Console.WriteLine(subString);
                        }
                    }
                    catch (ArgumentNullException err)
                    {
                        throw err;
                    }
                }
            }
            else
                Console.WriteLine("Value can not be(A - Ö) Number must start from (0)");

            Console.ReadKey();

        }

        public static BigInteger DisplayNumber(BigInteger n)
        {
            if (n == 0)
                return 1;
            else
                RuntimeHelpers.EnsureSufficientExecutionStack();
            return n * DisplayNumber(n - 1);
        }

    }
}


