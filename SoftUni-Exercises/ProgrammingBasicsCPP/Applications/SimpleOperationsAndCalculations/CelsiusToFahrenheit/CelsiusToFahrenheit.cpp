// CelsiusToFahrenheit.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>

using namespace std;


int main()
{
	double celsius;

	cin >> celsius;

	double fahrenheit = celsius * 9 / 5 + 32;

	cout << fahrenheit;

    return 0;
}

