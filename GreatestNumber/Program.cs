using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace tryinggreatestnumber
{

    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string nums = Console.ReadLine();
            string result = "";
            string extractedNumers = String.Concat(nums.Where(n => Char.IsDigit(n)));

            result = nums.Contains('-')
                ? '-' + String.Concat(extractedNumers.OrderBy(s => s))
                : String.Concat(extractedNumers.OrderByDescending(s => s));

            if (nums.Contains('.'))
            {
                result = nums.Contains('-') ? result.Insert(2, ".") : result.Insert(result.Length - 1, ".");

            }
            CultureInfo culture = CultureInfo.InvariantCulture;
            Console.WriteLine(double.Parse(result, culture.NumberFormat));
        }
    }
}