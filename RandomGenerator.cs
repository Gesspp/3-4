using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arrays
{
        static class RandomGenerator<T>
    {
        static Random random = new Random();
        public static T RandomValue()
        {
            if (typeof(T) == typeof(int)) return (T)(object)RandomInt();
            if (typeof(T) == typeof(double)) return (T)(object)RandomDouble ();
            if (typeof(T) == typeof(bool)) return (T)(object)RandomBool();
            if (typeof(T) == typeof(string)) return (T)(object)RandomString();
            return (T)(object) false;
        }

        public static int RandomInt()
        {
            return random.Next(1, 1000);
        }

        public static double RandomDouble()
        {
            return random.NextDouble();
        }

        public static bool RandomBool()
        {
            int flag = random.Next(1, 3);

            return flag == 1;
        }

        public static string RandomString()
        {
            int length = random.Next(5, 20);string chars = "abcdefghijklmnopqrstuvwxyz!?_-+";
            StringBuilder sb = new StringBuilder(length);

            for (int i = 0; i < length; i++)
            {
                sb.Append(chars[random.Next(chars.Length)]);
            }

            return sb.ToString();
        }
    }
}