count = int(input())

for i in range(count):
    score = 0
    result_score = 0
    temp = list(input())

    for j in temp:
        if j == 'O':
            score += 1
            result_score += score
        else :
            score = 0

    print(result_score)