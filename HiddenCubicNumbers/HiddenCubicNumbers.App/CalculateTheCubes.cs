using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace HiddenCubicNumbers.App
{
    public class CalculateTheCubes : ICalculateTheCubes
    {
        public string isSumOfCubes(string s)
        {
            String[] subString = Regex.Split(s, @"\D");
            String[] numbers = subString.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            string result = null;
            double sum = 0;
            double totalSum = 0;

            foreach (var number in numbers)
            {
                if(number.Length > 3)
                {
                    for (int i = 0; i < number.Length; i += 3)
                    {
                        var threeDigitNumber =  number.Substring(i, Math.Min(3, number.Length - i));

                        char[] threeDigitNumberDigits = threeDigitNumber.ToCharArray();

                        foreach (var digit in threeDigitNumberDigits)
                        {
                            sum += Math.Pow(Char.GetNumericValue(digit), 3);
                        }

                        if(sum == Convert.ToDouble(threeDigitNumber))
                        {
                            result += $"{threeDigitNumber} ";
                            totalSum += sum;
                        }
                        sum = 0;
                    }
                }
                else
                {
                    char[] digits = number.ToCharArray();

                    foreach (var digit in digits)
                    {
                        sum += Math.Pow(Char.GetNumericValue(digit), 3);
                    }

                    if (sum == Convert.ToDouble(number))
                    {
                        result += $"{number} ";
                        totalSum += sum;
                    }
                    sum = 0;
                }                
            }

            if(!String.IsNullOrEmpty(result))
            {
                return $"{result}{totalSum} Lucky";
            }

            return "Unlucky";
        }
    }
}
