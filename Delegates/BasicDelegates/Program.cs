using System;

namespace BasicDelegates
{
    public delegate void PrintDelegate();

    class Program
    {
        static void Main(string[] args)
        {
            var delegateBasic = new PrintDelegate(PrintDel);
            delegateBasic.Invoke();
        }
        public static void PrintDel()
        {
            Console.WriteLine("Welcome to delegate methods");
        }
    }
}
