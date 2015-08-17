using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch03 {
    /// <summary>
    /// Implement a datastructure that is composed of several stacks and will create a new one
    /// once the previous reaches capacity. push() and pop() methods should act identical to 
    /// those methods in a traditional stack. 
    /// </summary>
    class SetOfStacks {
        public int Capacity { get; set; }
        public List<Stack<int>> Data { get; set; }

        private Stack<int> LastStack {
            get { return Data[Data.Count - 1]; }
        }

        public SetOfStacks(int capacity) {
            Capacity = capacity;
            Data = new List<Stack<int>>();
            Data.Add(new Stack<int>());
        }

        public int Pop() {
            var stack = LastStack;
            var popped = stack.Pop();
            if (stack.Count == 0) {
                Data.Remove(stack);
            }
            return popped;
        }

        public int PopAt(int index) {
            var stack = Data[index];
            var popped = stack.Pop();
            if (stack.Count == 0) {
                Data.Remove(stack);
            }
            return popped;
        }

        public void Push(int pushed) {
            var stack = LastStack;
            if (stack.Count >= Capacity && (stack != null)) {
                var newStack = new Stack<int>();
                newStack.Push(pushed);
                Data.Add(newStack);
            }
            else if (stack != null) {
                stack.Push(pushed);
            }

        }
    }
}
