lopot_halak=[[1,0,3,0,4,2,2],
             [0,0,8,6,4,6,3],
             [0,1,4,2,0,2,0],
             [0,3,2,3,6,0,3]]
sok_hal = []
minden_nap_osz = []
hetfo = []
kedd = []
szerda = []
csutortok = []
pentek = []
szombat = []
vasarnap = []
for p in lopot_halak:
    hetfo.append(int(p[0]))
    kedd.append(int(p[1]))
    szerda.append(int(p[2]))
    csutortok.append(int(p[3]))
    pentek.append(int(p[4]))
    szombat.append(int(p[5]))
    vasarnap.append(int(p[6]))
minden_nap_osz.append(sum(hetfo))
minden_nap_osz.append(sum(kedd))
minden_nap_osz.append(sum(szerda))
minden_nap_osz.append(sum(csutortok))
minden_nap_osz.append(sum(pentek))
minden_nap_osz.append(sum(szombat))
minden_nap_osz.append(sum(vasarnap))
print(minden_nap_osz)
lop = False
for i in range(len(minden_nap_osz)):
    if minden_nap_osz[i] >= 12:
        lop = True
        if i == 0:
            sok_hal.append("hétfő")
        elif i == 1:
            sok_hal.append("kedd")
        elif i == 2:
            sok_hal.append("szerda")
        elif i == 3:
            sok_hal.append("csütörtök")
        elif i == 4:
            sok_hal.append("pénetk")
        elif i == 5:
            sok_hal.append("sszombat")
        elif i == 6:
            sok_hal.append("vasárnap")
        sok_hal.append(minden_nap_osz[i])

if lop:
    print(sok_hal)
else:
    print("nem volt olyan nap amikor 12 vagy több hallat lopott volna")

