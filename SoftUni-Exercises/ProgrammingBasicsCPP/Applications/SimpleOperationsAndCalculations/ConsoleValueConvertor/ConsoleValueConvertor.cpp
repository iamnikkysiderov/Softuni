// ConsoleValueConvertor.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>
#include <string>

using namespace std;

int main()
{
	double sum;
	string input_currency;
	string output_currency;

	cin >> sum >> input_currency >> output_currency;

	if (input_currency == "USD")
	{
		sum *= 1.79549;
	}
	else if (input_currency == "EUR")
	{
		sum *= 1.95583;
	}
	else if (input_currency == "GBP")
	{
		sum *= 2.53405;
	}

	if (output_currency == "USD")
	{
		sum /= 1.79549;
	}
	else if (output_currency == "EUR")
	{
		sum /= 1.95583;
	}
	else if (output_currency == "GBP")
	{
		sum /= 2.53405;
	}

	std::cout << std::fixed;
	std::cout << std::setprecision(2);
	std::cout << sum << " " << output_currency << endl;

	return 0;
}

