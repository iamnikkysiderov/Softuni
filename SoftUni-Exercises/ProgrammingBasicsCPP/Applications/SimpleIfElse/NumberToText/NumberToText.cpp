// NumberToText.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h"
#include <iostream>

using namespace std;

int main()
{
	int input_num;

	cin >> input_num;

	switch (input_num)
	{
	case 1: cout << "one";
		break;
	case 2: cout << "two";
		break;
	case 3: cout << "three";
		break;
	case 4: cout << "four";
		break;
	case 5: cout << "five";
		break;
	case 6: cout << "six";
		break;
	case 7: cout << "seven";
		break;
	case 8: cout << "eight";
		break;
	case 9: cout << "nine";
		break;

	default: cout << "number too big";
		break;
	}

	return 0;
}
