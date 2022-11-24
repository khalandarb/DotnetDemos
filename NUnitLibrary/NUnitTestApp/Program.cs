using System;
using NUnitLibrary;

namespace NUnitTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Class1 class1 = new Class1();

            class1.getData();
            class1.showData();
        }
    }
}
