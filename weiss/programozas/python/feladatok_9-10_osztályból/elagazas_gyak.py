#1.feladat betü-e
'''
szoveg = input("írj be dolgokat:")
szoveg = szoveg.isalpha()
if szoveg == True:
    print(szoveg)

#2.feladat köszönjön-e
koszone = input("köszönjön el a program? ")
if koszone == "igen":
    print("viszontlátásra!")

#3.feladat szóköz van e
szoveg = input("írj be egy szöveget: ")
if " " in szoveg:
    print("a beírt szöveg több szóbol ál." ,
"enyi karakterből ál a beírt szöveg" ,len(szoveg))

#4.feladat oszthatóság
szam = input("adj meg egy egész számot: ")
szam = int(szam)
if szam % 3 == 0:
    print(3)
if szam % 4 == 0:
    print(4)
if szam % 9 == 0:
    print(9)
'''  
'''
5.feladat. a program ki írja hogy páros e a szám vagy sem.
kiír:program neve
be = szám számtípusú
ha szám osztva 2-vel 0 a maradék igaz:
    kiír:a szám páros
ha szám osztva 2-vel 0 a maradék hamis:
    kiír:a szám nem páros
'''
'''
print("Ide jön a program neve program. ")
szám = int(input("írj be egy egész számot"))
if szám % 2 == 0:
    print("A szám páros")
else:
    print("A szám nem páros")

#6.feladat melyik nagyobb
szam = float(input("adj meg egy számot "))
szam1 = float(input("adj meg egy számot "))
if szam > szam1:
    print("az első szám nagyobb")
else:
    print("a második szám nagyobb")

#7.feladat kiskorú
kor = int(input("hány éves vagy "))
if kor < 18:
    print("nem mehetsz be a filmre")
else:
    print("mehetsz")

#8.feladat negatív vagy pozitív
szam = int(input("írj be egy számott "))
if szam > 0:
    print("ez a szám pozitív")
else:
    print("ez a szám negatív")

#9. nagyobb egyenlő
szam = int(input("írj be egy számott "))
if szam > 50 or szam == 50:
    print("nem kisebb mint 50")
else:
    print("kisebb mint 50")

#10.feladat között
szam = int(input("írj be egy számott "))
if szam < 50 and szam > -50:
    print("a szám -50 és 50 közé esik")

#11.feladat cselekvőképes
kor = int(input("hány éves vagy "))
if kor < 14:
    print("Cselekvőképtelen vagy! Nem adhatsz érvényes jognyilatkozatot.")
elif kor >= 14 and kor < 18:
    print("A szüleid belegyezésével adhatsz csak érvényes jognyilatkozatot.")
else:
    print("Nagykorú vagy! Adhatsz érvényes jognyilatkozatot.")

#12.feladat kisebb nagobb egyenlő
szam = int(input("adj meg egy számot "))
szam1 = int(input("adj meg egy számot "))
if szam > szam1:
    print("az első szám a nagyobb")
elif szam == szam1:
    print("a két szám egyenlő")
else:
    print("a második szám nagyobb")

#13.feladat víz halmazálapot
viz = int(input("hány fokos a víz? "))
if viz < 0:
    print("a halmaz álapott jég")
elif viz > 100:
    print("a halmaz álapott gőz")
else:
    print("a víz folyékony")

#14.feladat pozitív negatív nulla
szam = float(input("adj meg egy tort szamot "))
if szam < 0:
    print("ez egy negatív szám")
elif szam > 0:
    print("ez egy pozitív szám")
else:
    print("a szám nulla")

#15.feladat balaton vízmélység
balaton = float(input("Milyen mély a balaton? "))
if balaton < 1 and balaton > 0:
    print("pancsolunk")
elif balaton >= 1 and balaton <= 2:
    print("úszunk")
elif balaton > 2:
    print("nem megyünk be")
'''
#16.feladat hány jegyü
