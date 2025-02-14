'''
import random
def játékválasztó(nev):
    if nev in lany_nevek:
        jatek = random.choice(lany_jatek)
    elif nev in fiu_nevek:
        jatek = random.choice(fiu_jatek)
    else:
        neme = input("Milyen nemü a ma gyerek(fiu/lány) ")
        if neme == "lány":
            jatek = random.choice(lany_jatek)
        else:
            jatek = random.choice(fiu_jatek)
    print(jatek)
        
lany_nevek = ["Kata"]
fiu_nevek = ["János"]
lany_jatek = ["Baba", "kiskonyha", "kirakó"]
fiu_jatek = ["autó", "fakard", "focilabda", "kirakó"]
nev = None
while nev != '':
    nev = input("kérlek adj meg egy nevet: ")
    if nev != "":
        játékválasztó(nev)
'''     
        
def hány_főváros(városok):
    fővárosok = ["Párizs", "Riga", "Budapest", "Bécs", "Prága", "Bukarest", "Berlin"]
    fővárosok_száma = 0
        for város in városok:
            if városok in fővárosok:
                fővárosok_száma += 1
        print(fővárosok_száma, "főváros van a listában.")
város = None
while város != "":
    város = input("Kérlek adj meg egy várost")
    if város != "":
        hány_főváros(városok)
        
            