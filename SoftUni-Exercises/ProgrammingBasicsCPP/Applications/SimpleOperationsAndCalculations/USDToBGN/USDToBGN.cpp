// USDToBGN.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>

using namespace std;


int main()
{
	double usd;

	cin >> usd;

	double bgn = usd * 1.79549;

	cout << fixed << setprecision(2) << bgn << endl;

    return 0;
}

