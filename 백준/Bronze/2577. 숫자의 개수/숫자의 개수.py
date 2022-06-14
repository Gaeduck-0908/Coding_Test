first = int(input())
second = int(input())
third = int(input())

result = list(str(first * second * third))
for i in range(10):
    print(result.count(str(i)))