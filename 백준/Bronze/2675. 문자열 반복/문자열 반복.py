for i in range(int(input())):
    cnt, txt = input().split()
    text = ''
    for j in txt:
        text += int(cnt) * j
    print(text)