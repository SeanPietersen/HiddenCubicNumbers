using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace HiddenCubicNumbers.App
{
    public class CalculateTheCubes : ICalculateTheCubes
    {
        public string isSumOfCubes(string s)
        {
            var subString = Regex.Matches(s, @"\d{1,3}").ToArray();
            string result = null;
            double sum = 0;
            double totalSum = 0;

            foreach (var match in subString)
            {
                foreach (var digit in match.Value)
                {
                    sum += Math.Pow(Char.GetNumericValue(digit), 3);
                }

                if (sum == Convert.ToDouble(match.Value))
                {
                    if (sum == 0)
                    {
                        result += $"0 ";
                    }
                    else
                    {
                        result += $"{match} ";
                    }
                    totalSum += sum;
                }
                sum = 0;            
            }

            if(!String.IsNullOrEmpty(result))
            {
                return $"{result}{totalSum} Lucky";
            }

            return "Unlucky";
        }
    }
}
