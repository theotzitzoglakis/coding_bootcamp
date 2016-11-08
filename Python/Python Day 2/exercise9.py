pos = int(input("Enter shift: "))
if pos>=26:   #To make sure we don't get out of the alphabet range
    pos = pos%26
phrase = input("Enter phrase (Only Uppercase letters without spaces): ")
phraselist=[]
for i in range(len(phrase)):
    phraselist.append(ord(phrase[i])) #Turns letters to ascii numbers
    phraselist[i] = phraselist[i] + pos
    if phraselist[i]>90:  #To start from A after Z
        phraselist[i] = 64 + (phraselist[i] - 90) 
    print(chr(phraselist[i]), end='')
