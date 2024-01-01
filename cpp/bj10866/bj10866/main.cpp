#include <iostream>
#include <deque>

using namespace std;
int main() {
	int n;
	cin >> n;
	string s;
	int temp;
	deque<int> d;
	for (int i = 0; i < n; i++) {
		cin >> s;
		if (s == "push_front") {
			cin >> temp;
			d.push_front(temp);
		}
		else if (s == "push_back") {
			cin >> temp;
			d.push_back(temp);
		}
		else if (s == "pop_front") {
			if (d.empty()) {
				cout << -1 << "\n";
			}
			else {
				cout << d.front() << "\n";
				d.pop_front();
			}
		}
		else if (s == "pop_back") {
			if (d.empty()) {
				cout << -1 << "\n";
			}
			else {
				cout << d.back() << "\n";
				d.pop_back();
			}
		}
		else if (s == "size") {
			cout << d.size() << "\n";
		}
		else if (s == "empty") {
			cout << d.empty() << "\n";
		}
		else if (s == "front") {
			if (d.empty()) {
				cout << -1 << "\n";
			}
			else
				cout << d.front() << "\n";

		}
		else if (s == "back") {
			if (d.empty()) {
				cout << -1 << "\n";
			}
			else {
				cout << d.back() << "\n";
			}
		}
	}
}