using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DEM.DotNet.Algorithm
{
    internal class ExerciseGoogle
    {
        //https://leetcode.com/problems/subtract-the-product-and-sum-of-digits-of-an-integer/
        int SubtractProductAndSum(int n)
        {
            return 1;
        }

        //https://www.coderbyte.com/editor/First%20Factorial:Csharp
        static int FirstFactorial(int num)
        {

            // code goes here  
            return num;

        }


        //https://www.coderbyte.com/editor/First%20Reverse:Csharp
        static string FirstReverse(string str)
        {

            // code goes here
            char[] array = str.ToCharArray();
            Array.Reverse(array);

            str = new string(array);

            return str;

            //string sol = "";
            //foreach (char c in str)
            //{
            //    sol = c + sol;
        }

        //https://coderbyte.com/editor/Longest%20Word:Csharp?
        static string LongestWord(string sen)
        {
            // code goes here
            //string[] array = sen.Split(' ');
            //string longest = string.Empty;
            //int countCharacter = 0;

            //for (int i = 0; i < array.Length; i++ )
            //{
            //    if (array[i].Length > countCharacter)
            //        longest = array[i];
            //}

            //return longest.ToString();
            Regex rgx = new Regex(@"[^\w\s]");
            sen = rgx.Replace(sen, "");
            string[] words = sen.Split(' ');

            return words.OrderByDescending(x => x.Length).First();
        }


        //https://www.hackerrank.com/challenges/repeated-string/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup&page=5
        static long repeatedString(string s, long n)
        {
            long size = s.Length, repeated = n / size;
            long left = n - (size * repeated);
            int extra = 0;

            int count = 0;
            for (int i = 0; i < size; i++)
            {
                //Console.Write(s[i]);
                if (s[i] == 'a')
                {
                    ++count;
                }
            }

            for (int i = 0; i < left; i++)
            {
                if (s[i] == 'a')
                {
                    ++extra;
                }
            }

            repeated = (repeated * count) + extra;

            return repeated;

        }


        //https://www.coderbyte.com/editor/Find%20Intersection:Csharp
        static string FindIntersection(string[] strArr)
        {

            // code goes here  
            return strArr[0];

        }



        //https://leetcode.com/problems/sort-array-by-parity/
        int[] SortArrayByParity(int[] nums)
        {
            return nums;
        }
    }
}
