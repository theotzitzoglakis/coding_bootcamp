import math
a = input("Enter the 'a' value of the quadratic equation: ")
b = input("Enter the 'b' value of the quadratic equation: ")
c = input("Enter the 'c' value of the quadratic equation: ")
a = float(a)
b = float(b)
c = float(c)
D = b**2 - 4*a*c
if D>0:
    x1 = (-b + math.sqrt(D))/(2*a)
    x2 = (-b - math.sqrt(D))/(2*a)
    print("The roots of the equation are ", x1, "and ", x2)
elif D==0:
    x = -b/(2*a)
    print("The root of the equation is ", x)
else:
    print("The equation has no roots")
