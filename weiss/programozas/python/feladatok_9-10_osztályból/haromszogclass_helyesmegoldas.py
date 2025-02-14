from calendar import c
import random
class Haromszog:
    def __init__(self, a = (1), b = (1), c= (1)):
        self.a = a
        self.b = b
        self.c = c

    def kerulet(self):
        return self.a + self.b + self.c

    def terulet(self):
        s = (self.a + self.b + self.c)/2
        t = s*(s-self.a)*(s-self.b)*(s-self.c)
        t=float(t)
        return t**0.5

haromszog01 = Haromszog(6,5,4)
print(haromszog01.kerulet())
print(haromszog01.terulet())

def hszögell(a,b,c):
    ell = True
    if a+b > c and a+c and b or b+c and a:
        return ell == True
    else:
        return(ell == False)

szamok = []
haromszog_szamok = int(input("mondj egys számot "))
for _ in range(haromszog_szamok):
    a = random.randint(1,10)
    b = random.randint(1,10)
    c = random.randint(1,10)
    if hszögell == False:
        szamok.append(Haromszog(a,b,c))
    else:
        szamok.append(Haromszog(a,b,a+b-1))
for haromszog in szamok:
    print(f"a={haromszog.a}")
    print(f"b={haromszog.b}")
    print(f"c={haromszog.c}")
    print("K=",haromszog.kerulet())
    print("T=",round(haromszog.terulet(), 2))     