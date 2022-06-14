cnt = 0
result = 0
result_cnt = 0

for i in range(9):
    cnt+=1

    num = int(input())

    if(num > result):
        result = num
        result_cnt = cnt

print(result)
print(result_cnt)