// RectangleAreaOnAFlatSurface.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <cmath>

using namespace std;


int main()
{
	int x1, y1, x2, y2;

	cin >> x1 >> y1 >> x2 >> y2;

	int length = abs(x1-x2);
	int height = abs(y1-y2);

	int perimeter = 2 * (length + height);
	int area = length * height;

	cout << area << endl << perimeter << endl;

    return 0;
}

