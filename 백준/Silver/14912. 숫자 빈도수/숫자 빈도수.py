n,d = map(int, input().split())
temp = 0

for i in range(1,n+1):
	temp += str(i).count(str(d))

print(temp) 