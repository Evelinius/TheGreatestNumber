using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryinggreatestnumber
{

    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string nums = Console.ReadLine();
            string result = "";
            string extractedNumers = ExtractNumbers(nums);

            result = nums.Contains('-') 
                ? String.Concat(extractedNumers.OrderBy(s => s)) 
                : String.Concat(extractedNumers.OrderByDescending(s => s));
            
            if (nums.Contains('.'))
            {
                if (result.Contains('-'))
                {
                    result = result.Insert(2, ".");
                }
                else
                {
                    if (!result.Contains("0"))
                    {

                        result = result.Insert(result.Length - 1, ".");
                    }
                }
            }


            Console.WriteLine(double.Parse(result.Replace(".", ",")));
        }

        static string ExtractNumbers(string str)
        {
            string result = "";
            string numres = "1234567890";
            for (int i = 0; i < str.Length; i++)
            {
                if (numres.Contains(str[i]))
                {
                    result += str[i];
                }
            }
            return result;
        }
    }
}