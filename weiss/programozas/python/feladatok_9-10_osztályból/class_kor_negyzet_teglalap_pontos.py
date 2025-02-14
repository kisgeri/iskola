import random
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
    def __init__(self, aoldaal, b):
        self.aoldaal = aoldaal
        self.b = b

    def terulet(self):
        return self.aoldaal*self.b
    def kerulet (self):
        return (self.aoldaal*self.b) *2

negyzet01 = Negyzet(5)
print(negyzet01.kerulet())
print(negyzet01.terulet())

negyzet_adatok = []
negyzet_szamok = int(input("mondj egys számot "))
for _ in range(negyzet_szamok):
    a = random.randint(1,10)
    negyzet_adatok.append(Negyzet(a))
    
for negyzet in negyzet_adatok:
    print(f"a={negyzet.a}")
    print("K=",negyzet.kerulet())
    print("T=",round(negyzet.terulet(), 2))

teglalap01 = Teglalap(5)
print(teglalap01.kerulet())
print(teglalap01.terulet())

teglalap_adatok = []
teglalap_szamok = int(input("mondj egys számot "))
for _ in range(teglalap_szamok):
    aoldaal = random.randint(1,10)
    b = random.randint(1,10)
    teglalap_adatok.append(Teglalap(aoldaal))
    teglalap_adatok.append(Teglalap(b))
    
for teglalap in teglalap_adatok:
    print(f"a={teglalap.aoldaal}")
    print(f"b={teglalap.b}")
    print("K=",teglalap.kerulet())
    print("T=",round(teglalap.terulet(), 2))