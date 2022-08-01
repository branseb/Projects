﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    public static class Extensions
    {
        public static string multyply(this string text, int times)
        {
            string result = string.Empty;
            for (int i = 0; i < times; i++)
            {
                result = result + text;
            }
            return result;

        }
        public static void Log(this object text)
        {
            Console.WriteLine(text);
        }

        public static bool Neg(this bool boolean)
            => !boolean;
    }
}
