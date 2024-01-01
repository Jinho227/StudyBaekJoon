#include <iostream>
#include <string>
#include <vector>
using namespace std;
int main() {
	string input;
	cin >> input;
	for (char alphabet = 'a'; alphabet <= 'z'; alphabet++) {
		int cnt = 0;
		for (auto temp : input) {
			if (alphabet == temp) cnt++;
		}
		cout << cnt << ' ';
	}
}