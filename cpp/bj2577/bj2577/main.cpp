#include <iostream>
#include <cmath>
using namespace std;
int main() {
	int A, B, C;
	int n[10] = { 0 };
	long long m;
	cin >> A >> B >> C;
	m = A * B * C;
	for (int i = 0; i < (int)log10(m) + 1; i++) {
		for (int j = 0; j < 10; j++) {
			int temp = (m / (long long)pow(10, i)) % 10;
			if (j == temp) {
				n[j]++;
			}
		}
	}
	for (int i = 0; i < 10; i++) {
		cout << n[i] << "\n";
	}
}