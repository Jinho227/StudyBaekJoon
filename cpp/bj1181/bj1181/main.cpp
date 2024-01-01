#include <iostream>
#include <algorithm>
#include <vector>
using namespace std;

bool compare(const string& a, const string& b) {
	if (a.size() < b.size())
		return 1;
	else if (a.size() > b.size())
		return 0;
	else if (a.size() == b.size()) {
		if (a < b)
			return 1;
		else
			return 0;
	}
}



int main() {
	int n;
	cin >> n;
	vector<string> s;
	for (int i = 0; i < n; i++) {
		string temp;
		cin >> temp;
		if(find(s.begin(), s.end(), temp) == s.end())
			s.push_back(temp);
	}
	sort(s.begin(), s.end(), compare);
	for (auto& a : s) {
		cout << a << '\n';
	}
}