using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch01 {
    /// <summary>
    /// Write an algorithm such that if an element in an NxM matrix is 0, its entire row
    /// and column are set to 0.
    /// </summary>
    class Question07 {
        public static void Main(string[] args) {
            var TestMatrixOne = new int[,] { {2, 0, 5}, 
                                             {3, 5, 7} };

            var TestMatrixTwo = new int[,] { {3, 1}, 
                                             {1, 4}, 
                                             {0, 0} };
           
            Console.WriteLine("Old matrix:");
            PrintMatrix(TestMatrixOne);
            Console.WriteLine("New matrix:");
            PrintMatrix(Zeroes(TestMatrixOne));
            Console.WriteLine("Old matrix:");
            PrintMatrix(TestMatrixTwo);
            Console.WriteLine("New matrix:");
            PrintMatrix(Zeroes(TestMatrixTwo));
            Console.WriteLine("Press Enter to continue: ");
            Console.Read();
        }

        private static void PrintMatrix(int[,] matrix) {
            for (int i = 0; i <= matrix.GetUpperBound(0); i++) {
                for (int j = 0; j <= matrix.GetUpperBound(1); j++) {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine(Environment.NewLine);
            }
        }

        private static int[,] Zeroes(int[,] matrix) {
            var row = new bool[matrix.GetUpperBound(0) + 1];
            var column = new bool[matrix.GetUpperBound(1) + 1];

            for (int i = 0; i <= matrix.GetUpperBound(0); i++) {
                for (int j = 0; j <= matrix.GetUpperBound(1); j++) {
                    if (matrix[i, j] == 0) {
                        row[i] = true;
                        column[j] = true;
                    }
                }
            }

            for (int k = 0; k < row.Length; k++) {
                for (int l = 0; l < column.Length; l++) {
                    if (row[k] || column[l]) {
                        matrix[k, l] = 0;
                    }
                }
            }
            return matrix;
        } 
    }
}
