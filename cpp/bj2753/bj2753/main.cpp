#include <iostream>

using namespace std;
int main() {
	int n;
	cin >> n;
	if (n % 4 == 0) {
		if (n % 400 == 0) {
			cout << 1;
			return 0;
		}
		else if (n % 100 != 0) {
			cout << 1;
			return 0;
		}
	}
	cout << 0;
}