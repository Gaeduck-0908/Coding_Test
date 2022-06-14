hour,min = map(int, input().split())
next_min = int(input())

min += next_min

while min >= 60:
    min -= 60
    hour += 1

    if min <= 59:
        break

while hour >= 24:
    hour -= 24

    if hour <= 23 :
        break

print(hour, min)