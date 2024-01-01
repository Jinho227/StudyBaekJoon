#include <iostream>

using namespace std;
int main() {
	int n[5];
	int temp = 0;
	for (int i = 0; i < 5; i++) {
		cin >> n[i];
		temp += n[i] * n[i];
	}
	cout << temp % 10;
}