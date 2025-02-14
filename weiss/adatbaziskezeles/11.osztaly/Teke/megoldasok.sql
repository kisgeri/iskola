A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!


1. feladat: 2/2
CREATE DATABASE kgj_teke
 DEFAULT CHARACTER SET utf8
 DEFAULT COLLATE utf8_hungarian_ci;


3. feladat: 3/3
SELECT nev
	FROM versenyzok
    WHERE korcsop = "A"
    ORDER by nev;


4. feladat: 3/3
SELECT DISTINCT rajtszam
	FROM versenyzok INNER JOIN eredmenyek ON rajtszam=versenyzo
    WHERE ures > 0;
    



5. feladat: 3/3
SELECT nev, AVG(tarolas) AS atlagpont
FROM versenyzok INNER JOIN eredmenyek ON rajtszam=versenyzo
GROUP by nev
ORDER by atlagpont DESC;


6. feladat: 4/4
SELECT egyesuletek.nev
FROM egyesuletek INNER JOIN versenyzok ON id=egyid
GROUP BY egyid
ORDER by COUNT(egyid) DESC
LIMIT 1;


7. feladat: 2/5
hibás:
SELECT nev, SUM(teli+tarolas) AS eredmeny,SUM(tarolas),ures
FROM versenyzok INNER JOIN eredmenyek ON rajtszam=versenyzo
WHERE korcsop = "B"
GROUP by nev
ORDER BY eredmeny DESC, tarolas DESC, ures

jó:
SELECT nev, SUM(teli+tarolas) AS eredmeny,SUM(tarolas) AS tarolas,SUM(ures) AS ures
FROM versenyzok INNER JOIN eredmenyek ON rajtszam=versenyzo
WHERE korcsop = "B"
GROUP by nev
ORDER BY eredmeny DESC, tarolas DESC, ures

osz: 17/20