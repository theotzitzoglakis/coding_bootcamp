num = input("Enter number sequence: ")
s = 0
if len(num)%2==0:
    for i in range(0, len(num), 2):
        s = s + (int(num[i])*int(num[i+1]))
    print(s)
else:
    for i in range(0, len(num)-1, 2):
        s = s + (int(num[i])*int(num[i+1]))
    s = s + int(num[len(num)-1])
    print(s)
