using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch02 {
    /// <summary>
    /// Implement an algorithm to check if a linked list 
    /// is a palindrome.
    /// </summary>
    class Question07 {
        public static void Execute(LinkedList<int> inputList) {
            Console.WriteLine("Chapter 02 Question 07: ");
            Console.WriteLine("Original linked list: ");
            Console.Write("[");
            foreach (var item in inputList) {
                Console.Write("{0} ->", item);
            }
            Console.Write("]");
            Console.WriteLine("");
            var palin = IsPalindrome(inputList);
            Console.WriteLine("Palindrome? {0}", palin);
        }

        public static bool IsPalindrome(LinkedList<int> list) {
            bool resp;
            var testStack = new Stack<int>();
            foreach (var item in list) {
                testStack.Push(item);
            }
            foreach (var item in list) {
                if (testStack.Pop() != item) {
                    return false;
                }
            }
            return true;
            
        }
    }
}
