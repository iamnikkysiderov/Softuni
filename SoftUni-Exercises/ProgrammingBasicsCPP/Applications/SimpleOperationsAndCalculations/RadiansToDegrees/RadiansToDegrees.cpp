// RadiansToDegrees.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <cmath>

using namespace std;


int main()
{
	double radians;

	cin >> radians;

	double degrees = radians * 180 / 3.1459;

	cout << ceil(degrees) << endl;

    return 0;
}

