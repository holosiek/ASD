#include <iostream>
#include "sort.hpp"
#include "HeapSort.hpp"

int main(){
    // Create Kopiec
    Kopiec kopiec = Kopiec();
    // Create class
    Sort sort = Sort();

    // Show array contents before sort
    sort.print();
    // Copy pointer of array and size to heap and build heap
    kopiec.copyArray(sort.getArrPointer(), sort.getArrSize());
    kopiec.buildHeap();
    // Show array contents before sort
    sort.print();
    // Sort
    sort.sortHeap(&kopiec, kopiec.getArrSize());
    // Show array contents after sort
    sort.print();
    // Check if array is sorted
    sort.validate();

    // Block console
    system("pause");
}
