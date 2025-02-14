'''
osztály = [['Noémi', 'l', 15, 'noemi@hipp.hopp'],
           ['Dezső', 'f', 17, 'dezso2@nyikk.nyekk'],
           ['Gizella', 'l', 16, 'gizi@pikk.pakk'],
           ['Edömér', 'f', 16, 'edo@itt.ott']]
for tag in osztály:
    print(tag[0], ": ", tag[-1], sep='')
    
összeg = 0
for tag in osztály:
    összeg += tag[2]
 
print('Az osztály átlagéletkora', összeg/len(osztály), 'év.')

lányok = 0 
for tag in osztály: 
    if tag[1] == 'l':
        lányok += 1
 
if lányok > len(osztály) - lányok:
    print('A lányok vannak többen.')
elif lányok < len(osztály) - lányok:
    print('A fiúk vannak többen.')
else:
    print('A fiúk pont annyian vannak, mint a lányok.')
    
for tag in osztály:
    print(tag[0])
nev = input("írj be a fenti nevekből egyet ")
for tag in osztály:
    for index in range(len(tag)):
        if tag[index] == nev:
            print(tag[-1])
            break

def szótáraz(magyar_szó):
    szótár = [['nagy', 'big'], ['pici', 'tiny'],
              ['én', 'I'], ['foci', 'soccer'],
              ['ott', 'there'], ['szarvas', 'deer'],
              ['soha', 'never']]
    for szó in szótár:
        if szó[0] == magyar_szó:
            return szó[1]
        elif szó[1] == magyar_szó:
            return szó[0]
    return 'Nincs ilyen szó a szótárban.'
kérdezett_szó = None
while kérdezett_szó != '':
    kérdezett_szó = input('Melyik magyar szóra vagy kíváncsi? ')
    if kérdezett_szó != '':
        print(kérdezett_szó, 'keresésének eredménye:',szótáraz(kérdezett_szó))
'''
szótár = {'nagy': 'big', 'pici': 'tiny',
          'én': 'I', 'foci': 'soccer',
          'ott': 'there', 'szarvas': 'deer',
          'soha': 'never'}
'''
kérdezett_szó = None
while kérdezett_szó != '':
    kérdezett_szó = input('Melyik magyar szóra vagy kíváncsi? ')
    if kérdezett_szó != '':
        print(kérdezett_szó, 'keresésének eredménye:',szótár.get(kérdezett_szó, 'Nincs ilyen szó.'))
'''


kérdezett_szó = None
while kérdezett_szó != '':
    kérdezett_szó = input('Melyik magyar szóra vagy kíváncsi? ')
    if kérdezett_szó != '':

        for kulcs in szótár:
            print(kulcs)

'''
osztály = [{'név': 'Noémi', 'nem': 'l', 'kor': 15},
           {'név': 'Dezső', 'nem': 'f', 'kor': 17},
           {'név': 'Gizella', 'nem': 'l', 'kor': 16},
           {'név': 'Edömér', 'nem': 'f', 'kor': 16}]
for tag in osztály:
    if tag['név'] == 'Dezső':
        print(tag['kor'])
        osztály = {'Noémi': {'nem': 'l', 'kor': 15},
                   'Dezső': {'nem': 'f', 'kor': 17},
                   'Gizella': {'nem': 'l', 'kor': 16},
                   'Edömér': {'nem': 'f', 'kor': 16}}
print(osztály['Dezső']['kor'])

összeg = 0
for tag in osztály:
    összeg += osztály[tag]['kor']
print('Az osztály átlagéletkora', összeg/len(osztály), 'év.')

lányok = 0 
for tag in osztály: 
    if osztály[tag]['nem'] == 'l':
        lányok += 1
'''
ív = {'egyik hegedűs': [1, 1, 1, 1, 1],
      'másik hegedűs': [1, 1, 1, 1, 0],
      'brácsás': [1, 1, 0, 0, 0],
      'csellós': [0, 1, 1, 1, 1]}
'''
vonosok_jelenletei=[]

for vonos in ív:
    vonos_jelen = sum(vonos)
    vonosok_jelenletei.append(vonos_jelen)
    
sorszam = vonosok_jelenletei.index(max(vonosok_jelenletei))

print("A(z)", sorszam+1,"vonós volt a legtöbbet jelen")
'''
