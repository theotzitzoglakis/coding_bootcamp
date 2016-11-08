numbers = []
for i in range(1, 10):
    if i%3!=0:
        print("Enter a number with", i%3,"digits: ", end='')
        a = input()
        if len(a)!= i%3:
            print("The number does not have", i%3,"digits")
            break
        numbers.append(a)
    else:
        a = input("Enter a number with 3 digits: ")
        if len(a)!= 3:
            print("The number does not have 3 digits")
            break
        numbers.append(a)
print(" ",numbers[0], end='|')
print(" ",numbers[3], end='|')
print(" ",numbers[6])
print("",numbers[1], end='|')
print("",numbers[4], end='|')
print("",numbers[7])
print(numbers[2], end='|')
print(numbers[5], end='|')
print(numbers[8])

