# Sorting algorithms

## Bubble sort
- A simple algorithm which repeatedly iterates through the list, compares adjacent elements, swapping them if they are in the incorrect order.
- Since this method is very costly, it is not a practical solution to use in most circumstances. It is often used simply in teaching of algorithms.

```
Procedure BubbleSort(list)
    n = Length(list)

    Do
        swapped = false

        For (i = 1; i < n; i++)
            If (list[i-1] > list[i])
                // current pair out of order
                // swap them, remember that a change has occurred
                swap list[i-1] and list[i]
                swapped = true
            End If
        End For
    While (swapped)
End Procedure
```
Time complexity:
|Best     |Average |Worst Case|
|---------|--------|----------|
|O(n)     |O(n^2)  |O(n^2)    |
&nbsp;

## Insertion sort
TODO

## Selection sort
TODO

## Merge sort
TODO

## Comparison sort
TODO

## QuickSort
TODO

## Shellsort
TOPO

# Searching algorithms
TODO