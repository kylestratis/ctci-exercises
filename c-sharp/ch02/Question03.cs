using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch02 {
    /// <summary>
    /// Implement an algorithm to delete a node in the middle of a singly linked
    /// list given only access to that node.
    /// </summary>
    class Question03 {
        public static void Execute(LinkedList<int> inputList) {
            Console.WriteLine("Chapter 02 Question 03:");
            Console.WriteLine("Original linked list:");
            foreach (var item in inputList) {
                Console.WriteLine("{0}", item);
            }
            var newList = RemoveMiddle(inputList);
            Console.WriteLine("Middle removed:");
            foreach (var item in newList) {
                Console.WriteLine("{0}", item);
            }
        }

        // This uses the entire list and thus ignores the constraint of having only access to the node. See method below this.
        public static LinkedList<int> RemoveMiddle(LinkedList<int> list) {
            if (list.Count % 2 == 0) {
                return list;
            }
            LinkedListNode<int> node = list.First;
            int midIndex = (list.Count / 2);
            for (var i = 0; i < midIndex; i++) {
                node = node.Next;
            }
            list.Remove(node);
            return list;
        }

        // A basic implementation of the Java solution in the book
        public static bool RemoveNode(LinkedListNode<int> node) {
            if (node.Next == null || node.Value == null) {
                return false;
            }
            var copiedNode = node.Next;
            node = copiedNode;
            return true;
        }
    }
}
