num = input("Please enter the binary number: ")
if len(num)!=8:
    print("The number you entered does not have 8 digits, please restart the process")
else:
    numlist=[]
    sum=0
    for i in range(8):
        if int(num[i])>1:
            print("The number you entered is not binary, please restart the process")
            break
        else:
             numlist.append(num[i])
             numlist[i]=int(numlist[i])
             sum = sum + numlist[i]
    if sum%2==0:
        print("Parity check OK")
    else:
        print("Parity check not OK")


         



