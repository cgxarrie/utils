namespace NestedForConsole
{
    using NestedFor;
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Enumerable.Range(1, 2).ToArray();
            int[] arr2 = Enumerable.Range(1, 3).ToArray();
            int[] arr3 = Enumerable.Range(1, 4).ToArray();
            int[] arr4 = Enumerable.Range(1, 5).ToArray();
            int[] arr5 = Enumerable.Range(1, 6).ToArray();
            int[] arr6 = Enumerable.Range(1, 7).ToArray();

            (arr1, arr2).Loop(Test12);
            (arr1, arr2, arr3).Loop(Test123);
            (arr1, arr2, arr3, arr4).Loop(Test1234);
            (arr1, arr2, arr3, arr4, arr5).Loop(Test12345);
            (arr1, arr2, arr3, arr4, arr5, arr6).Loop(Test123456);

        }

        private static void Test12(int idx1, int idx2)
        {
            var xtimesy = idx1 * idx2;
            Console.WriteLine($"Test12 ({idx1},{idx2}) = {xtimesy}");
        }

        private static void Test123(int idx1, int idx2, int idx3)
        {
            var xtimesy = idx1 * idx2 * idx3;
            Console.WriteLine($"Test123 ({idx1},{idx2},{idx3}) = {xtimesy}");
        }

        private static void Test1234(int idx1, int idx2, int idx3, int idx4)
        {
            var xtimesy = idx1 * idx2 * idx3 * idx4;
            Console.WriteLine($"Test1234 ({idx1},{idx2},{idx3},{idx4}) = {xtimesy}");
        }

        private static void Test12345(int idx1, int idx2, int idx3, int idx4, int idx5)
        {
            var xtimesy = idx1 * idx2 * idx3 * idx4;
            Console.WriteLine($"Test12345 ({idx1},{idx2},{idx3},{idx4}) = {xtimesy}");
        }

        private static void Test123456(int idx1, int idx2, int idx3, int idx4, int idx5, int idx6)
        {
            var xtimesy = idx1 * idx2 * idx3 * idx4 * idx5 * idx6;
            Console.WriteLine($"Test123456 ({idx1},{idx2},{idx3},{idx4},{idx5},{idx6}) = {xtimesy}");
        }
    }
}
