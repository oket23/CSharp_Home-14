using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Home_14
{
    public static class MyExtension
    {

        public static int ToPow(this int num, int power)
        {
            if (power == 0) return 1;
            if(power < 1) return 0;

            int result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= num;
            }
            return result;
        }

        public static T[] TakeSome<T>(this T[] array, int start, int end)
        {
            if (array == null) { throw new ArgumentException(); }

            T[] result = new T[end - start + 1];

            for (int i = start; i <= end; i++)
            {
                result[i - start] = array[i];
            }
            return result;
        }



    }
}
