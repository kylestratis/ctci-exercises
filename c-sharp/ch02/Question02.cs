using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch02 {
    /// <summary>
    /// Implement an algorithm to find the kth to last element
    /// of a singly linked list.
    /// </summary>
    class Question02 {
        public static void Execute(LinkedList<int> inputList) {
            Console.WriteLine("Chapter 02 Question 02:");
            Console.WriteLine("Original linked list:");
            foreach(var item in inputList) {
                Console.WriteLine("{0}", item);
            }
            Console.WriteLine("Finding 3rd from last element:");
            var result = FindElement(inputList, 3);
            Console.WriteLine("{0}", result.Value);
        }

        public static LinkedListNode<int> FindElement(LinkedList<int> list, int index) {
            // Use a stack to reverse iterate linked list. We will pretend that the LinkedList
            // type is just a singly-linked list.
            var nodeStack = new Stack<LinkedListNode<int>>();
            LinkedListNode<int> node = list.First;
            
            while (node != null) {
                nodeStack.Push(node);
                node = node.Next;
            }

            int maxStackSize = nodeStack.Count;

            while (nodeStack.Count > (maxStackSize - index + 1)) { 
                nodeStack.Pop();
            }
            
            return nodeStack.Pop();
        }
    }
}
