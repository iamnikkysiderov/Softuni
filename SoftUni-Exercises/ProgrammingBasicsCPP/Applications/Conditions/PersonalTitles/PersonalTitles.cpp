// PersonalTitles.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h"
#include <iostream>

using namespace std;

int main()
{
	double age;
	char gender;

	cin >> age >> gender;

	switch (gender)
	{
	case 'm':
		if (age < 16)
		{
			cout << "Master";
		}
		else
		{
			cout << "Mr.";
		}
		break;

	case 'f':
		if (age < 16)
		{
			cout << "Miss";
		}
		else
		{
			cout << "Ms.";
		}
		break;

	default:
		break;
	}

	return 0;
}