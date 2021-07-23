using System;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Collections!");
            Console.WriteLine("1.List");
            Console.WriteLine("Enter you choice");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    ListDemo.List();
                    break;
                default:
                    break;
            }
        }
    }
}
