import sys

cnt = int(input())
result = []

for i in range(cnt):
    result.append(int(sys.stdin.readline()))

result.sort(reverse=1)

for i in range(cnt):
    print(result[i])