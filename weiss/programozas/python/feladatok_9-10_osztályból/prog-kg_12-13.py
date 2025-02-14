

print ("téglalap program")
A = input ("kérlek ad meg a téglalap A oldalának hoszát méterben: ")
B = input ("kérlek ad meg a B oldal hoszát méterben : ")
ker = float(A) * float(B)
ter = float(A) + float(B)
ter0 = float(ter) * 2
print ("a területte" , ker , "m" " a kerülete" , ter0 , )
cm = input ("mondj egy cm-et: ")
inch = float(cm) / 2.54
print (cm , "cm =" , inch , "inch")


szam = input ("kérlek mondj egy egész számot: ")
szam0 = input ("kérlek mondj még egy egész számot: ")
szamt = int(szam) + int(szam0)
szamt = int(szamt) / 2
mert =  int(szam) * int(szam0)
mert =  float(mert) ** 1.2
print ("a megadot számok számtani közepe:" , szamt , "a mértani közepe pedig:" , mert)


szamk = input("kérlek mondj egy számot: ")
szamk = float(szamk)
if szamk >= 0 :
    print ("az általad meg adott szám pozitív")
else:
    print ("az általad meg adott szám negatív")


vnev = input ("kérlek mondmeg a vezeték neved: ")
knev = input ("kérlek mondmeg a kereszt neved: ")
print ("good morning" , knev , vnev)

kor = input ("hány éves vagy: ")
print ("te most" , kor , "éves vagy")
kor = int(kor)
if kor >= 0 and kor <= 3:
    print("totyogóknak a kettes szamrendszeről")
if kor >= 4 and kor <= 6:
    print("hackeljük meg az óvodát")
if kor >= 7 and kor <= 14:
    print("Felhőtechnológia a menzán")
if kor >= 15 and kor <= 18:
    print("big data a középiskolában")

#fájlt akartam használni de nem taáltam benne semmit

