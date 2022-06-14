import sys

T = int(input())
for i in range(0,T):
        a,b = map(int, sys.stdin.readline().split())
        print(a+b)