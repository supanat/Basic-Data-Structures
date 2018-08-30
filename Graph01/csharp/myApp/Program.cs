using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            Console.WriteLine("Test Stack");
            CStack myStack = new CStack();
            myStack.push("A");
            myStack.push("B");
            myStack.push("C");
            Console.WriteLine(myStack.peek());
            myStack.pop();
            Console.WriteLine(myStack.peek());
            */

            Console.WriteLine("Graph");

            Graph theGraph = new Graph();
            theGraph.AddVertex("CS1");
            theGraph.AddVertex("CS2");
            theGraph.AddVertex("DS");
            theGraph.AddVertex("OS");
            theGraph.AddVertex("ALG");
            theGraph.AddVertex("AL");
            theGraph.AddEdge(0, 1);
            theGraph.AddEdge(1, 2); 
            theGraph.AddEdge(1, 5); 
            theGraph.AddEdge(2, 3); 
            theGraph.AddEdge(2, 4); 
            //theGraph.ShowVertex(0);
            //theGraph.TopSort(); 
            theGraph.
            Console.WriteLine(); 
            Console.WriteLine("Finished.");



        }
    }
}
