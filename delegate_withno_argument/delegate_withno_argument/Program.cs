using System;

namespace delegate_withno_argument
{
    public delegate string DelegateWithArguemnt();

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var WithArg = new DelegateWithArguemnt(WithArgument);
            string name = WithArg.Invoke();
            Console.WriteLine(name);
        }

        public static string WithArgument()
        {
            string name = "Nandu";
            return name;
        }
    }
    
}
