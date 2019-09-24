using System;
using System.Numerics;

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
                if (s && number >= 0 && number <= 10000)
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


