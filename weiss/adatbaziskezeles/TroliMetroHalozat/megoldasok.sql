-- A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!


-- 10. feladat: 2pont
	CREATE DATABASE kg_halozat
		DEFAULT CHARACTER SET utf8
		DEFAULT COLLATE utf8_hungarian_ci;

-- 12. feladat: 1pont
	INSERT INTO megallok VALUES (198,"Kőbányai garázs") ;


-- 13. feladat: 1pont
	UPDATE jaratok SET elsoAjtos=False
 		WHERE id = 20;


-- 14. feladat: 2pont
	SELECT jaratSzam FROM jaratok
		WHERE elsoAjtos = True;


-- 15. feladat: 3pont
	SELECT nev FROM megallok
		WHERE nev LIKE "%sétány"
    		ORDER BY nev ASC;


-- 16. feladat: 5pont
SELECT sorszam, nev AS "megallo" 
FROM megallok INNER JOIN halozat ON megallok.id=halozat.megallo
INNER JOIN jaratok ON halozat.jarat=jaratok.id
	WHERE jaratok.jaratSzam = "CITY" AND halozat.irany="A"
    	ORDER BY halozat.sorszam ASC;


-- 17. feladat: 5pont

helyes megoldás:
SELECT nev AS "megallo", COUNT(jaratok.id) AS jaratokSzama 
	FROM megallok INNER JOIN halozat ON megallok.id=halozat.megallo
	INNER JOIN jaratok ON halozat.jarat=jaratok.id
    	GROUP BY nev
	HAVING COUNT(jaratok.id) > 2;

müködő:
SELECT nev AS "megallo", COUNT(*) AS jaratokSzama 
	FROM megallok INNER JOIN halozat ON megallok.id=halozat.megallo
    	GROUP BY nev
	HAVING COUNT(*) > 2;

+1 as-ok miatt

20pont


