#include <iostream>
#include <stack>
#include <string>
using namespace std;
string input;
stack<char> s;
bool output = true;

void stk() {
	for (auto c : input) {
		switch (c) {
		case '[':
		case '(':
			s.push(c);
			break;
		case ']':
			if (s.empty()) {
				output = false;
				break;
			}
			if (s.top() != '[') {
				output = false;
			}
			else {
				s.pop();
			}
			break;
		case ')':
			if (s.empty()) {
				output = false;
				break;
			}
			if (s.top() != '(') {
				output = false;
			}
			else {
				s.pop();
			}
			break;
		case '.':
			return;
		}
	}
}
int main() {
	while (true) {
		while (true) {
			getline(cin, input);
			if (input.find('.') != string::npos)
				break;
		}
		if (input == ".")
		{
			break;
		}
		stk();
		if (!s.empty()) {
			output = false;
		}
		if (output) {
			cout << "yes" << "\n";
		}
		else {
			cout << "no" << "\n";
			output = true;
		}
		input.clear();
		while (!s.empty()) {
			s.pop();
		}
	}
}