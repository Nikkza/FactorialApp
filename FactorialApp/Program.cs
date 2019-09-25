using System;
using System.Numerics;
using System.Threading;

namespace FactorialApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string value = Console.ReadLine();
                if (value == "close")
                {
                    Console.Write("Closing program in ");
                    for (int a = 3; a >= 0; a--)
                    {
                        Console.CursorLeft = 19;
                        Console.Write("{0} ", a);
                        Thread.Sleep(1000);
                    }
                    break;
                }
                string subString = string.Empty;
                string trimmedValue = string.Empty;
                BigInteger getReturnedNumber = 0;

                bool validNumber = BigInteger.TryParse(value, out BigInteger number);
                if (validNumber && number >= 0 && number <= 10000)
                {
                    getReturnedNumber = DisplayNumber(number);
                    if (!getReturnedNumber.Equals(null))
                    {

                        try
                        {
                            if (getReturnedNumber.ToString().Length <= 3)
                                Console.WriteLine($"number is {getReturnedNumber.ToString()}");
                            else
                            {
                                string str = Convert.ToString(getReturnedNumber);
                                trimmedValue = str.TrimEnd('0');
                                subString = trimmedValue.Substring(trimmedValue.Length - 3);
                                Console.WriteLine($"number is {subString}");
                            }
                        }
                        catch (Exception err)
                        {
                            throw err;
                        }
                    }

                }
                else
                    Console.WriteLine($"Value can not be(A - Ö) Number must start from (0) " +
                        $"or number is to big {number}");
            }

        }

        public static BigInteger DisplayNumber(BigInteger number)
        {
            BigInteger fact = 1;
            while (number != 0)
            {
                fact *= number;
                number -= 1;
            }
            return fact;
        }
    }
}


