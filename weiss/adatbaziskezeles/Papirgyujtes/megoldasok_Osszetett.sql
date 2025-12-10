A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!

A. feladat:
SELECT DISTINCT(nev), osztaly
	FROM tanulok
    WHERE nev LIKE "A%" OR nev LIKE "D%" OR nev LIKE "J%"
    ORDER BY nev

B. feladat:
SELECT DISTINCT(nev), osztaly
	FROM tanulok
    WHERE osztaly LIKE "2A" OR nev LIKE "3B" OR nev LIKE "7A"
    ORDER BY osztaly

/*másik*/
SELECT DISTINCT(nev), osztaly
	FROM tanulok
    WHERE osztaly IN("2A", "3B", "7A")
    ORDER BY osztaly

C. feladat:
SELECT idopont, SUM(mennyiseg) AS "dkg"
	FROM leadasok
    WHERE idopont = "2016-10-10" OR idopont = "2016-10-28"
    GROUP BY idopont

/*másik*/
SELECT idopont, SUM(mennyiseg) AS "dkg"
	FROM leadasok
    WHERE idopont IN("2016-10-10", "2016-10-28")
    GROUP BY idopont

D. feladat:
SELECT AVG(mennyiseg) AS "Átlag"
	FROM leadasok
    WHERE idopont > "2016-10-12" || idopont < "2016-10-07"

SELECT SUM(mennyiseg) / COUNT(*) AS "Átlag"
	FROM leadasok
    WHERE idopont > "2016-10-12" || idopont < "2016-10-07"

/*másik*/
SELECT SUM(mennyiseg) / COUNT(*) AS "Átlag"
	FROM leadasok
    WHERE idopont NOT BETWEEN "2016-10-07" AND "2016-10-12"

E. feladat:
SELECT DISTINCT(osztaly)
	FROM tanulok
    WHERE osztaly NOT LIKE("2A")

/*másik*/
SELECT DISTINCT(osztaly)
	FROM tanulok
    WHERE osztaly NOT IN("2A")

/*megint másik ezt nem kéne a != szigorú sql-be nem jó*/
SELECT DISTINCT(osztaly)
	FROM tanulok
    WHERE osztaly != "2A"

/*ez a helyes megoldás a != helyet*/
SELECT DISTINCT(osztaly)
	FROM tanulok
    WHERE osztaly <> "2A"

F. feladat
SELECT DISTINCT(osztaly)
	FROM tanulok
    WHERE osztaly NOT IN("2A", "3A", "5B")

/*másik*/
SELECT DISTINCT(osztaly)
	FROM tanulok
    WHERE osztaly NOT LIKE("2A") && osztaly NOT LIKE("3A") && osztaly NOT LIKE("5B")