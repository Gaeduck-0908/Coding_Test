N = int(input())
result = list(map(int, input().split()))
m = max(result)
new_result = []

for i in result:
    new_result.append(i / m * 100)
avg = sum(new_result) / N

print(avg)