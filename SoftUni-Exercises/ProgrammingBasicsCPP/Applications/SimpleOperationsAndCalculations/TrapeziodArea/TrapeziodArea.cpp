// TrapeziodArea.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>

using namespace std;


int main()
{
	double b1, b2, h;

	cin >> b1 >> b2 >> h;

	double area = (b1 + b2) * h / 2;

	cout << area << endl;

    return 0;
}

