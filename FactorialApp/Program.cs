using System;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace FactorialApp
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                string value = Console.ReadLine();
                string subString = string.Empty;
                string trimmedValue = string.Empty;
                BigInteger getReturnedNumber = 0;

                bool s = BigInteger.TryParse(value, out BigInteger number);
                if (!string.IsNullOrEmpty(value) && s)
                {
                    try
                    {
                        getReturnedNumber = DisplayNumber(number);
                        if (!getReturnedNumber.Equals(null))
                        {
                            string str = Convert.ToString(getReturnedNumber);
                            try
                            {
                                if (str.Length <= 3 && !string.IsNullOrEmpty(str))
                                    Console.WriteLine(str);
                                else
                                {
                                    trimmedValue = str.TrimEnd('0');
                                    subString = trimmedValue.Substring(trimmedValue.Length - 3);
                                    Console.WriteLine(subString);
                                }
                            }
                            catch (Exception err)
                            {
                                throw err;
                            }
                        }

                    }
                    catch (InsufficientExecutionStackException ex)
                    {
                        Console.WriteLine("Out of limit");
                    }
                }
                else
                    Console.WriteLine("Value can not be(A - Ö) Number must start from (0)");
            }

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


