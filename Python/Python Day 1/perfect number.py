for test_number in range(1, 10000):
    sum = 0
    for i in range(1, test_number):
    	if test_number%i==0:
    		sum+=i
    if sum==test_number:
    	print(test_number, "is a perfect number")
