using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch02 {
    class RunTests {
        static void Main(string[] args) {
            var dupeList = new LinkedList<int>();
            dupeList.AddLast(9);
            dupeList.AddLast(7);
            dupeList.AddLast(9);
            dupeList.AddLast(13);
            Question01.Execute(dupeList);
            Question02.Execute(GenerateLinkedList(7, 200));
            Question03.Execute(GenerateLinkedList(6, 200)); // Return unchanged list
            Question03.Execute(GenerateLinkedList(5, 200));
            Question04.Execute(GenerateLinkedList(8, 200));
            Question05.Execute(GenerateLinkedList(3, 9), GenerateLinkedList(3, 9));
            Question06.Execute(GenerateCircularLinkedList(5, 9));
            Question07.Execute(GenerateLinkedList(7, 9));
            Question07.Execute(GeneratePalindrome());
            Console.WriteLine("Press Enter to continue:");
            Console.Read();
        }

        public static LinkedList<int> GenerateLinkedList(int size, int max) {
            Random rand = new Random();
            var newList = new LinkedList<int>();
            for (int i = 0; i < size; i++) {
                newList.AddLast(rand.Next(0, max));
            }
            return newList;
        }

        public static LinkedList<int> GeneratePalindrome() {
            var newList = new LinkedList<int>();
            newList.AddLast(0);
            newList.AddLast(1);
            newList.AddLast(2);
            newList.AddLast(1);
            newList.AddLast(0);
            return newList;
        }

        // The last node is always the circular reference, but it'll suffice for the problem at hand.
        public static CircularLinkedList<int> GenerateCircularLinkedList(int size, int max) {
            Random rand = new Random();
            var newList = new CircularLinkedList<int>();
            for (int i = 0; i < size; i++) {
                newList.AddLast(rand.Next(0, max));
            }
            return newList;
        }
    }
}
