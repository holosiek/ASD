#include <iostream>
#include "sort.hpp"

int main(){
    // Create class
    Sort sort = Sort();
    // Show array contents before sort
    sort.print();
    // Sort
    sort.sortInstert();
    // Show array contents after sort
    sort.print();

    // Block console
    system("pause");
}