#include <iostream>
#include <list>
#include <string>
using namespace std;
int main() {
	list<char> list;
	string s;
	int num;
	cin >> s;
	for (char a : s) {
		list.push_back(a);
	}
	auto it = next(list.end(), 0);

	cin >> num;
	for (int i = 0; i < num; i++) {
		cin >> s;
		char commend = s.front();
		switch (s.front()) {
		case 'P': 
			cin >> s;
			list.insert(it, s.back()); 
			break;
		case 'D': 
			if (it == list.end())
				break;
			it = next(it, 1);
			break;
		case 'L': 
			if (it == list.begin())
				break;
			it = next(it, -1);
			break;
		case 'B': 
			if (it == list.begin()) {
				break;
			}
			else {
				it = next(it, -1);
				it = list.erase(it);
				break;
			}
		}
	}
	for (auto const& i : list) {
		cout << i;
	}
}