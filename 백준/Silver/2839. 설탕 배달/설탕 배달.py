n = int(input())

temp = 0
while n >= 0:
    if n % 5 == 0:
        temp += (n // 5)
        print(temp)
        break
    n -= 3
    temp += 1

else:
    print(-1)