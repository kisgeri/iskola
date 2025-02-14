'''
#olvasás
import os

if os.path.exists("./fajl/nem.txt"):
    fájl = open("./fajl/nem.txt")
    print(fájl)


with open("./fajl/nem.txt") as fájl:
    print(fájl.name, fájl.mode)
    
with open("./fajl/nem.txt", "r", encoding="utf-8") as fájl:
    print(fájl.tell())
    print(fájl.readline())
    print(fájl.readline())
    fájl.seek(0)
    print(fájl.readline())
    print(fájl.tell())
    fájl.seek(0)
    print(fájl.readlines())
    fájl.seek(0)
    print(fájl.read())
    fájl.seek(0)
    for sor in fájl:
        print(sor)
    fájl.seek(0)
    for sor in fájl:
        print(sor.strip())
 
 
autok = []
with open("./fajl/auto.txt", "r", encoding="utf-8") as fájl:
    for sor in fájl:
        print(type(sor))
        print(sor.strip().split(","))
        adatok = sor.strip().split(",")
        auto = {"rendszam":adatok[0],"típus":adatok[1],"kor":int(adatok[2])}
        autok.append(auto)
print(f"{autok}")
'''
'''
módok r = read ,  W = write  , a = append , a+ = ugyan az min az a csak lehet olvasni is   
x csak akkor csinál új fájlt ha nem létezik ilyen
'''
'''
#írás      
with open("./fajl/kimenet.txt", "w", encoding="utf-8") as cfájl:
    print("ez kerül mentésre", file=cfájl)
with open("./fajl/nem.txt", "a", encoding="utf-8") as cfájl:
    print("ez kerül mentésre", file=cfájl)
with open("./fajl/nem.txt", "a+", encoding="utf-8") as cfájl:
    print("ez kerül mentésre", file=cfájl)
    cfájl.write("k\n")
    cfájl.writelines(["banán\n","alma\n"])
    cfájl.seek(0)
    print(cfájl.read())
    
with open("./fajl/nem.txt", "r", encoding="utf-8") as fájl:
    with open("./fajl/uj.txt", "w", encoding="utf-8") as cfájl:
        for sor in fájl:
            print(sor.strip(), file=cfájl)

with open("./fajl/uj1.txt", "x", encoding="utf-8") as cfájl:
    print("ez kerül mentésre", file=cfájl)
'''
with open("./fajl/banan_1.jpg", "rb") as kfájl:
     with open("./fajl/banan.jpg", "wb") as kfájlm:
         darab_meret = 4096
         darab = kfájl.read(darab_meret)
         while len(darab) > 0:
             kfájlm.write(darab)
             drab = kfájl.read(darab_meret)
             
        
 
 