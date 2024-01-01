#include <iostream>
#include <string>
#include <sstream>
#include <vector>

using namespace std;
int main() {
	string str;
	getline(cin, str);
	vector<string> words;
	istringstream ss(str);
	while (getline(ss, str, ' ')) {
		if (str == "")
			continue;
		words.push_back(str);
	}
	cout << words.size();
}