#include "HeapSort.hpp"
#include <algorithm>
#include <iostream>

void Kopiec::heapify(int a_size, int i){ 
    int t_biggestElem = i;
    int t_l = 2*i+1;
    int t_r = 2*i+2;

    if((t_l < a_size) && (arr[t_l] > arr[t_biggestElem])){
        t_biggestElem = t_l;
    }

    if((t_r < a_size) && (arr[t_r] > arr[t_biggestElem])){
        t_biggestElem = t_r; 
    }

    if(t_biggestElem != i){
        std::swap(arr[i], arr[t_biggestElem]); 
        heapify(a_size, t_biggestElem); 
    } 
} 

void Kopiec::buildHeap(){
    for(int i=(size>>1)-1; i>=0; i--){
        heapify(size, i);
    }
}

void Kopiec::copyArray(int* a_arr, int a_size){
    arr = a_arr;
    size = a_size;
}