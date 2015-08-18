using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch03 {
    /// <summary>
    /// Tower of Hanoi problem
    /// </summary>
    class TowerOfHanoi {
        private Stack<int> Disks { get; set; }
        private int PoleIndex { get; set; }

        public TowerOfHanoi(int pole) {
            PoleIndex = pole;
            Disks = new Stack<int>();
        }

        public static void MoveDisks(int height, TowerOfHanoi originTower, TowerOfHanoi bufferTower, TowerOfHanoi destinationTower) {
            if (height > 0) {
                MoveDisks(height - 1, originTower, destinationTower, bufferTower);
                Console.WriteLine("Moving disk {0} from tower {1} to tower {2}", height, originTower.PoleIndex, destinationTower.PoleIndex);
                MoveTopTo(originTower, destinationTower);
                MoveDisks(height - 1, bufferTower, originTower, destinationTower);
            }
        }

        public static void MoveTopTo(TowerOfHanoi origin, TowerOfHanoi tower) {
            if (origin.Disks.Count != 0) {
                int topDisk = origin.Disks.Pop();
                AddToTower(tower, topDisk);
                Console.WriteLine("Moving disk {0} from Tower {1} to Tower {2}", topDisk, origin.PoleIndex, tower.PoleIndex);
            }
        }

        // Each disk is represented by an int denoting its size.
        public static void AddToTower(TowerOfHanoi tower, int disk) {
            if (tower.Disks.Count != 0 && tower.Disks.Peek() <= disk) {
                Console.WriteLine("Error adding disk {0}", disk);
            }
            else {
                tower.Disks.Push(disk);
            }
        }

        public static void Execute(string[] args) {
            int poles = 3;
            int disks = 5;
            List<TowerOfHanoi> towers = new List<TowerOfHanoi>();

            // Generate individual towers.
            for (int i = 0; i < poles; i++) {
                towers.Add(new TowerOfHanoi(i));
            }

            // Stack up disks on first pole
            for (int j = disks - 1; j >= 0; j--) {
                AddToTower(towers[0], j);
            }

            MoveDisks(poles, towers[0], towers[1], towers[2]);

            Console.WriteLine("Tower2 has the following disks: ");
            Console.Write("[");
            foreach (var disk in towers[2].Disks) {
                Console.Write("{0},", disk);
            }
            Console.Write("]");

        }
    }
}
