#tk 117 118 119 végig
'''
import random

dobas = random.randint(1,2)
if dobas == 1:
    print("fej")
else:
    print("írás")
'''    
    
import random
szamlalo = 0
fej = 0
while szamlalo < 1000000:
    dobas = random.choice(["fej" , "írás"])#choice azt jelenti hogy választ a szogletes zárójelbe megadotakból
    if dobas == "fej":
        fej += 1
    szamlalo += 1
print("enyi fej lett:" , fej, "db\n enyi írás:" , 1000000-fej, "db")