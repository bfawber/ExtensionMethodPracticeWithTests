using System;
using System.Collections.Generic;

namespace Exercise1
{
    public static class StringExtensions
    {
		/**
		 * Exercise: 
		 * Create a string extension metbod called MuffinReverse to return the string reversed. 
		 * Example: if you have:
		 * string str = "bryan";
		 * when you call str.MuffinReverse() it should return "nayrb"
		 * 
		 * Extension Methods Documentation:
		 * https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
		 * 
		 * Then properly test it using Unit Tests
		 * 
		 * WHEN FINISHED CREATE A NEW BRANCH IN GITHUB, PUSH IT, AND CREATE A PULL REQUEST TO MASTER
		 * Resource for github:
		 * https://try.github.io/levels/1/challenges/1
		 */


		/// <summary>
		/// Example extension method that will return the last character of a string.
		/// This can be called using any string variable. Example:
		/// string str = "hello world";
		/// char lastChar = str.LastChar();
		/// </summary>
		/// <param name="str">The string to get the last character from</param>
		/// <returns>The last character in the string</returns>
		public static char LastChar(this string str)
		{
			return str[str.Length - 1];
		}

        public static string MuffinReverse(this string str)
        {
            List<String> lTempStr = new List<String>();
            if (str == "")
            {
                return "";
            }
            else
            {
                for (int i = 1; i <= str.Length; i++)
                {
                    lTempStr.Add(str.Substring(str.Length - i, 1));
                }
                return String.Join("", lTempStr);
            }
        }
    }
}
