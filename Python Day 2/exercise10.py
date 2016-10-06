binary = input('Enter binary sequence: ')
zeros, ones = binary.split('1'), binary.split('0')
maxzeros, maxones = 0, 0
for i in range(len(zeros)):
    if len(zeros[i]) > maxzeros:
        maxzeros = len(zeros[i])
for j in range(len(ones)):
    if len(ones[j]) > maxones:
        maxones = len(ones[j])
if maxzeros > maxones:
    print('Longest run was zeros with length: ', maxzeros)
elif maxzeros < maxones:
    print('Longest run was ones with length: ', maxones)
else:
    print('Equal longest run of ones and zeros with length: ', maxones)
