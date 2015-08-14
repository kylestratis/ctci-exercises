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
            Question02.Execute(GenerateLinkedList(7));
            Question03.Execute(GenerateLinkedList(6)); // Return unchanged list
            Question03.Execute(GenerateLinkedList(5));
            Question04.Execute(GenerateLinkedList(8));
            Console.WriteLine("Press Enter to continue:");
            Console.Read();
        }

        public static LinkedList<int> GenerateLinkedList(int size) {
            Random rand = new Random();
            var newList = new LinkedList<int>();
            for (int i = 0; i < size; i++) {
                newList.AddLast(rand.Next(0, 299));
                }
            return newList;
        }
    }
}
