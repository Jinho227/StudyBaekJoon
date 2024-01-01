#include <iostream>
#include <queue>

using namespace std;
int board[502][502];
int dx[4] = { 1, 0, -1, 0 };
int dy[4] = { 0, 1, 0, -1 };


int main() {
	pair<int, int> n;
	int num = 0; int w = 0; int wt = 0;
	queue<pair<int, int>> q;
	cin >> n.first >> n.second;
	for (int i = 0; i < n.first; i++) {
		for (int j = 0; j < n.second; j++) {
			cin >> board[i][j];
		}
	}
	for (int i = 0; i < n.first; i++) {
		for (int j = 0; j < n.second; j++) {
			if (board[i][j] == 1) {
				board[i][j] = 0;
				num++;
				wt++;
				q.push({ i, j });
				while (!q.empty()) {
					pair<int, int> temp = q.front(); q.pop();
					for (int k = 0; k < 4; k++) {
						int nx = temp.first + dx[k];
						int ny = temp.second + dy[k];
						if (nx < 0 || ny < 0 || nx > n.first || ny > n.second) continue;
						if (!board[nx][ny]) continue;
						board[nx][ny] = 0;
						wt++;
						q.push({ nx, ny });
					}
				}
				if (wt > w) {
					w = wt;
				}
				wt = 0;
			}
		}
	}
	cout << num << "\n" << w << "\n";

}