using System;

namespace QueueTesting // Note: actual namespace depends on the project name.
{
    internal class Line
    {
        private List<string> _shoppingCart = new List<string>();

        public void Enqueue(string student)
        {
            _shoppingCart.Add(student);
        }

        // Dequeue should remove the first item in the queue and display it and displaying the student in the terminal
        public void Dequeue()
        {
            //Problem 1

        } 
    }
}