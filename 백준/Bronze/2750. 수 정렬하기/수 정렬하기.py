cnt = int(input())
result = []

for i in range(cnt):
    result.append(int(input()))

result.sort()

for i in range(cnt):
    print(result[i])