using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Basics;

namespace Learn
{
    class Parent
    {
        public int a;
        public int b;

        public Parent()
        { }

        public Parent(int a)
        {
            this.a = a;
        }

        public Parent(int a,int b)
        {
            this.a = a;
            this.b = b;
        }

        public virtual void Increment()
        {
            a++;
        }
    }

    class Child : Parent
    {
        public Child()
        { }

        public Child(int a) : base(a)
        {}

        public Child(int a,int b) : base(a,b)
        {}

        public override void Increment()
        {
            a++;
            b++;
        }
    }

    class Calculator<T>
    {
        public void Add(T a,T b)
        {
            Console.WriteLine(a is int);
        }
    }

    class Delegates
    {
        delegate int sub(int a, int b);

        static int Add(int a,int b)
        {
            return a + b;
        }

        public static void GetExplanantion()
        {
            sub a = new sub(Add);

            Func<int, int, int> s = new Func<int,int,int>(Add);
            Console.WriteLine(s(1, 2));
        }
    }

    class Pointer
    {
        public static void Increment(ref int a)
        {
            a++;
        }

        public static void Assign(out int a)
        {
            a = 10;
        }
    }

    class Constants
    {
        const int a = 10;
        readonly int b;

        Constants()
        {
            b = 10;
        }
    }

    class ISOperator
    {
        ISOperator()
        {
            var a = 1;

            Console.WriteLine(a is string);
            Console.WriteLine(a is int);

            Child b = new Child();

            Console.WriteLine(b is Parent);
        }
    }

    class ASOperator
    { 
        public ASOperator()
        {
            ArrayList arr = new ArrayList();
            arr.Add("ajay");
            arr.Add(1);
            arr.Add("meow");
            arr.Add(null);

            foreach(var i in arr)
            {
                Console.WriteLine(i as int?);
            }
        }
    }

    class Nullable
    {
        public Nullable()
        {
            // int a = null;
            int? b = null;


            // NULL CALESCING OPERATOR
            int c = b ?? -1;
        }
    }

    class AccessModifiers
    {
        public int a;
        private int b;
        protected int c;
        internal int d;
        protected internal int e;
        private protected int f;
        readonly int g = 10;
        const int h = 10;
    }

    class Using
    {
        public Using()
        {

        }
    }

    static class Extension
    { 
        public static bool IsArmstrong(this int i)
        {
            int temp = 0,t = i;

            while(t > 0)
            {
                temp += ((t % 10) * (t % 10) * (t % 10));
                t = t / 10;
            }

            return temp == i;
        }
    }

    class Container
    {
        private int[] arr;

        public Container()
        {
            arr = new int[10];
        }

        public int this[int index]
        {
            get
            {
                return arr[index];
            }

            set
            {
                arr[index] = value;
            }
        }
    }

    sealed class Sealed
    {}

    /*class SealedChild : Sealed
    { }*/

    class Boxing
    {
        public Boxing()
        {
            int i = 123;
            Object o = i;

            int j = (int)o;
        }
    }

    [Serializable]
    class Serialization
    {
        int a;

        public Serialization()
        {
            a = 10;
        }

        public void PrintInt()
        {
            Console.WriteLine(a);
        }
    }

    class Destructor
    {
        public Destructor()
        { }

        ~Destructor()
        {
            Console.WriteLine("Object is destroyed");
        }
    }

    interface Car
    {
        void Accelerate();
        void Decelerate();
    }

    enum Switch
    {
        ON = 0,
        OFF = 1
    }

    struct Node
    {
        int val;
    }

    class Reflection
    {
        public Reflection()
        {
            int i = 10;
            Type t = i.GetType();

            Console.WriteLine(t.Name);
        }

        // LATE BINDING - SUB CONCEPT WHICH ALLOWS US TO CREATE OBJECT WITHOUT NEW KEYWORD
    }

    class AnonymousFunction
    {
        public AnonymousFunction()
        {
            Func<int, int> f = delegate (int a)
            {
                return a * 2;
            };

            Console.WriteLine(f(2));
        }
    }

    class AsyncAndAwait
    {
        public async Task<int> ReturnInt()
        {
            await Task.Delay(10000);
            return 10;
        }

        public void GetExplanation()
        {
            Task<int> t = ReturnInt();
            Console.WriteLine(t.Result);
        }

        public AsyncAndAwait()
        {
            GetExplanation();
        }
    }

    class Lesson
    { 
        public static void Main(string[] args)
        {
            AsyncAndAwait r = new AsyncAndAwait();
        }
    }
}
