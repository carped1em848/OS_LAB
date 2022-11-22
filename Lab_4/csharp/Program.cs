using System;
using System.Diagnostics;
namespace CSharp
{
    class Program
    {

        static void Main(string[] args)
        {
            int a = 0;
            int b = 2;
            int c = 3;
            long iterations = 100000000l;

            DateTime start = DateTime.Now;
            
            for (int i = 0; i <= iterations; i++) {
                a += b * 2 + c - i;
            }
            Console.WriteLine(DateTime.Now - start);
        }
    }
}