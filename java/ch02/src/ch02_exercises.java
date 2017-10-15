import java.util.HashMap;

public class ch02_exercises {

    // Write code to remove elements from a singly linked list
    public static void QuestionOne(Node n) {



    }

    // Write code to find kth from the last node in a linked list
    //public static Node QuestionTwo(Node n, int k) {

    //}

    public static void main(String[] args) {
        LinkedList testList = new LinkedList();
        testList.addToTail(1);
        testList.addToTail(1);
        testList.addToTail(2);
        testList.printList();
        System.out.println("Question 2.1");
        LinkedList newList = testList.removeDupes();
        newList.printList();
        testList = new LinkedList();
        testList.addToTail(1);
        testList.addToTail(13);
        testList.addToTail(2);
        newList = testList.removeDupes();
        newList.printList();
        testList = new LinkedList();
        testList.addToTail(1);
        testList.addToTail(2);
        testList.addToTail(2);
        testList.addToTail(1);
        newList = testList.removeDupes();
        newList.printList();
        System.out.println("------------");
        System.out.println("Question 2.2");
    }
}

