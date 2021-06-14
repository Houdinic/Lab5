using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var powers = new[] { 1, 2, 4,16,32,64,128,256,512,1024 };
            foreach (var item in powers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
