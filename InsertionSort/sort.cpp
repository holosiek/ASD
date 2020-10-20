#include <iostream>
#include "sort.hpp" 

// Insertion sort
void Sort::sortInstert(){
    for(int j=1; j<size; j++){
        int elem = arr[j];
        int i = j-1;
        while(i>=0 && arr[i] > elem){
            arr[i+1] = arr[i];
            i--;
        }
        arr[i+1] = elem;
    }
}  

// Merge sort
void Sort::merge(int a_l, int a_pivot, int a_r){ 
    int t_leftsize = a_pivot-a_l+1; 
    int t_rightsize = a_r-a_pivot; 
    int a = 0;
    int b = 0;
    int c = a_l;

    int* t_leftarr = new int[t_leftsize];
    int* t_rightarr = new int[t_rightsize]; 
    //----------------------------------------
    for(int i = 0; i < t_leftsize; i++){
        t_leftarr[i] = arr[a_l+i]; 
    }
    for(int j = 0; j < t_rightsize; j++){
        t_rightarr[j] = arr[a_pivot+1+j];
    }
    //----------------------------------------
    while(a < t_leftsize && b < t_rightsize){ 
        if(t_leftarr[a] <= t_rightarr[b]){ 
            arr[c] = t_leftarr[a]; 
            a++; 
        } else { 
            arr[c] = t_rightarr[b]; 
            b++; 
        } 
        c++; 
    } 
    while(a < t_leftsize){ 
        arr[c] = t_leftarr[a]; a++; c++; 
    } 

    while(b < t_rightsize){ 
        arr[c] = t_rightarr[b]; b++; c++; 
    } 
    //----------------------------------------
    delete[] t_leftarr, t_rightarr;
} 

void Sort::sortMerge(int a_l, int a_r){
    if(a_r == -1){
        a_r = size-1;
    }
    if(a_l < a_r){ 
        int t_pivot = (a_l+a_r)/2; 
        sortMerge(a_l, t_pivot); 
        sortMerge(t_pivot+1, a_r);
        merge(a_l, t_pivot, a_r); 
    } 
}

// Display array
void Sort::print(){
    std::cout << "\nZawartosc tablicy: \n";
    for(int i=0; i<size; i++){
        std::cout << arr[i] << " ";
    }
    std::cout << "\n";
}  

// Check if array is sorted
void Sort::validate(){
    bool sorted = true;
    for(int i=1; i<size; i++){
        if(arr[i-1] > arr[i]){
            sorted = false;
            break;
        }
    }
    if(sorted){
        std::cout << "\nTablica jest posortowana!\n";
    } else {
        std::cout << "\nTablica nie jest posortowana!\n";
    }
}  

// Create array
Sort::Sort(){
    std::cout << "Wpisz ilosc elementow, a nastepnie podaj te elementy (liczby)\n";
    std::cin >> size;
    arr = new int[size];

    for(int i=0; i<size; i++){
        std::cin >> arr[i];
    }
}

// Deconstructor
Sort::~Sort(){
    delete arr;
}
