#9.-es tk 107. oldal
#2 km tengeri mérföld váltás
km = input("írj valamenyi km-et: ")
valtas = float(km) * 1000 / 1852
print(km, "enyi tengeri mérföld ", valtas)

#visza váltás
mf = input("írj valamenyi km-et: ")
valtas = float(mf) * 1852 / 1000
print(mf, "enyi km ", valtas)



#3 be kérünk 2 számot adjuk ösze írjuk ki, mellé (az öszegüket) ki írjuk hogy így nézen ki 2 és 3 öszege: 5.
elso = input("írj egy egész számot: ")
masodik = input("írj még egy egész számot: ")
eredmeny = int(elso) + int(masodik)
print(eredmeny)
print("összegük:" , eredmeny)
print(elso, "és", masodik, "összege:" , eredmeny)



#4 írjuk át a programot szorzásra
elso = input("írj egy egész számot: ")
masodik = input("írj még egy egész számot: ")
eredmeny = int(elso) * int(masodik)
print(eredmeny)
print("összegük:" , eredmeny)
print(elso, "és", masodik, "szorzata:" , eredmeny)
