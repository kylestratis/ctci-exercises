import java.util.HashMap;

public class ch02_exercises {

    // Write code to remove elements from a singly linked list
    public static void QuestionOne(Node n) {
        // Store each node in a hashmap as a buffer
        HashMap table = new HashMap();
        Node previous = null;

        while (n != null) {
            if (table.containsKey(n)) {
                // Previous will be the new list, if we find a dupe, add its next to previous's
                // but not advance the node that previous is set to
                previous.next = n.next;
            }
            else {
                // If we don't find a dupe, add it to hash, set to true, advance previous to n
                table.put(n.data, true);
                previous = n;
            }
            // Advance node
            n = n.next;
        }
    }

    public static void main(String[] args) {
        System.out.println("Question 2.1");
        System.out.println("------------");
        System.out.println("Question 2.2");
    }
}

