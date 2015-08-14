using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch02 {
    /// <summary>
    /// Write code to remove duplicates from an unsorted linked list.
    /// </summary>
    class Question01 {
        public static void Execute(LinkedList<int> inputList) {
            Console.WriteLine("Chapter 02 Question 01:");
            Console.WriteLine("Initial list:");
            foreach(var item in inputList) {
                Console.WriteLine("{0}", item);
            }
            var prunedList = RemoveDuplicates(inputList);
            Console.WriteLine("Duplicates removed:");
            foreach (var item in prunedList) {
                Console.WriteLine("{0}", item);
            }
        }

        public static LinkedList<int> RemoveDuplicates(LinkedList<int> list) {
            var seenValues = new List<int>();
            LinkedListNode<int> node = list.First;
            while (node != null) {
                var nextNode = node.Next;
                if (seenValues.Contains(node.Value)) {
                    list.Remove(node);
                }
                else {
                    seenValues.Add(node.Value);
                }
                node = nextNode;
            }
            return list;
        }
    }
}
