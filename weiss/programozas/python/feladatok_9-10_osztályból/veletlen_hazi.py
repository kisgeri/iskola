import random

szam = random.randint(0,10000)
print (szam)


jelszo = 123
fjelszo = input ("mi a jelszo? ")
fjelszo = int(fjelszo)
if fjelszo == jelszo:
    print ("helyes a jelszó!")
else:
    print ("hozzáférés megtagadva")
elsoszam = input ("mondj egy számot ")
masodszam = input ("mondj még egy számot ")
if elsoszam >= masodszam:
    print ("az elsőszám a nagyobb")
elif elsoszam <= masodszam:
    print ("az másodikszám a nagyobb")


elso = random.randint(1,50)
masodik = random.randint(1,50)
oszeg = elso + masodik
tipp = input ("mi lehet az öszege két véletlen egész számnak 1 és 100 között: ")
tipp = int(tipp)
if tipp == oszeg:
    print ("szerencsés")
    
    
csapat1 = input("mi az egyik csapat neve? ")
pont1 = input("hány pontott szerzet: ")
csapat2 = input("mi a másik csapat neve? ")
pont2 = input("hány pontott szerzet: ")
pont1 = int(pont1)
pont2 = int(pont2)
print (csapat1 , "-" , csapat2)
print (pont1 , ":" , pont2)
if pont1 >= pont2:
    print(csapat1 , "nyert!")
else:
    print(csapat2 , "nyert!")
   

nev = input("mi a neved? ")
print ("szia" , nev)
kor = input("hány éves vagy? ")
kor = int(kor)
if kor <= 3:
    print("Totyogóknak a kettes számrendszerről")
if kor >= 4 and kor <=6:
    print("Hackeljük meg az óvodát!")
if kor >= 7 and kor <=14:
    print("Felhőtechnológia a menzán")
if kor >= 15 and kor <=18:
    print("Big data a középiskolában")
