num = input("Please enter a 10-digit number: ")
if len(num)!=10:
    print("The number does not have 10 digits")
else:
    for i in range(10):
        if (i+1)%2!=0:
            print(num[i], end=' ')
    print('\n' , end = ' ')
    for i in range(10):
        if (i+1)%2==0:
            print(num[i], end=' ')
