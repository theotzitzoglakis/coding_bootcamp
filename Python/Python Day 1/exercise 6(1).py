sum=0
n = input("Enter number of triangular numbers: ")
n = int(n)
for k in range(1, n+1):
    sum+=k
    print(sum, end=' ')
