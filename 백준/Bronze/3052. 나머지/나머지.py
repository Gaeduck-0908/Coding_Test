result = []

for i in range(10):
    a = int(input())
    result.append(a % 42)

result = set(result)
print(len(result))