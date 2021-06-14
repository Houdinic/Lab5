using System;

namespace Exercise3
{
    class Program
    {
        static void f(ref string s)
        {
            s += "word";
        }
        static void Main(string[] args)
        {
            string s = "Hello";
            f(ref s);
            Console.WriteLine(s);

        }
    }
}
