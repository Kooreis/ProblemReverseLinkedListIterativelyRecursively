Here is a Java console application that reverses a linked list both iteratively and recursively.

```java
import java.util.LinkedList;
import java.util.Collections;

public class Main {
    public static void main(String[] args) {
        LinkedList<Integer> list = new LinkedList<>();
        list.add(1);
        list.add(2);
        list.add(3);
        list.add(4);
        list.add(5);

        System.out.println("Original List: " + list);

        Collections.reverse(list);
        System.out.println("Iteratively Reversed List: " + list);

        LinkedList<Integer> reversedList = reverseRecursively(list);
        System.out.println("Recursively Reversed List: " + reversedList);
    }

    public static LinkedList<Integer> reverseRecursively(LinkedList<Integer> list) {
        if (list.size() <= 1) {
            return list;
        }

        Integer last = list.removeLast();
        LinkedList<Integer> reversed = reverseRecursively(list);
        reversed.addFirst(last);

        return reversed;
    }
}
```

Please note that this solution uses the `java.util.LinkedList` class, which is a doubly-linked list. The `Collections.reverse()` method is used for the iterative reversal, and a custom recursive method is used for the recursive reversal.