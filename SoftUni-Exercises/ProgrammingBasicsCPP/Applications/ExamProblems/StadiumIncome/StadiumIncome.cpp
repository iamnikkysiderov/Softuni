// StadiumIncome.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h"
#include <iostream>
#include <iomanip>

using namespace std;

int main()
{
	int sectors, stadium_capacity;
	double ticket_price;

	cin >> sectors >> stadium_capacity >> ticket_price;

	double sector_profit = (stadium_capacity * ticket_price) / sectors;
	double total_profit = sector_profit * sectors;
	double charity_money = (total_profit - (sector_profit * 0.75)) / 8;

	std::cout << std::fixed << std::showpoint;
	std::cout << std::setprecision(2);

	cout << "Total income - " << total_profit << " BGN" << endl;
	cout << "Money for charity - " << charity_money << " BGN";

	return 0;
}