using System;
using System.Collections.Generic;

namespace Basics
{
    class Arrays
    {
        static void getExplanation()
        {
            int[] oneDimensionArr = { 1, 2, 3, 4 };
            int[,] twoDimensionarr = { { 1, 2 },{ 3, 4 } };
        }
    }

    class Strings
    {
        static void getExplanation()
        {
            string name = "AJAY KUMAR T M";
        }
    }

    class Collection
    { 
        static void GetExplanation() 
        {
            List<string> a = new List<string>();
            Dictionary<int, string> b = new Dictionary<int, string>();
        }
    }

    class Generics<T>
    {
        internal static void GetExplanation(T a,T b)
        {
            Console.WriteLine(a + " " + b);
        }
    }

    class Delegates
    {
        delegate int a(int x, int y);

        static int b(int x,int y)
        {
            return (x + y);
        }

        static void c(int a)
        {
            a = a * 2;
        }

        static bool d(int a)
        {
            return (a % 2 == 0) ? true : false;
        }

        static void GetExplanation()
        {
            a t = new a(b);
            Func<int,int,int> te = new Func<int,int,int>(b);
            Action<int> tem = new Action<int>(c);
            Predicate<int> temp = new Predicate<int>(d);
        }
    }

    class AccessModifiers
    {
        public int a = 10;
        private int b = 10;
        protected int c = 10;
        internal int d = 10;
        protected internal int e = 10;
        private protected int f = 10;
        const int g = 10;
        readonly int h = 10;
    }

    class Pointers
    {
        static void Increment(ref int a)
        {
            a += 1;
        }

        static void Assign(out int a,out int b)
        {
            a = 10;
            b = 10;
        }
    }
}
