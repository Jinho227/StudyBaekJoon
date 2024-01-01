#include <iostream>
#include <queue>

using namespace std;

int dx[4] = { 1, 0, -1, 0 };
int dy[4] = { 0, 1,  0, -1 };
int box[1002][1002];

int main() {
	int output = 0;
	pair<int, int> num;
	queue<pair<int, int>> q;
	cin >> num.second >> num.first;
	for (int i = 0; i < num.first; i++) {
		for (int j = 0; j < num.second; j++) {
			cin >> box[i][j];
		}
	}
	for (int i = 0; i < num.first; i++) {
		for (int j = 0; j < num.second; j++) {
			if (box[i][j] == 1) {
				q.push({ i, j });
			}
		}
	}
	while (!q.empty()) {
		int size = q.size();
		for (int i = 0; i < size; i++) {
			pair<int, int> temp = q.front();
			q.pop();
			for (int dir = 0; dir < 4; dir++) {
				int nx = temp.first + dx[dir];
				int ny = temp.second + dy[dir];
				if (nx < 0 || ny < 0 || nx >= num.first || ny >= num.second) continue;
				if (box[nx][ny] == 1 || box[nx][ny] == -1) continue;
				box[nx][ny] = 1;
				q.push({ nx, ny });
			}
		}
		if (!q.empty()) {
			output++;
		}
	}


	for (int i = 0; i < num.first; i++) {
		for (int j = 0; j < num.second; j++) {
			if (box[i][j] == 0) {
				output = -1;
			}
		}
	}
	cout << output;
}