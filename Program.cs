using System;

namespace delegate_more_argument
{

    public delegate void DelWithMoreArg(string firstname, string lastname);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var moreArgments = new DelWithMoreArg(MoreArgs);
            moreArgments.Invoke("Marthanda","varma");
        }

        public static void MoreArgs(string firstname, string lastname)
        {
            Console.WriteLine($"Welcome {firstname} {lastname}");
        }
    }
}
