import math
a = input("The length of the 1st side of the triangle is: ")
b = input("The length of the 2nd side of the triangle is: ")
c = input("The length of the 3rd side of the triangle is: ")
a = float(a)
b = float(b)
c = float(c)
area = (1/4)*(math.sqrt((a+b+c)*(-a+b+c)*(a-b+c)*(a+b-c)))
print("The area of the triangle is ", area)
