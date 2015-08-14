using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch02 {
    /// <summary>
    /// Write code to partition a linked list around a value x
    /// such that all nodes less than x come before all nodes 
    /// greater than x
    /// </summary>
    class Question04 {
        public static void Execute(LinkedList<int> inputList) {
            Console.WriteLine("Chapter 02 Question 04:");
            Console.WriteLine("Original linked list:");
            foreach (var item in inputList) {
                Console.WriteLine("{0}", item);
            }
            var pivoted = Pivot(inputList, 100);
            Console.WriteLine("Linked list pivoted around 100:");
            foreach (var item in pivoted) {
                Console.WriteLine("{0}", item);
            }
        }

        public static LinkedList<int> Pivot(LinkedList<int> list, int pivot) {
            var node = list.First;
            var pivotList = new LinkedList<int>();
            while (node != null) {
                if (node.Value < pivot) {
                    pivotList.AddFirst(node.Value);
                    node = node.Next;
                }
                else {
                    pivotList.AddLast(node.Value);
                    node = node.Next;
                }
            }
            return pivotList;
        }
    }
}
