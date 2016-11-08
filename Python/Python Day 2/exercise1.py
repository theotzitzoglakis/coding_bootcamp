tin = input("Enter Tax Identification Number: ")
if len(tin)!=9:
    print("The TIN number is not correct!!!")
check = int(tin[8])
s = 0
for i in range(8):
    a = int(tin[7-i])*2**(i+1)
    s = s + a
rem1 = s%11
rem2 = rem1%10
if rem2==check:
    print("Tax Identification Number Valid")
else:
    print("Tax Identification Number not Valid")
