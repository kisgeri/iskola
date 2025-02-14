'''
szam = 0
while szam < 100:#< helyetesítjük a !=
    szam=szam + 1
    print(szam)
    
szam = 0
while szam != 100:
    szam=szam + 2
    print(szam)
    
   
szam = 0
while szam < 99:
    szam=szam + 3
    print(szam)
  
szam = 100
while szam != 0:
    szam=szam - 1
    print(szam)

szamlalo = 0
osszeg = 0
while szamlalo < 100:
    szamlalo += 1
    osszeg = osszeg + szamlalo
print('öszesen:' , osszeg)


import random


gszam = random.randint(1,6)
kitalalta = False
while not kitalalta:
    tipp = int(input("szerinted? "))
    if tipp == gszam:
        kitalalta = True
        print("a helyes szám" , gszam , "volt")
        
#tk 116/8 házi bef
import random

gszam = random.randint(1,6)
kitalalta = False
szamlalo = 0
while not kitalalta and szamlalo < 3:
    tipp = int(input("szerinted? "))
    szamlalo += 1
    if tipp == gszam:
        kitalalta = True
        print("sikerült a helyes szám" , gszam , "volt")
    elif tipp == gszam + 1 or tipp == gszam - 1:
        print("majdnem")
        szamlalo += 1
    else:
        print("nem sikerült ki találni")
  
szam1 = 0
while szam1 != 100:
    szam1 += 1 #ez ugyan az mint a szam=szam + 1 csak rövideben
    print("szeretem a programozást")
    


x=1 
while 3*x + 2 != 59: 
 x = x + 1 
print('A megoldás:', x)
'''
#tk 117/1/b bef
x=1 
while (6*x)**2 + 3*x + 8 != 767: #a ** felsőbb rendü mint a *
    x = x + 1 
print('A megoldás:', x)


