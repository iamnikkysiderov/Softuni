// PointInRectangle.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h"
#include <iostream>

using namespace std;

int main()
{
	double x1, y1, x2, y2, x, y;

	cin >> x1 >> y1 >> x2 >> y2 >> x >> y;

	if (x2 >= x1 && x <= x2 && x >= x1)
	{
		if (y2 >= y1 && y <= y2 && y >= y1)
		{
			cout << "Inside";
		}
		else if (y1 >= y2 && y <= y1 && y >= y2)
		{
			cout << "Inside";
		}
		else
		{
			cout << "Outside";
		}
	}
	else if (x1 >= x2 && x <= x1 && x >= x2)
	{
		if (y1 >= y2 && y <= y1 && y >= y2)
		{
			cout << "Inside";
		}
		else if (y2 >= y1 && y <= y2 && y >= y1)
		{
			cout << "Inside";
		}
		else
		{
			cout << "Outside";
		}
	}
	else
	{
		cout << "Outside";
	}

	return 0;
}