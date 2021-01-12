#pragma once

class Kopiec{
private:
	int* arr;
	int size;
public:
	void heapify(int n, int i);
	void copyArray(int* a_arr, int a_size);
	void buildHeap();

	int* getArrPointer(){ return arr; };
	int getArrSize(){ return size; };
};