'''
import random
gszam = random.randint(1,6)
print(gszam)
kitalalta = False
pesely = False
szamlalo = 0
while not kitalalta and szamlalo < 3:
    tipp = int(input("szerinted mi a szám "))
    if tipp == gszam:
        kitalalta = True
        print("talalt")
    else:
        if szamlalo == 2 and not pesely:
            if tipp == gszam +1 or gszam -1:
                print("csak egyet tévedtél kapsz még egy esélyt ")
                pesely = True
                
        else:
            print("nem talalt ")
            szamlalo += 1



x=1
while 3*x +2 != 59:
    x = x +1
print("a megoldás:", x)


x= 1
while 6*x**2 + 3*x +8 != 767:
    x = x+1 
print("a megoldás:",x)



x=1
while x/6 + x/12 + x/7 + 5 + x/2 + 4 != x:
    x = x+1
print (x ,"évesen halt meg Diophantosz")


import random
szamlalo = 0
fej = 0
while szamlalo < 1000000:
    dobas = random.choice(["fej" , "írás"])
    if dobas == "fej":
        fej += 1
    szamlalo += 1
print("enyi fej lett:" , fej, "db\n enyi írás:" , 1000000-fej, "db")


import random
szamlalo = 0
egy = 0
ketto = 0
harom = 0
negy = 0
ot = 0
hat = 0
while szamlalo < 1000000:
    dobas = random.choice([1 , 2,3,4,5,6])
    if dobas == 1:
        egy += 1
    elif dobas == 2:
        ketto += 1
    elif dobas == 3:
        harom += 1
    elif dobas == 4:
        negy += 1
    elif dobas == 5:
        ot += 1
    else:
        hat += 1
    szamlalo += 1
print ("egyesek:" , egy , "kettes:",ketto,"harmas:",harom,"\n négyes:",negy,"ötös:",ot,"hatos:",hat)

import random
szamlalo = 0
egy = 0
ketto = 0
harom = 0
negy = 0
ot = 0
hat = 0
while szamlalo < 1000000:
    dobas = random.choice([1 , 2,3,4,5,6,6])
    if dobas == 1:
        egy += 1
    elif dobas == 2:
        ketto += 1
    elif dobas == 3:
        harom += 1
    elif dobas == 4:
        negy += 1
    elif dobas == 5:
        ot += 1
    else:
        hat += 1
    szamlalo += 1
print ("egyesek:" , egy , "kettes:",ketto,"harmas:",harom,"\n négyes:",negy,"ötös:",ot,"hatos:",hat)

import random

zszam = random.choice([2,3,4])
szam=0
while szam != zszam:#ha a zszam helyet 3 lenne fixen elküldene ha 3szor rosz választ adok
    szam += 1
    kerdes = input ("szeretsz engem? ")
    if kerdes == "nagyon":
        break
    elif kerdes == "jobban mint a kókuszgolyót":
        break
    elif szam == zszam:
        print("takarodj")

szam = 100
while szam > -100:
    print(szam)
    szam -= 1
  
szám = 1
while szám < 9:
 #print(szám, end='')
 szám += 1
while szám > 0:
 #print(szám, end='')
 szám -= 1
print('')  #nem hagy ki egy sort ha ki hadjuk a print('')
#egy helyen kell a kilencet kell át írni 9999999
#lényeg telen szinte ugyan olyan gyorsan oldja meg
'''
csillagszámláló = 1
while csillagszámláló <= 10:
        print('*', end='')
        csillagszámláló += 1
print('')
print('')

sorszámláló = 1
while sorszámláló <= 5:
    csillagszámláló = 1
    while csillagszámláló <= 10:
        print('*', end='')
        csillagszámláló += 1
    print('')
    sorszámláló += 1
 

darab = 1
oszlop = 1
while oszlop <= 5:
    csillag = 1
    while csillag <= darab:
        print('*', end='')
        csillag += 1
    print('')
    darab += 1
    oszlop += 1



darab = 1
oszlop = 1
while oszlop <= 5:
    csillag = 1
    while csillag <= darab:
        if oszlop <= 5 and csillag == 1:
            print('*', end='')
        elif oszlop == csillag:
            print('*', end='')
        else:
            print(' ', end='')
        #print(f"({oszlop};{csillag}) ", end="")
        #print(f"({oszlop+csillag})" , end='')
        csillag += 1
    print('')
    darab += 1
    oszlop += 1

szorzando = 1
while szorzando <= 10:
    szorzo = 1
    while szorzo <= 10:
        print(szorzando , "*" , szorzo , "=" , szorzando*szorzo)
        szorzo += 1
    print(" ")
    szorzando += 1

