import sys

cnt = int(sys.stdin.readline())
result = [0] * 10001

for i in range(cnt):
    result[int(sys.stdin.readline())] += 1

for i in range(10001):
    if result[i] != 0:
        for j in range(result[i]):
            print(i)