cnt = int(input())
name = []

for i in range (cnt):
	name.append(input())

if(sorted(name, reverse = True) == name):
	print('DECREASING')
elif(sorted(name) == name):
	print('INCREASING')
else:
	print('NEITHER')