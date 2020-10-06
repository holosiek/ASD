#pragma once
class Sort{
private:
    // Array holding values
    int* arr = new int[1];
    // Size of array
    int size = 0;
public:    
    void sortInstert();

    void print();

    Sort();

    ~Sort();
};