-- A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!


-- 10. feladat:
CREATE DATABASE kgj_halozat
	DEFAULT CHARACTER SET utf8
    DEFAULT COLLATE utf8_hungarian_ci;


-- 12. feladat:
INSERT INTO megallok VALUES(198,'Kőbányai garázs');


-- 13. feladat:
UPDATE jaratok
	SET elsoAjtos = False
	WHERE id = 20
    


-- 14. feladat:
SELECT jaratSzam
	FROM jaratok
    WHERE elsoAjtos = True


-- 15. feladat:
SELECT nev
	FROM megallok
    WHERE nev LIKE '%sétány'
    ORDER BY nev


-- 16. feladat:
SELECT sorszam, nev AS megallo
	FROM megallok INNER JOIN halozat ON megallok.id=megallo INNER JOIN jaratok ON jarat=jaratok.id
    WHERE jaratSzam = 'CITY' AND irany = 'A'
    ORDER BY sorszam


-- 17. feladat:
SELECT nev AS megallo, COUNT(*) AS jaratokSzama
	FROM megallok INNER JOIN halozat ON megallok.id=megallo INNER JOIN jaratok ON jarat=jaratok.id
    GROUP BY megallo
    HAVING jaratokSzama >= 3
    --ORDER BY megallo



