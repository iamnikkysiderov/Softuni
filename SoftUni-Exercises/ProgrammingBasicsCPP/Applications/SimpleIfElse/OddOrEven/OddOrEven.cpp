// OddOrEven.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h"
#include <iostream>

using namespace std;

int main()
{
	int number;

	cin >> number;

	bool is_even = number % 2 == 0;

	if (is_even)
	{
		cout << "even";
	}
	else
	{
		cout << "odd";
	}

	return 0;
}
