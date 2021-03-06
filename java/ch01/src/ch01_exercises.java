import java.util.Arrays;
import java.util.HashMap;

public class ch01_exercises {

    // Implement an algorithm to determine if a string has all unique characters (1.1)
    public static boolean uniqueChar(String first) {
        char[] firstArr = first.toCharArray();
        HashMap uniqueHash = new HashMap();

        for (char a : firstArr) {
            if (uniqueHash.containsKey(a)) {
                return false;
            }
            uniqueHash.put(a, 1);
        }

        return true;
    }

    /** Book solution to uniqueChar
     Similar to mine, except foresight to check size (d'oh), and uses boolean[] instead of HashMap.
     This is probably largely due to my Perl background. HashMap apparently has more memory overhead
     than an array, and is O(1) for lookups, but each action takes more time in a HashMap **/

    public static boolean uniqueCharAnswer(String str) {
        if (str.length() > 256) return false; // assume ASCII, if str > ASCII characters, must be repeat

        boolean[] char_set = new boolean[256];
        for (int i = 0; i < str.length(); i++) {
            int val = str.charAt(i);
            if (char_set[val]) { // Already found char
                return false;
            }
            char_set[val] = true;
        }
        return true;
    }

    // Given 2 strings, determine if one is a permutation of the other
    public static boolean questionThree(String str1, String str2) {
        // Transform strings into char arrays, sort, test for equality
        char[] str1_array = str1.toCharArray();
        char[] str2_array = str2.toCharArray();
        Arrays.sort(str1_array);
        Arrays.sort(str2_array);
        return Arrays.equals(str1_array, str2_array);
    }

    /** The quicker book solution. My version was the same as the first book solution, so this
     * is the second one, which is more efficient, and along the lines of my original thoughts
     * when working on this problem.
     */
    public static boolean permutation(String s, String t) {
        if (s.length() != t.length()) {
            return false;
        }

        int[] letters = new int[256]; // ASCII assumption

        char[] s_array = s.toCharArray();
        for (char c : s_array) {
            letters[c]++;
        }

        for (int i = 0; i < t.length(); i++) {
            int c = (int) t.charAt(i);
            if (--letters[c] < 0) {
                return false;
            }
        }

        return true;
    }

    // Write a method to replace all spaces in a string with '%20'
    public static String questionFour(String str) {
        char[] strArray = str.toCharArray();
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < strArray.length; i++) {
            if (strArray[i] == ' ') {
                sb.append("%20");
            }
            else {
                sb.append(strArray[i]);
            }
        }
        return sb.toString();
    }

    // Write a method to compress string with repeated characters. Ie aabcccccaaa becomes a2b1c5a3.
    public static String questionFive(String str) {
        // Perform compression
        char[] charArray = str.toCharArray();
        char holder = '\0';
        int repCount = 0;
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < charArray.length; i++) {
            if (charArray[i] == holder) {
                repCount++;
            }
            else if (i != 0) {
                    sb.append(holder);
                    sb.append(repCount);
                    holder = charArray[i];
                    repCount = 1;
            }
            else {
                holder = charArray[i];
                repCount = 1;
            }
        }

        sb.append(holder);
        sb.append(repCount);

        if (sb.length() >= str.length()) {
            return str;
        }

        return sb.toString();
    }

    public static void main(String[] args) {
        System.out.println("Question 1.1");
        System.out.println(uniqueChar("testone"));
        System.out.println("Should have been false");
        System.out.println(uniqueChar("tes"));
        System.out.println("Should have been true");
        System.out.println("=====================");
        System.out.println("Question 1.3");
        System.out.println(questionThree("hello world", "goodbye cruel world"));
        System.out.println("Should be false");
        System.out.println(questionThree("false", "lasef"));
        System.out.println("Should be true");
        System.out.println("=====================");
        System.out.println("Question 1.4");
        System.out.println(questionFour("This is John Woods")); // modified to be more idiomatic Java
        System.out.println(questionFour("This  is John"));
        System.out.println("=====================");
        System.out.println("Question 1.5");
        System.out.println(questionFive("aabbbcccec"));
        System.out.println(questionFive("aabbbcccecccc"));
        System.out.println(questionFive("abc"));
    }
}
