using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class StackDemo
    {
        //method to display the list functions
        public static void Stack()
        {
            Console.WriteLine("Creating Stack");
            //creating stack
            Stack<string> stack = new Stack<string>();
            //method to insert 
            stack.Push("abi");
            stack.Push("hello");
            stack.Push("siva");
            stack.Push("hi");
            //returns the stop element in the stack
            Console.WriteLine("Peeking element at top :{0}", stack.Peek());
            Console.WriteLine("\nRemove the element");
            //delete the top element
            stack.Pop();
            Console.WriteLine("Total number of element in stack:{0}", stack.Count());


        }
    }
}

       
 
