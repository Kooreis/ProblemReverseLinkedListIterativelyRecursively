Sure, here is the Python code for reversing a linked list both iteratively and recursively.

```python
class Node:
    def __init__(self, data=None):
        self.data = data
        self.next = None


class LinkedList:
    def __init__(self):
        self.head = None

    def append(self, data):
        if not self.head:
            self.head = Node(data)
        else:
            current = self.head
            while current.next:
                current = current.next
            current.next = Node(data)

    def display(self):
        elements = []
        current_node = self.head
        while current_node:
            elements.append(current_node.data)
            current_node = current_node.next
        print(elements)

    def iterative_reverse(self):
        prev = None
        current = self.head
        while current:
            nxt = current.next
            current.next = prev
            prev = current
            current = nxt
        self.head = prev

    def recursive_reverse(self, node):
        if node is None or node.next is None:
            self.head = node
            return
        self.recursive_reverse(node.next)
        node.next.next = node
        node.next = None


my_list = LinkedList()
my_list.append(1)
my_list.append(2)
my_list.append(3)
my_list.append(4)
my_list.append(5)

print("Original List: ")
my_list.display()

my_list.iterative_reverse()
print("List after iterative reverse: ")
my_list.display()

my_list.recursive_reverse(my_list.head)
print("List after recursive reverse: ")
my_list.display()
```

This code first creates a linked list with the elements 1, 2, 3, 4, 5. It then reverses the list iteratively and prints the reversed list. After that, it reverses the list again, but this time recursively, and prints the reversed list.