using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace BlackLight.Recruitment.UnitTests
{
    class Algorithms
    {
        public static string ReverseWordsInString(string input)
        {
            return string.Join(" ", input.Split(' ').Reverse());
        }

        public static string ReverseWordsInStringWithoutUsingAnyLinqMethods(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                throw new NotImplementedException();

            string[] words = input.Split(' ');
            Array.Reverse(words);
            return string.Join(" ", words);

        }

        internal static int[] SortWithoutUsingBuiltInSortMethods(int[] input)
        {

            var arr = input;

            int temp = 0;

            for (int write = 0; write < arr.Length; write++)
            {
                for (int sort = 0; sort < arr.Length - 1; sort++)
                {
                    if (arr[sort] > arr[sort + 1])
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }
                }
            }

            return arr;
        }
    }
}
