using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch02 {
    class RunTests {
        static void Main(string[] args) {
            var testList = new LinkedList<int>();
            testList.AddFirst(1);
            testList.AddLast(7);
            testList.AddLast(4);
            testList.AddLast(13);
            testList.AddLast(11);
            testList.AddLast(7);
            Question01.Execute(testList);
            Question02.Execute(testList);
            Console.WriteLine("Press Enter to continue:");
            Console.Read();
        }
    }
}
