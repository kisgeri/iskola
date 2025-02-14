'''
#sorozatszámitás,öszegzés
bevetelek = [1,5,2,3,4]
osszes = 0
for bevetel in bevetelek:
    osszes += bevetel
print('Napi bevétel:', osszes, 'picula.')

osszes = sum(bevetelek)
print('Napi bevétel:', osszes, 'picula.')

libak = [1,5,2,3,4]
roka = 0
for liba in libak:
    if liba <= 3:
        roka += liba
print('A rókának', roka, 'kilónyi liba marad.')

#átlag
osszes = sum(bevetelek)
darab = len(bevetelek)
print('Az átlagos bevétel:', osszes/darab, 'picula.')

libak = [1,5,2,3,4]
roka = 0
darab = 0
for liba in libak:
    if liba <= 3:
        roka += liba
        darab += 1
print('A róka libái átlagosan', roka/darab, 'kilósak.')

#eldöntés
bevételek = [1,5,2,3,4]
vanilyen = False
for bevétel in bevételek:
    if bevétel == 5:
        vanilyen = True
        break
if vanilyen:
    print('Van ötpiculás bevétel.')
    
if 5 in bevételek:
    print('Van ötpiculás bevétel.')
    
libák = [1,5,2,3,4]
vanilyen = False
for liba in libák:
    if liba >= 3:
        vanilyen = True
        break
if vanilyen:
    print('Van legalább egy háromkilós liba.')
    
libák = [1,5,2,3,4]
vanilyen = False
for index in range(len(libák)):
    if index > 0:
        if libák[index] < libák[index-1]:
            vanilyen = True
            break
if vanilyen:
    print('Volt, amikor kisebb libát lopott az előző napinál.')

#kiválasztás
bevételek = [1,5,2,3,4]
holvan = None
for index in range(len(bevételek)):
    if bevételek[index] == 5:
        holvan = index
        break
print('Az ötpiculás fuvar sorszáma:', holvan + 1)

print('Az ötpiculás fuvar sorszáma:', bevételek.index(5) + 1)

libák = [1,5,2,3,4]
holvan = None
for index in range(len(libák)):
    if libák[index] >= 3:
        holvan = index
        break
print('Az első nagy libát a(z) ', index+1, '. napon fogta a róka.', sep='')

#keresés
bevételek = [1,5,2,3,4]
vanilyen = False
holvan = None
for index in range(len(bevételek)):
    if bevételek[index] == 5:
        vanilyen = True
        holvan = index
        break
if vanilyen:
    print('Az ötpiculás fuvar sorszáma:', holvan + 1)
else:
    print('Nincs ötpiculás fuvar.')

if 5 in bevételek:
 print('Az ötpiculás fuvar sorszáma:', bevételek.index(5) + 1)
else:
 print('Nincs ötpiculás fuvar.')

libák = [1,5,2,3,4]
vanilyen = False
holvan = None
for index in range(len(libák)):
    if libák[index] >= 3:
        vanilyen = True
        holvan = index
        break
if vanilyen:
    print('A róka első legalább 3kilós libája:', holvan + 1)
else:
    print('Nincs legalább 3 kilós liba.')

#megszámlálás
bevételek = [1,5,2,3,4]
ennyi = bevételek.count(5)
print('Összesen', ennyi, 'ötpiculás fuvar volt.')

libák = [1,5,2,3,4]
számláló = 0
for liba in libák:
    if liba <= 3:
        számláló += 1
print(számláló, 'libája marad a rókának.')

#max és min
bevételek = [1,5,2,3,4]
legtöbb = 0
for bevétel in bevételek:
    if bevétel > legtöbb:
        legtöbb = bevétel
print('A legjobb fuvar', legtöbb, 'piculát ért.')

print('A legjobb fuvar', max(bevételek), 'piculát ért.')
print('A legrosszabb csak', min(bevételek), 'piculát hozott.')

libák = [1,5,2,3,4]
farkas_legkisebb_libája = 5
for liba in libák:
    if liba >= 4:
        if liba < farkas_legkisebb_libája:
            farkas_legkisebb_libája = liba
print('A farkasnak jutó legkisebb liba',
 farkas_legkisebb_libája, 'kg.')


bevételek = [3, 8, 10, 19.35, -6, 5.1, 9, 20]
vásárolt_a_pincér = False
for bevétel in bevételek:
    if bevétel < 0:
        vásárolt_a_pincér = True
        break
if vásárolt_a_pincér:
    print('Volt, hogy a pincér vásárolt is.')
else:
    print('Csak a pincérnek fizettek.')

print('A pénztárcában', sum(bevételek), 'font van.')

ennyiszer_kapott_pennyt = 0
for bevétel in bevételek:
    if bevétel > 0 and bevétel % 1 != 0:
        ennyiszer_kapott_pennyt += 1
print('A pincér', ennyiszer_kapott_pennyt,'alkalommal kapott pennyt.')

ennyi_pennyt_kapott_fontban = 0
for bevétel in bevételek:
    if bevétel > 0 and bevétel % 1 != 0:
        ennyi_pennyt_kapott_fontban += bevétel % 1
ennyi_pennyt_kapott_fontban = ennyi_pennyt_kapott_fontban * 100
print('A pincér', round(ennyi_pennyt_kapott_fontban),'pennyt kapott.')

bevételek = [3, 8, 10, 19.35, -6, 5.1, 9, 20]
szam = input("menyi legyen a szam? ")
szam = int(szam)
ennyiszer_kapott_legalább_5_fontot = 0
for bevétel in bevételek:
    if bevétel >= szam:
        ennyiszer_kapott_legalább_5_fontot += bevétel
print('A pincér',ennyiszer_kapott_legalább_5_fontot,'alkalommal kapott legalább 5 fontot.')

bevételek = [3, 8, 10, 19.35, -6, 5.1, 9, 20]
print('A legnagyobb számlán', max(bevételek), 'állt.')

def kiszámol(bevételek_listája, kezdeti_pénz):
    végső_pénz = sum(bevételek_listája) + kezdeti_pénz
    return végső_pénz
eleve_a_tárcában = float(input('Mennyi pénz \ van a pincérnél az óra elején? '))
print('A pénztárcában',round(kiszámol(bevételek, eleve_a_tárcában), 2),'font van.')

bevételek = [3, 8, 10, 19.35, -6, 5.1, 9, 20]
print('A ', bevételek.index(9)+1, '. vendég fizetett 9 fontot.', sep='') 

van_több_mint_10 = False
hol_van = 0
for index in range(len(bevételek)):
    if bevételek[index] > 10:
        van_több_mint_10 = True
        hol_van = index
        break
if van_több_mint_10:
    print('Az első tíz fontnál többet fizető vendég a(z) ',hol_van+1, '. vendég.', sep='')
    
    van_több_mint_10 = False
hol_van = 0
for index in range(len(bevételek)):
    if bevételek[index] > 10:
        van_több_mint_10 = True
        hol_van = index
if van_több_mint_10:
    print('Az első tíz fontnál többet fizető vendég a(z) ',hol_van+1, '. vendég.', sep='')
    
for bevétel in bevételek:
    if bevétel % 5 == 0:
        print('Volt olyan vendég, aki tudott csupa ötössel fizetni.')
        break
    
vendégek = 0 
for bevétel in bevételek: 
    if bevétel > 0: 
        vendégek += 1 
print('A pincér', round(vendégek/2, 2 ), 'font fizetést kap.')
'''
mondat = ['Én', 'elmentem', 'a', 'vásárba', 'fél', 'pénzen.']
print('A mondat', len(mondat), 'szóból áll.')

legrövidebb_szó_hossza = 1000 
for szó in mondat: 
    if len(szó) < legrövidebb_szó_hossza: 
        legrövidebb_szó_hossza = len(szó) 
print('A legrövidebb szó', legrövidebb_szó_hossza, 'karakteres.')

írásjelek = '.?!'
for szó in mondat:
    if szó[-1] in írásjelek:
        print('Van olyan szó, ami után írásjel áll.')
        
nevelo = ['a' ,'az']
for szó in mondat:
    if szó in nevelo:
        print('Van olyan szó, ami után írásjel áll.')

print('A mondatban a "fél" szó a', mondat.index('fél')+1,'. helyen áll.', sep='')


van_nagy_kezdőbetűs = False
hol_van = None
for index in range(len(mondat)):
    if mondat[index][0].isupper():
        van_nagy_kezdőbetűs = True
        hol_van = index
        break
if van_nagy_kezdőbetűs:
    print('A(z) ', hol_van+1,'. szó kezdődik nagybetűvel.', sep='')
