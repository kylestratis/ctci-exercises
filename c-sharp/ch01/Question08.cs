using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch01 {
    /// <summary>
    /// Assume you have a method isSubstring which checks if one word is a substring
    /// of another. Given two strings s1 and s2, check if s2 is a rotation of s1 
    /// using only one call to isSubstring (e.g. "waterbottle" is a rotation of 
    /// "erbottlewat").
    /// </summary>
    class Question08 {
        public static void Execute(string[] args) {
            var TestStringOne = "Waterbottle";
            var TestStringTwo = "Erbottlewat";
            var TestStringThree = "Football";
            var TestStringFour = "Soccer";

            Console.WriteLine("Chapter 01 Question 08:");
            Console.WriteLine("Is {0} a rotation of {1}? {2}", TestStringTwo, TestStringOne, IsRotation(TestStringOne, TestStringTwo));
            Console.WriteLine("Is {0} a rotation of {1}? {2}", TestStringFour, TestStringThree, IsRotation(TestStringThree, TestStringFour));
            //Console.WriteLine("Press Enter to continue:");
            Console.Read();
        }

        private static bool IsRotation(string s1, string s2) {
            var LowerS1 = s1.ToLower();
            var LowerS2 = s2.ToLower();
            return ((s1.Length == s2.Length) && (LowerS1 + LowerS1).Contains(LowerS2));
        }
    }
}
