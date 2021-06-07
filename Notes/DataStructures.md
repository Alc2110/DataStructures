# Linked list
Data stored in nodes, where each element has a reference to the next. This allows for efficient insertion and removal of elements from any position during iteration. Access is linear (relatively slow), in contrast to arrays, which provide constant-time access.

## Singly-linked list
- Each node has a *data* field, and a *next* field which is a reference to the next node
- The last node is linked to a terminator, or `null`
- The first node is known as the *head*

Example:
![Singly linked list](img/singly_linked_list.PNG)

### Common operations
### Traversal
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
### Inserting at beginning of the list
```
Procedure InsertBeginning(T item)
    Create a new Node
    NewNode.Data = item

    NewNode.Next = LinkedList.Head
End Procedure
```
### Inserting a node at the proper position
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

### Removing first node in the list
```
Procedure RemoveFirst
    // remove first node
    obsoleteNode = LinkedList.Head

    // point past deleted node
    LinkedList.Head = LinkedList.Head.Next

    destroy obsoleteNode
End Procedure
```

### Removing last node in the list
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
Time complexity:
|         |Average |Worst Case|
|---------|--------|----------|
|Access   |O(n)    |O(n)      |
|Search   |O(n)    |O(n)      |
|Insertion|O(1)    |O(1)      |
|Deletion |O(1)    |O(1)      |
&nbsp;

# Stack
TODO 

# Queue
TODO 

# Deck
TODO

# Bag
TODO