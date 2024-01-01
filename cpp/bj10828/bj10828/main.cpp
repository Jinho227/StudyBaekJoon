#include <iostream>
#include <stack>
#include <vector>
using namespace std;
int main() {
	int num;
	cin >> num;
	stack<int> s;
	string cmd;
	int temp;
	vector<int> output;
	for (int i = 0; i < num; i++) {
		cin >> cmd;
		if (cmd == "push") {
			cin >> temp;
			s.push(temp);
		}
		else if (cmd == "pop") {
			if (s.empty() == 1) {
				output.push_back(-1);
			}
			else {
				output.push_back(s.top());
				s.pop();
			}
		}
		else if (cmd == "size") {
			output.push_back(s.size());
		}
		else if (cmd == "empty") {
			output.push_back(s.empty());
		}
		else if (cmd == "top") {
			if (s.empty() == 1) {
				output.push_back(-1);
			}
			else {
				output.push_back(s.top());
			}
		}
	}
	for (auto a : output) {
		cout << a << "\n";
	}
}