
with open("./fajl/penzfeldobas.txt", "r") as fajl:

    szam = 0
    fej = 0
    iras = 0
    for sor in fajl:
        print(sor)
        szo=sor.split()
        if "F" in szo:
            szam+=1
            fej+=1
        if "I" in szo:
            szam+=1
            iras+=1
        
    print(f"Ennyi dobás volt {szam}")
    print(f"Ennyi fej volt {fej} ")
    szazalek = iras / szam *100
    szazalek = round(szazalek, 2)
    print(f"enyi százaléka volt írás {szazalek}")

    ketf =0  
    for sora in fajl:
        print(sora)
        szok = sora.strip().split(",")
        for index , dobas in enumerate(sora):
            print(index)
            if index > 0 and dobas == dobasok[index-1]:
                ketf += 1
    print(ketf) 


'''
with open("./fajl/kfajl.txt", "w", encoding="utf-8") as cfájl:
    print(szam,fej,szazalek,ketf, file=cfájl)
'''
'''
import random
ssam = input("milyen hosszú legyen a lista? ")
ssam = int(ssam)
dobas = ["F","I"]
masik_dobas = []
for _ in range(ssam):
    print(random.choice(dobas))
    masik_dobas.append(random.choice(dobas))
print(masik_dobas)
with open("./fajl/dobas2.txt", "w") as cfájl:
    print(masik_dobas, file=cfájl)
'''


