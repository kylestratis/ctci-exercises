import java.util.HashMap;

public class ch01_exercises {

    // Implement an algorithm to determine if a string has all unique characters (1.1)
    public static boolean uniqueChar(String first) {
        char[] firstArr = first.toCharArray();
        HashMap uniqueHash = new HashMap();

        for (char a : firstArr) {
            if (uniqueHash.containsKey(a)) {
                return true;
            }
            uniqueHash.put(a, 1);
        }

        return false;
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

    public static void main(String[] args) {
        System.out.println(uniqueChar("testone"));
        System.out.println(uniqueChar("tes"));
    }
}
