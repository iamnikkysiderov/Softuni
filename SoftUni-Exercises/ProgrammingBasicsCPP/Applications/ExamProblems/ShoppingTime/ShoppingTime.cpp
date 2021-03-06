// ShoppingTime.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h"
#include <iostream>
#include <iomanip>

using namespace std;

int main()
{
	int total_free_time;
	double price_computer_part, price_program, price_coffee;

	cin >> total_free_time >> price_computer_part >> price_program >> price_coffee;

	int coffee_time_spent = total_free_time - 5;
	int free_time_left = coffee_time_spent - 10;

	double money_spent = (price_computer_part * 3) + price_coffee + (price_program * 2);

	std::cout << std::fixed << std::showpoint;
	std::cout << std::setprecision(2);
	std::cout << money_spent << endl;

	cout << free_time_left;

	return 0;
}
