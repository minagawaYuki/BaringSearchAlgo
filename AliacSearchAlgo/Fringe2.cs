using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AliacSearchAlgo;

namespace AISearchSample
{
    class Fringe2:Fringes
{
        Stack<Node> stack;
        Queue<Node> queue;
        public Fringe2() 
        {
            stack = new Stack<Node>();
            queue = new Queue<Node>();
        }
        
        public void add(Node n,Node origin)
        {
            n.Origin = origin;
            stack.Push(n);
            queue.Enqueue(n);
        }

        public Node remove()
        {
            if (stack.Count != 0)
                return stack.Pop();
            if (queue.Count != 0)
                return queue.Dequeue();
            return null;
        }
    }
}
