A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!


1. feladat: 2/2
CREATE DATABASE kgj_maratonvalto
DEFAULT CHARACTER SET utf8
DEFAULT COLLATE utf8_hungarian_ci;


3. feladat: 1/1
INSERT INTO eredmenyek
VALUES(1044,4,15765)


4. feladat: 3/3
SELECT fnev AS futo,szulev
FROM futok
WHERE ffi = 0
ORDER BY futo;


5. feladat: 2/4
/*rosz
SELECT fnev AS futo,2016-szulev AS kor
FROM futok
WHERE 2016-szulev > 42
ORDER BY szulev DESC,szulho DESC;*/

SELECT fnev AS futo,2016-szulev AS kor
FROM futok
WHERE 2016-szulev >= 42
ORDER BY kor DESC,szulho DESC;


6. feladat: 4/5
SELECT fnev AS futo,ido
FROM futok INNER JOIN eredmenyek ON fid=futo
WHERE ffi = 1 /*KIHAGYTAM*/
ORDER BY ido
LIMIT 10;


7. feladat: 3/5
SELECT csapat AS csapat, SUM(ido) AS csapatido /*kihagytam a sum-ot*/
FROM futok INNER JOIN eredmenyek ON fid=futo 
GROUP BY csapat
ORDER by csapatido;


15/20

