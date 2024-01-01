#include <iostream>
#include <queue>

int dx[4] = {1, 0, -1, 0};
int dy[4] = {0, 1, 0, -1};
using namespace std;
string board[1002];
int fvis[1002][1002];
int jvis[1002][1002];
int main() {
	int r, c;
	cin >> r >> c;
	queue<pair<int, int>> jq;
	queue<pair<int, int>> fq;
	int output = 1;
	bool ispossible = false;
	for (int i = 0; i < r; i++) {
		cin >> board[i];
	}

	for (int i = 0; i < r; i++) {
		for (int j = 0; j < c; j++) {
			if (board[i][j] == 'J') {
				jq.push({ i,j });
				jvis[i][j] = 1;
			}
			if (board[i][j] == 'F') {
				fq.push({ i,j });
				fvis[i][j] = 1;
			}
		}
	}
	while (!fq.empty()) {
		pair<int, int> ftemp = fq.front(); fq.pop();
		for (int dir = 0; dir < 4; dir++) {
			int fx = ftemp.first + dx[dir];
			int fy = ftemp.second + dy[dir];
			if (fx < 0 || fy < 0 || fx >= r || fy >= c) continue;
			if (board[fx][fy] == '#' || fvis[fx][fy] > 0) continue;
			fvis[fx][fy] = fvis[ftemp.first][ftemp.second] + 1;
			fq.push({ fx,fy });
		}
	}

	while (!jq.empty()) {
		pair<int, int> jtemp = jq.front(); jq.pop();
		for (int dir = 0; dir < 4; dir++) {
			int jx = jtemp.first + dx[dir];
			int jy = jtemp.second + dy[dir];
			if (jx < 0 || jy < 0 || jx >= r || jy >= c) {
				cout << jvis[jtemp.first][jtemp.second];
				return 0;
			}
			if (board[jx][jy] == '#' || jvis[jx][jy] > 0) continue;
			if (fvis[jx][jy] <= jvis[jtemp.first][jtemp.second] + 1 && fvis[jx][jy] != 0) continue;
			jvis[jx][jy] = jvis[jtemp.first][jtemp.second] + 1;
			jq.push({ jx,jy });
		}
	}
		cout << "IMPOSSIBLE";
}