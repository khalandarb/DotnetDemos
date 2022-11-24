using System;

namespace NUnitLibrary
{
    public class Class1
    {
        public int id;
        public string name;

        public void getData()
        {
            Console.WriteLine("Enter id");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
        }

        public void showData()
        {
            Console.WriteLine(id + "\n" + name);
        }
    }
}
