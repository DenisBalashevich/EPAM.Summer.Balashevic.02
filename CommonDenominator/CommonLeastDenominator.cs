using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace CommonDenominator
{
    public static class CommonLeastDenominator
    {
        private delegate int CLDDelegate(int a, int b);
        public static int EuclidianAlgorithm(int a, int b)
        {
            int mod = 0;

            if (a < b)
            {
                Swap(ref a, ref b);
            }

            while (b != 0)
            {
                mod = a % b;
                a = b;
                b = mod;
            }

            return Math.Abs(a);
        }
        public static int EuclidianAlgorithm(int a, int b, int c)
        {
            int d = EuclidianAlgorithm(a, b);
            return Math.Abs(EuclidianAlgorithm(c, d));
        }
        public static int EuclidianAlgorithm(params int[] arr)
        {
            var del = new CLDDelegate(EuclidianAlgorithm);
            return CommonDenominator(EuclidianAlgorithm, arr);
        }
        public static int EuclidianAlgorithmTime(out long time, params int[] arr)
        {
            var del = new CLDDelegate(EuclidianAlgorithm);
            Stopwatch timeWork = new Stopwatch();
            timeWork.Start();
            int result = CommonDenominator(del, arr);
            timeWork.Stop();
            time = timeWork.ElapsedTicks;
            return Math.Abs(result);
        }
        public static int SteinsAlgorithm(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            if (a < 0)
                return Math.Abs(a);
            if (b < 0)
                return Math.Abs(b);
            if (a == b)
                return a;

            if (a == 0)
                return b;
            if (b == 0)
                return a;

            if (a % 2 == 0)
            {
                if (b % 2 != 0)
                    return SteinsAlgorithm(a >> 1, b);
                else
                    return SteinsAlgorithm(a >> 1, b >> 1) << 1;
            }

            if (b % 2 == 0)
                return SteinsAlgorithm(a, b >> 1);

            if (a > b)
                return SteinsAlgorithm((a - b) >> 1, b);

            return SteinsAlgorithm((b - a) >> 1, a);
        }
        public static int SteinsAlgorithm(int a, int b, int c)
        {
            int d = SteinsAlgorithm(a, b);
            return Math.Abs(SteinsAlgorithm(c, d));
        }
        public static int SteinsAlgorithm(params int[] arr)
        {
            var del = new CLDDelegate(SteinsAlgorithm);
            return CommonDenominator(SteinsAlgorithm, arr);
        }
        public static int SteinsAlgorithmTime(out long time, params int[] arr)
        {
            var del = new CLDDelegate(SteinsAlgorithm);
            Stopwatch timeWork = new Stopwatch();
            timeWork.Start();
            int result = CommonDenominator(del, arr);
            timeWork.Stop();
            time = timeWork.ElapsedTicks;
            return Math.Abs(result);
        }
        private static int CommonDenominator(CLDDelegate a, params int[] arr)
        {
            if (arr == null)
                throw new ArgumentException("parametr is null");
            if (arr.Length == 0)
                throw new ArgumentException("parametr is invalid");

            int cld = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                cld = a(arr[i], cld);
            }
            return Math.Abs(cld);
        }
        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
