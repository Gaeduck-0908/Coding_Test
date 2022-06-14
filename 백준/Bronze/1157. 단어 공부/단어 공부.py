a = input().upper()
a_set = list(set(a))
cnt = []

for i in a_set:
    cnt.append(a.count(i))

if cnt.count(max(cnt)) > 1:
    print("?")

else:
    print(a_set[cnt.index(max(cnt))])