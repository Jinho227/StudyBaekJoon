#include <iostream>
#include <vector>
using namespace std;
vector<pair<int, int>> s;

int func(int a, int b, int n) {
	int num = 0;
	if (n == 1)
	{
		s.push_back({ a, b });
		return 1;
	}
	num += func(a, 6 - a - b, n - 1);
	num++;
	s.push_back({ a, b });
	num += func(6 - a - b, b, n - 1);
	return num;
}

int main() {
	int n;
	cin >> n;
	cout << func(1, 3, n) << "\n";
	for (int i = 0; i < s.size(); i++) {
		cout << s[i].first << ' ' << s[i].second << "\n";
	}
}

