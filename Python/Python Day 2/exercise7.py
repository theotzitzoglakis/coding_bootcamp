date1 = input("Enter 1st date (dd/mm/yyyy): ")
date1 = date1.split('/')
d1, m1, y1 = int(date1[0]), int(date1[1]), int(date1[2])
date2 = input("Enter 2nd date (dd/mm/yyyy): ")
date2 = date2.split('/')
d2, m2, y2 = int(date2[0]), int(date2[1]), int(date2[2])
c1 = (365*y1) + (y1//4) - (y1//100) + (y1//400) + ((306*m1 + 5)//10) + (d1 - 1)
c2 = (365*y2) + (y2//4) - (y2//100) + (y2//400) + ((306*m2 + 5)//10) + (d2 - 1)
dif = abs(c2 - c1)
print(dif, "days.")

