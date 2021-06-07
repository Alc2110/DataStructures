# Linked list
Data stored in nodes, where each element has a reference to the next. This allows for efficient insertion and removal of elements from any position during iteration. Access is linear (relatively slow), in contrast to arrays, which provide constant-time access.

## Singly-linked list
- Each node has a *data* field, and a *next* field which is a reference to the next node
- The last node is linked to a terminator, or `null`
- The first node is known as the *head*

Example:
![Singly linked list](img/singly_linked_list.PNG)

### Common operations/algorithms
#### Traversal
```
currNode = LinkedList.Head
While (currNode not null)
    // do something with currNode.Data...

    currNode = currNode.Next
End While
```

#### Appending (to the end of the list)
```
Procedure Append(T item)
    Create a new Node
    NewNode.Data = item

    If (no nodes in LinkedList)
        Head = NewNode
    Else
        Traverse the list to the last node
        Add NewNode to the end of the list
    End If
End Procedure
```
#### Inserting a node at beginning of the list
```
Procedure InsertBeginning(T item)
    Create a new Node
    NewNode.Data = item

    NewNode.Next = LinkedList.Head
End Procedure
```
#### Inserting a node at the proper position
```
Procedure Insert(T item)
    Create a new Node
    NewNode.Data = item

    If (no nodes in LinkedList)
        // make the new node the first node
        NewNode.Next = LinkedList.Head
        LinkedList.Head = NewNode
    Else
        // find the first node whose value is >= new value, or the end of
        // the list (whichever comes first)

        // insert the new node before the found node, or at the end of 
        // the list
    End If
End Procedure
```

#### Removing first node in the list
```
Procedure RemoveFirst
    // remove first node
    obsoleteNode = LinkedList.Head

    // point past deleted node
    LinkedList.Head = LinkedList.Head.Next

    destroy obsoleteNode
End Procedure
```

#### Removing last node in the list
```
Procedure RemoveLast
    If (no nodes in LinkedList)
        Return
    Else
        Traverse the list to the last node
        Set the second last node's next node to null

        destroy the last node
    End If
End Procedure
```

Since backwards iteration is impossible, efficient operations to insert or remove a node before a specified node are not possible.

Time complexity:
|         |Average |Worst Case|
|---------|--------|----------|
|Access   |O(n)    |O(n)      |
|Search   |O(n)    |O(n)      |
|Insertion|O(1)    |O(1)      |
|Deletion |O(1)    |O(1)      |
&nbsp;

## Doubly-linked list
- Each node contains a *data* field and two references, one for the *previous* node and one for the *next* node.
- The beginning and ending nodes' references a terminator, or `null`.
- The double links allow for efficient insertion of nodes before or after a specified node.

Example:
![Doubly linked list](img/doubly_linked_list.PNG)

## Common operations/algorithms
#### Traversal
```
// forwards traversal
currNode = LinkedList.Head
While (currNode is not null)
    // do something with currNode.Data...

    currNode = currNode.Next
End While

// backwards traversal
currNode = LinkedLast.LastNode
While (currNode is not null)
    // do something with currNode.Data...

    currNode = currNode.Prev
End While
```

#### Node insertion before or after a specific node
```
// before a given node
Procedure InsertBefore(newNode, node)
    newNode.Next = node

    If (node.Prev is null)
        newNode.Prev = null
        LinkedList.FirstNode = newNode
    Else
        newNode.Prev = node.Prev
        node.Prev.Next = newNode
    End If

    node.Prev = newNode
End Procedure

// after a given node
Procedure InsertAfter(newNode, node)
    newNode.Prev = node

    If (node.Next is null)
        newNode.Next = null
        LinkedList.LastNode = newNode
    Else
        NewNode.Next = node.Next
        node.Next.Prev = newNode
    End If

    node.Next = newNode
End Procedure
```

#### Removing a node
```
Procedure Remove(node)
    If (node.Prev is null)
        LinkedList.FirstNode = node.Next
    Else
        node.Prev.Next = node.Next
    End If

    If (node.Next is null)
        LinkedList.LastNode = node.Prev
    Else
        node.Next.Prev = node.Prev
    End If
End Procedure
```

Time complexity:
|         |Average |Worst Case|
|---------|--------|----------|
|Access   |O(n)    |O(n)      |
|Search   |O(n)    |O(n)      |
|Insertion|O(1)    |O(1)      |
|Deletion |O(1)    |O(1)      |
&nbsp;

# Stack
A **stack** is an ADT that mimics a stack of plates, where removal is only possible from the top. It supports two main operations:
- push - adds an element to the top of the stack
- pop - removes the most recently added element yet to be removed

This behaviour is known as LIFO (Last-in, first-out).

Additional operation:
- peek - retrieves the item at the top, without removing it from the stack. Can be achieved via a pop followed by a push operation to return the item to the stack.

If the stack is empty, a stack underflow will occur upon execution of peek or pop.

A stack can be implemented using either an array or linked list.

## Array implementation
```
Class Stack
    int maxSize
    int top
    array items

    Constructor(int size)
        this.maxSize = size
        this.items = new array[size]
        this.top = 0 // reports number of items pushed so far
    End Constructor

    Procedure Push(item)
        If (this.top == this.maxSize)
            report overflow error
        Else
            this.items[this.top] = item
            this.top = this.top + 1
        End If
    End Procedure

    Function Pop()
        If (this.Top = 0)
            report underflow error
        Else
            this.Top = this.Top - 1
            item = this.items[this.top]

            return item
        End If
    End Function
End Class
```

## Singly-linked list implementation
```
Class Stack
    Node head
    int numItems

    Class Node
        Item
        Next
    End Class

    Procedure Push(item)
        Node oldHead = this.head
        this.head = new Node()
        this.head.Next = oldHead
        numItems++
    End Procedure

    Function Pop
        If (Head is null)
            Item = this.Head.Item
            this.Head = this.Head.Next
            this.numItems--

            return Item
        Else
            return null
        End If
    End Function
End Class
```

## Applications/use cases
- required for depth-first search
- backtracking
- expression evaluation and syntax parsing

# Queue
TODO 

# Deque
TODO

# Bag
TODO