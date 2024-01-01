#include <iostream>

using namespace std;
int main() {
	int n;
	cin >> n;
	int num;
	string s;
	for (int i = 0; i < n; i++) {
		cin >> num >> s;
		for (auto& c : s) {
			for (int j = 0; j < num; j++) {
				cout << c;
			}
		}
		cout << "\n";
	}
}