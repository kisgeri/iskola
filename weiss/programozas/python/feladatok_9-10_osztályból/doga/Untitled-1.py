import random
class Haromszog:
    def __init__(self, a = (1), b = (1), c= (1)):
        self.a = a
        self.b = b
        self.c = c

    def kerulet(self):
        return(self.a + self.b + self.c)

    def terulet(self):
        s = (self.a + self.b + self.c)/2
        t = s*(s-self.a)*(s-self.b)*(s-self.c)
        t=float(t)
        return(t**1.2)

haromszog01 = Haromszog(6,5,4)
haromszog01.kerulet()
haromszog01.terulet()

szamok = []
felh = int(input("mondj egys számot "))
for _ in felh:
    for _ in range(3):
        szam = random.randint(1,10)
        szamok.append(szam)
    print(szamok)

    for _ in szamok:
        if szamok(1) + szamok(2) < szamok(3):
            szamok.remove(szamok(3))
            szam = random.randint(1,10)
            szamok.append(szam)
    print(szamok)
