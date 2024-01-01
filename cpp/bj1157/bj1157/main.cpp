#include <iostream>

using namespace std;

int main() {
	string str;
	cin >> str;
	int alpha[26] = { 0 };
	int index;
	int output = 0;
	char outputC;
	int n = 0;
	for (auto& c : str) {
		if ('a' <= c && 'z' >= c) {
			index = (int)c - (int)'a';
		}
		else if ('A' <= c && 'Z' >= c) {
			index = (int)c - (int)'A';
		}
		else {
			continue;
		}
		alpha[index]++;
	}
	for (int i = 0; i < 26; i++) {
		if (output < alpha[i]) {
			output = alpha[i];
			outputC = char(i + (int)'A');
		}
	}
	for (auto& i : alpha) {
		if (output == i) {
			n++;
		}
	}
	if (n >= 2) {
		cout << '?';
	}
	else {
		cout << outputC;
	}
}