for i in range(1, 10):
    print("0"*(9-i), end='')
    for k in range(1, i+1):
        print(i, end='')
    print(end='\n')
