def d(n):
    n = n + sum(map(int, str(n)))
    return n

result = set()

for i in range(1, 10001):
    result.add(d(i))

for i in range(1, 10001):
    if i not in result:
        print(i)