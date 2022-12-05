using System;

namespace delegate_moreargs_returntypes
{

    public delegate int DelMoreArgAndReturn(int firstnumber, int secondnumber,int thirdnumber);
    class Program
    {
        static void Main(string[] args)
        {
            var MoreArgsandReturn = new DelMoreArgAndReturn(MoreArgAndReturnType);
            Console.WriteLine(MoreArgsandReturn.Invoke(5,5,5));
        }

        public static int MoreArgAndReturnType(int firstnumber, int secondnumber, int thirdnumber)
        {
            return (firstnumber + secondnumber + thirdnumber);
        }
    }
}
