first,second,third = map(int, input().split())

money = 0

if first == second and first == third and second == third:
    money += 10000 + (first * 1000)
elif first == second or first == third:
    money += 1000 + (first * 100)
elif second == third:
    money += 1000 + (second * 100)
else :
    temp = [first,second,third]

    money += (max(temp) * 100)

print(money)