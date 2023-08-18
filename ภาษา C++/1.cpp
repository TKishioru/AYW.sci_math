#include <iostream>
using namespace std;

int main()
{
	char ans;
	do
	{
		system ("cls");
	int a;
	cout << "Enter Number : ";
	cin >> a;
	int b;
	cout << "Enter Number : ";
	cin >> b;
	int c;
	cout << "Enter Number : ";
	cin >> c;
	int d;
	d = a+b+c;
	cout << a << "+" << b << "+" << c << "=" << d << endl;
	cout << "Again (Y/N)";
	cin >> ans;
	}
	while ((ans == 'Y')||(ans == 'y'));
	cout << endl;
	cout << "Thank you";
	
	return 0;
}
