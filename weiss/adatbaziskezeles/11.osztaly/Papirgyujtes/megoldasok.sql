A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!

1. feladat:2/2
	CREATE DATABASE kgj_papirgyujtes          			
	DEFAULT CHARACTER SET = uft8			
	DEFAULT COLLATE utf8_hungarian_ci;

3. feladat:2/2
	SELECT nev,osztaly,idopont,mennyiseg
	FROM tanulok INNER JOIN leadasok ON tazon=tanulo
        WHERE osztaly LIKE '1%';

4. feladat:3/3
	SELECT idopont,AVG(mennyiseg) AS 'napi atlag'
	FROM leadasok
        GROUP BY idopont;

5. feladat:3/4
	SELECT osztaly
	FROM tanulok INNER JOIN leadasok ON tazon=tanulo
        WHERE idopont = '2016-10-28'
        GROUP BY osztaly
		ORDER BY osztaly;

6. feladat:3/4
	SELECT osztaly,SUM(mennyiseg/10000) AS mazsa
	FROM tanulok INNER JOIN leadasok ON tazon=tanulo
        GROUP BY osztaly
        ORDER BY mazsa DESC;

7. feladat:4/5
    	SELECT nev,osztaly,SUM(mennyiseg) AS osszesen
    	FROM tanulok INNER JOIN leadasok ON tazon=tanulo
    	GROUP by nev
    	ORDER BY osszesen DESC
    	LIMIT 10;

17/20

kiegészítés:

a,
	SELECT nev,osztaly,SUM(mennyiseg/100) AS Kg
    	FROM tanulok INNER JOIN leadasok ON tazon=tanulo
    	GROUP by nev
    	ORDER BY Kg DESC
    	LIMIT 3;

b,

SELECT nev,COUNT(*) AS 'leadások száma'
    	FROM tanulok INNER JOIN leadasok ON tazon=tanulo
    	GROUP by nev
        HAVING COUNT(*) >= 6
    	ORDER BY COUNT(*) DESC,nev

c,

SELECT nev
    	FROM tanulok INNER JOIN leadasok ON tazon=tanulo
    	GROUP by nev
        HAVING COUNT(*) > 0
    	ORDER BY nev
        

d,

SELECT osztaly,SUM(mennyiseg) AS Eredmény
    FROM tanulok INNER JOIN leadasok ON tazon=tanulo
    GROUP by osztaly
    HAVING SUM(mennyiseg) > 120000
    ORDER BY Eredmény DESC
     

e,

SELECT idopont,SUM(mennyiseg) AS Eredmény
    FROM tanulok INNER JOIN leadasok ON tazon=tanulo
    GROUP by idopont
    ORDER BY Eredmény DESC
    LIMIT 5;