-- A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!

-- 10. feladat:
CREATE DATABASE kgj_tisza
	DEFAULT CHARACTER SET utf8
    DEFAULT COLLATE utf8_hungarian_ci;


-- 12. feladat:
DELETE FROM meres
	WHERE nap = '2020-03-27'


-- 13. feladat:
UPDATE vizmerce
	SET igId = 2
	WHERE varos = 'Tokaj'


-- 14. feladat:
SELECT varos, nullPont
FROM vizmerce
	ORDER BY nullPont
    LIMIT 1


-- 15. feladat:
SELECT varos, (lnv-lkv) AS ingadozas
FROM vizmerce
ORDER BY ingadozas DESC

 
-- 16. feladat:
SELECT nev, COUNT(*) AS merceszam
	FROM igazgatosag INNER JOIN vizmerce ON igazgatosag.id=igId
    GROUP BY igId;
    

  
-- 17. feladat:
SELECT AVG(vizAllas) AS atlag
FROM vizmerce INNER JOIN meres ON vizmerce.id=vmId
WHERE varos = 'Szolnok' AND nap LIKE '%-04-%'

    

