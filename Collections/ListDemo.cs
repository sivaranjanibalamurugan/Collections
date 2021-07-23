using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class ListDemo
    {
        //method to display the list functions
        public static void List()
        {
            Console.WriteLine("Creating list");
            //creating new list
            List<string> list = new List<string>();
            //adding object to the list
            list.Add("siva");
            list.Add("hello");
            list.Add("hi");
            list.Add("welcome");
            Console.WriteLine("Displaying the list items");
            DisplayList(list);
            Console.WriteLine("\nRemove the element");
            list.Remove("hi");
            Console.WriteLine("After removal");
            DisplayList(list);
            Console.WriteLine("\nElement at 2nd position is {0}", list[2]);


        }
        //Method to display the list
        public static void DisplayList(List<string> list)
        {
            foreach (string l in list)
            {
                Console.WriteLine(l);
            }
        }
    }
}

