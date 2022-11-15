import random


class Node:
    value: int

    def __init__(self, Value: int):
        self.value = Value
        self.right = None
        self.left = None

    def __str__(self):
        return(f"{self.value}")


def search(value: int, root: Node):
    if(root.value == value):
        print("node founded")

    if(value > root.value):
        if(root.right == None):
            print("Node is not exist")
            return
        search(value, root.right)

    if(value < root.value):
        if(root.left == None):
            print("Node is not exist")
            return
        search(value, root.left)


def insert(value: int, root: Node):
    if(value == root.value):
        return

    if(value > root.value):
        if(root.right == None):
            root.right = Node(value)
            return

        insert(value, root.right)

    if(value < root.value):
        if(root.left == None):
            root.left = Node(value)
            return

        insert(value, root.left)


if __name__ == "__main__":
    print("program start")

    root: Node = Node(0)

    for i in range(100000):
        insert(random.randint(-10000, 10000), root)

    inp = 0
    while(inp != 1):
        inp = int(input("(1 = exit)>>>"))
        search(inp, root)
