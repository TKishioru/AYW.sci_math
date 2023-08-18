#include <iostream>
using namespace std;

int main()
{
	int shirt;
	cout << "How many SHIRT?";
	cin >> shirt;
	int pair;
	cout << "How many PAIR?";
	cin >> pair;
	int money;
	int mshirt;
	int mpair;
	int mmoney;
	
	mshirt = shirt*250;
	mpair =  pair*150;
	money =  mshirt + mpair;
	
	cout << "Money : " <<money << endl;
	cout << "Shirt : " <<mshirt << endl;
	cout << "Pair : " <<mpair << endl;

	int x;
	int y;
	int z;

	if(shirt>5)
	{
		y = (shirt*250)-100;
	}
	else
	{
		y = shirt*250;
	}
	if(pair>6)
	{
		z = (pair*150)-100;
	}
	else
	{
		z = pair*150;
	}	
	
	cout << "In Promotion" << endl;
	x = y + z;
	cout << "Money : " << x << endl;
	cout << "Shirt : " << y << endl;
	cout << "Pair : " << z << endl;
	

	
			
	return 0;
}
