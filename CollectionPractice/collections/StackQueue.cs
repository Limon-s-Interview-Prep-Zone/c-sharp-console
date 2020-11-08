using System;
using System.Collections;

namespace collections.NonGenericCollection
{
    class StackDemo
    {
        public static void StackShow()
        {
            Stack s = new Stack();
            //Adding item to the stack using the push method
            s.Push(10);
            s.Push("hello");
            s.Push(3.14f);
            s.Push(true);
            s.Push(67.8);
            s.Push('A');

            foreach (var item in s)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine(@"Remove First Item:" + s.Pop());
            Console.WriteLine($"Is the value hi present in the collection : {s.Contains("hi")}");
            Console.WriteLine(@"Peek:" + s.Peek());

        }
    }
    class QueueDemo
    {
        public static void QueueShow()
        {
            Queue q = new Queue();
            //Adding item to the queue using the Enqueue method
            q.Enqueue(10);
            q.Enqueue("hello");
            q.Enqueue(3.14f);
            q.Enqueue(true);
            q.Enqueue(67.8);
            q.Enqueue('A');

            foreach (var item in q)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine(@"Remove First Item:" + q.Dequeue());
            Console.WriteLine($"Is the value hi present in the collection : {q.Contains("hi")}");
            Console.WriteLine(@"Peek:" + q.Peek());
        }
    }
}