#pragma once
class Sort{
private:
    // Array holding values
    int* arr = new int[1];
    // Size of array
    int size = 0;
public:    
    void sortInstert();

    void sortMerge(int a_l = 0, int a_r = -1);
    void merge(int a_l, int a_pivot, int a_r);

    void print();

    void validate();

    Sort();

    ~Sort();
};