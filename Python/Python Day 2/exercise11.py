limit = int(input('Enter limit: '))
lineof10 = 0   
for i in range(3, limit+1):
    number = i
    while i > 1:  #squares of 2 are the only numbers that can be divided
        i = i/2   #multiple times by 2 and return 1 
    if i == 1:
        continue
    else:
        print(number, end=' ')
        lineof10 = lineof10 + 1 #counter for having 10 results per line 
        if lineof10 == 10:
            print('')   #changes line
            lineof10 = 0  #reset counter
        

