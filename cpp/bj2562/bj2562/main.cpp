#include <iostream>

using namespace std;
int main() {
	int n[9];
	int max = 0;
	int num = 0;
	for (int i = 0; i < 9; i++) {
		cin >> n[i];
		if (max < n[i]) {
			max = n[i];
			num = i;
		}
	}
	cout << max << "\n" << num + 1;
}