using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nsfxr
{
    internal static class GetRandom
    {
        private static readonly Random _random = new Random();

        public static float Float()
        {
            return Float(0, 1);
        }
        public static float Float(float max)
        {
            return Float(0, max);
        }
        public static float Float(float min, float max)
        {
            return (float)(min + (_random.NextDouble() * (max - min)));
        }
    }
}
