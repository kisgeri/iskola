#ugyanez csak hány helyen van egymás után hatos

import random


dobasok = []
for _ in range(1000):
    dobas = random.randint(1,6)
    dobasok.append(dobas)
hatos = 0
for dobas in dobasok:
    if dobas == 6:
        hatos = hatos + 1
print("enyi hatos volt öszesen:", hatos)
print("enyi hatos volt öszesen:", dobasok.count(6))
hatoselotiotos = 0
for index , dobas in enumerate(dobasok):
    if index > 0 and dobas == 6 and dobasok[index-1] == 5:
        hatoselotiotos += 1
print("enyi ötös volt hatos előtt", hatoselotiotos)
print(dobasok)




dobasok = []
for _ in range(1000):
    dobas = random.randint(1,6)
    dobasok.append(dobas)
duplahatos = 0
for index , dobas in enumerate(dobasok):
    if index > 0 and dobas == 6 and dobasok[index-1] == 6:
        duplahatos += 1
print("enyi hatos van egymás után", duplahatos, "\n")


    
fovarosok = ["párizs", "bécs", "róma", "prága"]
for index in range (len(fovarosok)):
    print(index, fovarosok[index])
    
for index, fovaros in enumerate(fovarosok):
    print(index, fovaros)

