using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch03 {
    class RunTests {
        static void Main(string[] args) {
            SetOfStacksTests();
            Console.WriteLine("Press Enter to continue:");
            Console.Read();
        }

        public static void SetOfStacksTests() {
            var testSet = CreateSetOfStacks();
            Console.WriteLine("Testing the functions of SetOfStacks");
            Console.WriteLine("Our capacity per stack is {0}", testSet.Capacity);
            Console.WriteLine("Popping 9 off stack should give: {0}", testSet.Pop());
            Console.WriteLine("Pushing 3, 1, 2 onto set should give us a second Stack in the list");
            testSet.Push(3);
            testSet.Push(1);
            testSet.Push(2);
            Console.Write("[");
            foreach (var item in testSet.Data[1]) {
                Console.Write(" {0} ", item);
            }
            Console.Write("]");
            Console.WriteLine(" ");
            Console.WriteLine("PopAt, should get 3: {0}", testSet.PopAt(0));
            Console.WriteLine(" ");
        }

        public static SetOfStacks CreateSetOfStacks() {
            var setOfStacks = new SetOfStacks(3);
            // First stack
            setOfStacks.Push(1);
            setOfStacks.Push(2);
            setOfStacks.Push(3);
            // Second stack
            setOfStacks.Push(9);
            return setOfStacks;

        }
    }
}