using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExtEnumStruct
{
    static class MyMath
    {
        public static int Power(int number, byte pow)
        {
            int result = 1;
            for (int i = 0; i < pow; i++)
            {
                result *= number;
            }
            return result;
        }

       
    }
}
