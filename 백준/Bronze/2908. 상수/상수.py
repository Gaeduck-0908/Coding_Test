first,second = input().split()

first = int(first[::-1])
second = int(second[::-1])

if(first > second):
	print(first)
else:
	print(second)