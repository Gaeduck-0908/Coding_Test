def fibo(n) :
    if n <= 1:
        return n
    else :
        return fibo(n-1) + fibo(n-2)

if __name__ == '__main__':
    a = int(input())

    print(fibo(a))