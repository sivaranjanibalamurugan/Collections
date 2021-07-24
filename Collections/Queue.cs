using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class QueueDemo
    {
        //method to display the list functions
        public static void Queue()
        {
            Console.WriteLine("creating Queue");
            //creating new queue
            Queue<string> queue = new Queue<string>();
            //inserting element
            queue.Enqueue("hi");
            queue.Enqueue("hello");
            queue.Enqueue("welcome");
            queue.Enqueue("siva");
            Console.WriteLine("\nDisplaying queue");
            foreach (string q in queue)
            {
                Console.WriteLine(q);
            }
            Console.WriteLine("Removing the element");
            //method to remove element from the queue
            queue.Dequeue();
            Console.WriteLine("\nDisplaying the queue");
            foreach (string q in queue)
            {
                Console.WriteLine(q);
            }
        }

    }
}
