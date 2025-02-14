ív = [[1,1,1,1,1],
      [1,1,1,1,0],
      [1,1,0,0,0],
      [0,1,1,1,1]]
'''
for vonos in ív:
    print(vonos)
    
for vonos in ív:
    for nap in vonos:
        if nap == 1:
            print("itt", " ", sep="", end="")
        else:
            print("otthon", " ", sep="", end="")
    print()
    
adagok = 0
for vonos in ív:
    for nap in vonos:
        if nap == 1:
            adagok += 1
print("öszesen", adagok, "adagot kell fizetni pénteken")

adagok = 0
for vonos in ív:
    adagok += sum(vonos)
print("öszesen", adagok, "adagot kell fizetni pénteken")

adagok = 0
for vonos in ív:
    adagok += vonos.count(1)
print("öszesen", adagok, "adagot kell fizetni pénteken")

sorszam = None
legnagyobb = 0

for index in range(len(ív)):
    vonos_jelen = sum(ív[index])
    if vonos_jelen > legnagyobb:
        legnagyobb = vonos_jelen
        sorszam = index
print("a(z)", sorszam+1, "vonós volt a legtöbbet jelen ",legnagyobb, "alkalomal volt")

vonosok_jelenletei=[]

for vonos in ív:
    vonos_jelen = sum(vonos)
    vonosok_jelenletei.append(vonos_jelen)
    
sorszam = vonosok_jelenletei.index(max(vonosok_jelenletei))

print("A(z)", sorszam+1,"vonós volt a legtöbbet jelen")

vonosok_jelenletei=False
for vonos in ív:
    vonos_jelen = sum(vonos)
    if vonos_jelen == 5:
        vonosok_jelenletei=True
if vonosok_jelenletei:
    print("volt")
else:
    print("nem volt")
    



for nap_indexe in range(5):
    enyien_voltak = 0
    for vonos in ív:
        enyien_voltak += vonos[nap_indexe]
    if enyien_voltak == 4:
        print("A(z)",nap_indexe+1,"napon mindenki jelen volt")
'''
#tk 89/2
bevételek = [[130,156,231,112,96,311,231],
             [29,15,210,11,191,14,302],
             [143,222,98,101,184,201,87],
             [133,132,182,121,148,199,187]]

boltok_ösz = []
első = sum(bevételek[0])
második = sum(bevételek[1])
harmadik = sum(bevételek[2])
negyedik = sum(bevételek[3])
boltok_ösz.append(első)
boltok_ösz.append(második)
boltok_ösz.append(harmadik)
boltok_ösz.append(negyedik)

for index in range(len(boltok_ösz)):
    sorszam = boltok_ösz.index(max(boltok_ösz))
print("A(z)",sorszam+1,"boltnak volt a legnagyobb bevétele")

szombat = []
for bevétel in bevételek:
    for index in range(len(bevétel)):
        if index == 5:
            szombat.append(bevétel[index])
for index in range(len(szombat)):
    sorszam = szombat.index(max(szombat))
print(sorszam+1, "boltnak volt a legnagyobb a tegnapi bevétel")


legnagy_legkis_különbség = []
első = bevételek[0]
második = bevételek[1]
harmadik = bevételek[2]
negyedik = bevételek[3]

ekül = max(első) - min(első)
mkül = max(második) -min(második)
hkül = max(harmadik) -min(harmadik)
nkül = max(negyedik) -min(negyedik)

legnagy_legkis_különbség.append(ekül)
legnagy_legkis_különbség.append(mkül)
legnagy_legkis_különbség.append(hkül)
legnagy_legkis_különbség.append(nkül)
for index in range(len(legnagy_legkis_különbség)):
    sorszam = legnagy_legkis_különbség.index(max(legnagy_legkis_különbség))
print(sorszam+1,"boltnak volt a legnagyobb külömbsége ami",max(legnagy_legkis_különbség))

legnagyobb_különbség = 0
legnagyobb_különbség_helye = None
for index in range(len(bevételek)):
    különbség = max(bevételek[index]) - min(bevételek[index])
    if különbség > legnagyobb_különbség:
        legnagyobb_különbség = különbség
        legnagyobb_különbség_helye = index
print('A legnagyobb különbség:', legnagyobb_különbség, 'ami ebben a boltban volt:', legnagyobb_különbség_helye+1)


öszszombat = []
for bevétel in bevételek:
    for index in range(len(bevétel)):
        if index == 5:
            öszszombat.append(bevétel[index])

print(sum(szombat), "enyi volt az ösz tegnapi bevétel")

nap=[]
el=[]
ma=[]
ha=[]
ne=[]
ot=[]
hat=[]
he=[]
hatszaz = False
for bevétel in bevételek:
    for index in range(len(bevétel)):
        if index == 0:
            el.append(bevétel[index])
        if index == 1:
            ma.append(bevétel[index])
        if index == 2:
            ha.append(bevétel[index])
        if index == 3:
            ne.append(bevétel[index])
        if index == 4:
            ot.append(bevétel[index])
        if index == 5:
            hat.append(bevétel[index])
        if index == 6:
            he.append(bevétel[index])
oel=sum(el)
oma=sum(ma)
oha=sum(ha)
one=sum(ne)
oot=sum(ot)
ohat=sum(hat)
ohe=sum(he)

nap.append(oel)
nap.append(oma)
nap.append(oha)
nap.append(one)
nap.append(oot)
nap.append(ohat)
nap.append(ohe)

if nap[index] >= 600:
    hatszaz=True
if hatszaz:
    print("volt olyan nap hogy a bolt átlépte a hatszáz ezret")
        



     