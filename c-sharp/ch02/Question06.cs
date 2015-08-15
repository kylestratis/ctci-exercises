using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch02 {
    /// <summary>
    /// Given a circular linked list, implement an algorithm which returns the
    /// node at the beginning of the loop. CLL: a corrupt linked list in which
    /// a node's next pointer points to an earlier node, so as to make a loop
    /// in the linked list.
    /// E.g. A -> B -> C -> D -> E -> C
    /// Output: C
    /// </summary>
    class Question06 {
        public static void Execute(CircularLinkedList<int> circularList) {
            Console.WriteLine("Chapter 02 Question 06: Circular linked list");
            Console.WriteLine("Initial list");
            Console.Write("[");
            foreach (var item in circularList) {
                Console.Write("{0} ->", item);
            }
            Console.Write("]");
            var circularNode = FindCircularNode(circularList);
            Console.WriteLine("");
            Console.WriteLine("The circular node's value is: ");
            Console.Write("[ {0} ]", circularNode.Value);
            Console.WriteLine(" ");
            
        }

        public static Node<int> FindCircularNode(CircularLinkedList<int> circularList) {
            var node = circularList[0];
            var seen = new List<Node<int>>();
            while (!seen.Contains(node.Next)) {
                seen.Add(node);
                node = node.Next;
            }
            return node;
        }
    }
}
