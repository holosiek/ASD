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

// Display array
void Sort::print(){
    std::cout << "\nZawartosc tablicy: \n";
    for(int i=0; i<size; i++){
        std::cout << arr[i] << " ";
    }
    std::cout << "\n";
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
