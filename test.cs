

namespace QueueTesting
{
    class Test
    {
        static void Main(string[] args)
        {
            Line lunchLine = new Line();
            lunchLine.Enqueue("Jim");
            lunchLine.Enqueue("Jill");
            lunchLine.Enqueue("Sam");
            lunchLine.Enqueue("Sid");
            lunchLine.Enqueue("Bob");

            Console.WriteLine("-------------Test--------------");
            lunchLine.Dequeue();
            lunchLine.Dequeue();
            lunchLine.Dequeue();
        }

    }
}