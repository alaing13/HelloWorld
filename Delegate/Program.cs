using System;

namespace Delegate
{

    public delegate void Del(string message);
    class Program
    {
        public static void DelegateMethod1(string message)
        {
            System.Console.WriteLine(message + " 1");
        }
        public static void DelegateMethod2(string message)
        {
            System.Console.WriteLine(message + " 2");
        }
        static void Main()
        {
            Del handler = DelegateMethod1;
            handler += DelegateMethod2;
            handler("Hello World");
            handler -= DelegateMethod1;
            handler("Hello World"); 
            Console.ReadLine();
        }
    }
}
