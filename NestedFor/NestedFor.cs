namespace cgxarrie.utils.NestedFor
{
    using System;

    public static class NestedFor
    {
        public static void Loop<T1, T2>(this (T1[] index1, T2[] index2) array, Action<T1, T2> func)
        {
            foreach (var i in array.index1)
            {
                foreach (var j in array.index2)
                {
                    func(i, j);
                }
            }
        }

        public static void Loop<T1, T2, T3>(this (T1[] index1, T2[] index2, T3[] index3) array, Action<T1, T2, T3> func)
        {
            foreach (var i in array.index1)
            {
                foreach (var j in array.index2)
                {
                    foreach (var k in array.index3)
                    {
                        func(i, j, k);
                    }
                }
            }
        }

        public static void Loop<T1, T2, T3, T4>(this (T1[] index1, T2[] index2, T3[] index3, T4[] index4) array, Action<T1, T2, T3, T4> func)
        {
            foreach (var i in array.index1)
            {
                foreach (var j in array.index2)
                {
                    foreach (var k in array.index3)
                    {
                        foreach (var l in array.index4)
                        {
                            func(i, j, k, l);
                        }
                    }
                }
            }
        }

        public static void Loop<T1, T2, T3, T4, T5>(this (T1[] index1, T2[] index2, T3[] index3, T4[] index4, T5[] index5) array, Action<T1, T2, T3, T4, T5> func)
        {
            foreach (var i in array.index1)
            {
                foreach (var j in array.index2)
                {
                    foreach (var k in array.index3)
                    {
                        foreach (var l in array.index4)
                        {
                            foreach (var m in array.index5)
                            {
                                func(i, j, k, l, m);
                            }
                        }
                    }
                }
            }
        }

        public static void Loop<T1, T2, T3, T4, T5, T6>(this (T1[] index1, T2[] index2, T3[] index3, T4[] index4, T5[] index5, T6[] index6) array, Action<T1, T2, T3, T4, T5, T6> func)
        {

            foreach (var i in array.index1)
            {
                foreach (var j in array.index2)
                {
                    foreach (var k in array.index3)
                    {
                        foreach (var l in array.index4)
                        {
                            foreach (var m in array.index5)
                            {
                                foreach (var n in array.index6)
                                {
                                    func(i, j, k, l, m, n);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
