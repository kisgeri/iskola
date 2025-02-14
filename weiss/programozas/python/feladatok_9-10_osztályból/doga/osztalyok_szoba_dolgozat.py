import random
class Szoba:
    def __init__(self, hoszusag=(100),szeleseg=(50),magasag=(50)):
        self.hoszusag
        self.szeleseg
        self.magasag
    def padlo(self):
        return self.hoszusag*self.szeleseg
    def festes(self):
        menyezet = self.hoszusag*self.szeleseg
        fal0es2 = (self.magasag*self.szeleseg)*2
        fal1es4 = (self.magasag*self.hoszusag)*2
        return menyezet + fal0es2 + fal1es4
    def szegelylec(self):
        return (self.hoszusag*self.szeleseg)/4
'''
print(Szoba.padlo(5))
print(Szoba.festes(5,3,5))
print(Szoba.szegelylec(50,30))
''' 

szoba01 = []
for _ in range(1):
    hoszusag=random.randint(120,300)
    szeleseg=random.randint(50,400)
    magasag=random.randint(200,250)
    szoba01.append(hoszusag)
    szoba01.append(szeleseg)
    szoba01.append(magasag)
print(szoba01)
szoba02 = []
for _ in range(1):
    hoszusag=random.randint(120,300)
    szeleseg=random.randint(50,400)
    magasag=random.randint(200,250)
    szoba02.append(hoszusag)
    szoba02.append(szeleseg)
    szoba02.append(magasag)
szoba03 = []
for _ in range(1):
    hoszusag=random.randint(120,300)
    szeleseg=random.randint(50,400)
    magasag=random.randint(200,250)
    szoba03.append(hoszusag)
    szoba03.append(szeleseg)
    szoba03.append(magasag)
for Szoba in szoba01:
    print(magasag,szeleseg,hoszusag)
