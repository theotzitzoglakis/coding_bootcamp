n = input("Enter the number of pronic numbers you want to produce: ")
n = int(n)
i=1
while i<=n:
    p = i*(i+1)
    print(p, end=' ')
    i+=1
