num = input("Enter 9-digit number: ")
if len(num)!=9:
    print("The number does not have 9 digits")
else:
    numlist = []
    for i in range(9):
        numlist.append(num[i])
    for j in range(9):
        if j==0 or j==3 or j==6:
            print(numlist[j], end ='')
        else:
            print(end = ' ')
    print('')
    for k in range(9):
        if k==1 or k==4 or k==7:
            print(numlist[k], end ='')
        else:
            print(end = ' ')
    print('')
    for l in range(9):
        if l==2 or l==5 or l==8:
            print(numlist[l], end='')
        else:
            print(end = ' ')

