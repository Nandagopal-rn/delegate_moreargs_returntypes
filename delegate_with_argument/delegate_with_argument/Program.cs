using System;

namespace delegate_with_argument
{

    public delegate void DelWithArgument(string name);

    class Program
    {
        static void Main(string[] args)
        {
            var withArg = new DelWithArgument(WithArgument);
            withArg.Invoke("Nandu");
        }
        public static void WithArgument(string name)
        {
            Console.WriteLine($"Hello {name} Welcome");
        }
    }
}
