y = int(input("Enter year: "))
if y<1900 or y>2099:
    print("Please enter a year between 1900 and 2099")
else:
    a = y%4
    b = y%7
    c = y%19
    d = (19*c + 15)%30
    e = (2*a + 4*b - d + 34)%7
    month = (d + e + 114)//31
    day = ((d + e + 114)%31)+ 1
    gday = day + 13
    if month == 3 and gday>31:
        print("Day: ", gday - 31, "Month: 4")
    elif month == 4 and gday>30:
        print("Day: ", gday - 30, "Month: 5")
    else:
        print("Day: ", gday, "Month: ", month)
