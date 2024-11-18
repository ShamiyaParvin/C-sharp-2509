using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Part7
{
    delegate string StringOperationDelegate(string input);
    public class StringOperations
    {
        public static string ConvertUpper(string input)
        {
            return input.ToUpper();
        }

        public static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static string AddPrefix(string input)
        {
            return "Prefix" + input;
        }
    }
}
