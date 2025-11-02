A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!

A. feladat:
    SELECT COUNT(DISTINCT(tanulo)) as "Papírgyűjtésben résztvevők"
	FROM leadasok

B. feladat:
    SELECT COUNT(*) as "A-val kezdődő nevüek száma"
	FROM tanulok
    WHERE nev LIKE("A%")

C. feladat:
SELECT LEFT(nev,1) AS "kezdőbetü", COUNT(*) as "darabszam"
	FROM tanulok
    GROUP BY kezdőbetü
    ORDER BY kezdőbetü

D. feladat:
SELECT LEFT(nev,1) AS "kezdőbetü"
	FROM tanulok
    GROUP BY kezdőbetü
    HAVING COUNT(*) >= 20
    ORDER BY COUNT(*) DESC    

E. feladat:
SELECT COUNT(*) AS DB
	FROM leadasok
    GROUP by (mennyiseg > 2000)

F. feladat:
SELECT IF(mennyiseg > 2000, "Súlyos tételek", "Könnyű tételek") AS "Kategorizálás",COUNT(*) AS DB
	FROM leadasok
    GROUP by (mennyiseg > 2000)