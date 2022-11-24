using System;
using System.Collections.Generic;
using System.Text;

namespace DemoApp
{
    class ArrayDemo
    {
        public void display()
        {
            int size;
            Console.WriteLine("Enter no of elements");
            size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Elements are:");
            foreach(var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
