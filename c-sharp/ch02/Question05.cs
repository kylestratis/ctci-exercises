using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch02 {
    /// <summary>
    /// You have two numbers represented by a linked list, where each node contains a single digit. 
    /// The digits are stored in reverse order, such that the 1's digit is at the head of the list. 
    /// Write a function that adds the two numbers and returns the sum as a linked list.
    /// E.g. IN: (7 -> 1 -> 6) + (5 -> 9 -> 2) => 617 + 295
    ///     OUT: 2 -> 1 -> 9 => 912
    /// </summary>
    class Question05 {
        public static void Execute(LinkedList<int> inputList1, LinkedList<int> inputList2) {
            var newSum = AddReverseOrder(inputList1, inputList2);
            Console.WriteLine("Chapter 02 Question 05 - Adding: ");
            Console.Write("[");
            foreach (var item in inputList1) {
                Console.Write("{0} -> ", item); // Not the best way to present it, but oh well
            }
            Console.Write("] + [");
            foreach (var item in inputList2) {
                Console.Write("{0} -> ", item);
            }
            Console.Write("]");
            Console.WriteLine(" = ");
            Console.Write("[");
            foreach (var item in newSum) {
                Console.Write("{0} -> ", item);
            }
            Console.Write("]");
            Console.WriteLine();
        }

        public static LinkedList<int> AddReverseOrder(LinkedList<int> a, LinkedList<int> b) {
            int sum;
            int carry = 0;
            var linkedListSum = new LinkedList<int>();
            var nodeA = a.First;
            var nodeB = b.First;
            while (nodeA != null || nodeB != null) {
                sum = nodeA.Value + nodeB.Value + carry;
                if (sum > 9) {
                    carry = 1;
                    sum -= 10;
                }
                else {
                    carry = 0;
                }
                linkedListSum.AddLast(sum);
                nodeA = nodeA.Next;
                nodeB = nodeB.Next;
            }
            if (carry > 0) {
                linkedListSum.AddLast(carry);
            }
            return linkedListSum;
        }
    }
}
