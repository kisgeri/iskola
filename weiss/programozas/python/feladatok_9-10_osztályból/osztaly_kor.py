import random
from re import A

class Kor:
    def __init__(self, sugar, kozeppont = (0, 0)):
        self.sugar = sugar
        self.kozeppont = kozeppont

    def terulet(self):
        return pow (self.sugar, 2)*3.14
    def kerulet (self):
        return 2*self.sugar*3.14

class Negyzet:
    def __init__(self, a):
        self.a = a

    def terulet(self):
        return self.a**2
    def kerulet (self):
        return 4 * self.a

class Teglalap:
    def __init__(self, aoldaal,b = (1)):
        self.aoldaal = aoldaal
        self.b = b

    def terulet(self):
        return self.aoldaal*self.b
    def kerulet (self):
        return self.aoldaal*self.b *2
    
class Haromszog:
    def __init__(self, oldal1,b1 = (1),c = (1),ma=(1)):
        self.oldal1 = oldal1
        self.b1 = b1
        self.c = c
        self.ma = ma

    def terulet(self):
        return pow (self.oldal1, 2)*self.ma*2
    def kerulet (self):
        return self.oldal1+self.b1+self.c

kor01 = Kor(5)
print(kor01.terulet())
kor02 = Kor(10,(1,1))
print(kor02.kozeppont)
print(kor02.kerulet())

negyzet01 = Negyzet(5)
print(negyzet01.terulet())
negyzet02 = Negyzet(10)
print(negyzet02.kerulet())

teglalap01 = Teglalap(5)
print(teglalap01.terulet())
teglalap02 = Teglalap(10,(1))
print(teglalap02.kerulet())

haromszog01 = Haromszog(5)
print(haromszog01.terulet())
haromszog02 = Haromszog(10,(1),(1))
print(haromszog02.kerulet())

korok = []
for _ in range(5):
    kor = Kor(random.randint(1,10))
    korok.append(kor)

for _ in korok:
    print(kor.sugar, kor.terulet())

print(korok[1].sugar )

negyzetek = []
for _ in range(5):
    negyzet = Negyzet(random.randint(1,10))
    negyzetek.append(negyzet)
for _ in negyzetek:
    print(negyzet.a, negyzet.terulet())

print(negyzetek[1].a )

teglalapok = []
for _ in range(5):
    teglalap = Teglalap(random.randint(1,10))
    teglalapok.append(teglalap)
for _ in teglalapok:
    print(teglalap.aoldaal, teglalap.terulet())

print(teglalapok[1].aoldaal )

haromszogek = []
for _ in range(5):
    haromszog = Haromszog(random.randint(1,10))
    haromszogek.append(haromszog)
for _ in haromszogek:
    print(haromszog.oldal1, haromszog.terulet())

print(haromszogek[1].oldal1 )