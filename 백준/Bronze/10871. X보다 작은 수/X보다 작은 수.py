N,X = map(int, input().split())

result = list(map(int,input().split()))

for i in range(len(result)):
    if result[i] < X:
        print(result[i],end=' ')