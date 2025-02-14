#több soros meg jegyzés 3 "
"""
#egyirányu 
gondolt_szam = 4
print ("gondoltam egy számra találd ki melyikre")
tipp = input("tipeld meg itt: ")
tipp = int(tipp)
if tipp == gondolt_szam :
    print ("ügyes vagy")
print ("szia")
"""

"""
#2 irányu
gondolt_szam = 4
print ("gondoltam egy számra találd ki melyikre")
tipp = input("tipeld meg itt: ")
tipp = int(tipp)
if tipp == gondolt_szam :
    print ("ügyes vagy")
    print ("gratulálok!")
else:
    print ("sokat gondolkodtál rajta? :)")
    print ("nem érte meg ;)")
print ("szia")
"""


gondolt_szam = 4
print ("gondoltam egy számra találd ki melyikre")
tipp = input("tipeld meg itt: ")
tipp = int(tipp)
if tipp == gondolt_szam :
    print ("ügyes vagy")
    print ("gratulálok!")
elif tipp == gondolt_szam - 1 or tipp == gondolt_szam + 1:
    print ("óh, csak egyel tévedtél")
else:
    print ("sokat gondolkodtál rajta? :)")
    print ("nem érte meg ;)")
print ("szia")