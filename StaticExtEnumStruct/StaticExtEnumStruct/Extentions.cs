using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExtEnumStruct
{
    static class Extentions
    {
        public static char[] SplitLetter(this string txt)
        {
            char[] letters = new char[txt.Length];

            for (int i = 0; i < txt.Length; i++)
            {
                letters[i] = txt[i];
            }

            return letters;
        }

        public static int SumOfDigits(this int number)
        {
            int r = 0;
            int sum = 0;
            while (number>0)
            {
                r = number % 10;
                sum += r;

                number = (number - r) / 10;
            }

            return sum;
        }
    }
}
