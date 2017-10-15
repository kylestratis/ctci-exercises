import java.util.HashMap;

public class LinkedList {
    private Node head;
    private Node tail;

    // Construct with a single node
    public LinkedList() {
        this.head = null;
    }

    public void addToTail(int i) {
        if (this.head == null) {
            this.head = new Node(i);
        }
        else if (this.tail == null) {
            this.tail = new Node(i);
            this.head.next = this.tail;
        }
        else {
            tail.next = new Node(i);
            tail = tail.next;
        }
    }

    public LinkedList removeDupes() {
        // Store each node in a hashmap as a buffer
        // To improve memory use - we wouldn't make new whole Nodes every time
        // we add to the list. Can also probably do in place.
        HashMap table = new HashMap();
        Node n = this.head;
        LinkedList newList = new LinkedList();

        while (n != null) {
            if (!table.containsKey(n.data)) {
                table.put(n.data, true);
                newList.addToTail(n.data);
            }
            // Advance node
            n = n.next;
        }
        return newList;
    }

    public void printList() {
        Node n = this.head;
        while (n.next != null) {
            System.out.print(n.data + "->");
            n = n.next;
        }
        System.out.print(n.data + "\n");
    }
}
