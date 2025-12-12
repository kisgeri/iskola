A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!

1. feladat:
CREATE DATABASE kg_ostermelo
DEFAULT CHARACTER SET utf8
DEFAULT COLLATE utf8_hungarian_ci

3. feladat:
SELECT DISTINCT(telepules)
	FROM partnerek
    ORDER BY telepules

4. feladat:
SELECT COUNT(*) AS alkalmak
	FROM partnerek INNER JOIN kiszallitasok ON id=partnerid
    WHERE telepules = "Vác"

5. feladat:
SELECT karton
	FROM kiszallitasok
    WHERE datum LIKE("2016-05%")
    ORDER BY karton DESC
    LIMIT 1
    /*nem teljes*/

    /*ez a jó ha minden szállítás 1 megrendelés*/
    SELECT partnerid,datum, SUM(karton) AS legtobb
	FROM kiszallitasok
    WHERE datum LIKE("2016-05%")
    GROUP by partnerid
    ORDER BY legtobb DESC
    LIMIT 1

6. feladat:
SELECT telepules
	FROM partnerek
    GROUP BY telepules
    HAVING COUNT(*) > 1
    ORDER BY telepules

7. feladat:
SELECT gynev AS ital, SUM(karton*6) AS doboz
    FROM kiszallitasok INNER JOIN gyumolcslevek ON gyumleid=id
    GROUP BY ital
    ORDER by doboz DESC

/*kiegeszito*/

A:
SELECT SUM(karton*6) AS "legtobb kiszalitott doboz"
    FROM kiszallitasok
    GROUP BY sorsz
    ORDER by SUM(karton*6) DESC
    LIMIT 1

B:
SELECT gynev, COUNT(*) AS "kiszállítások"
    FROM kiszallitasok INNER JOIN gyumolcslevek ON gyumleid=id
    GROUP BY gynev
    ORDER by COUNT(*) DESC

C:
SELECT gynev, SUM(karton) AS "kiszállítások mennyiség"
    FROM kiszallitasok INNER JOIN gyumolcslevek ON gyumleid=id
    GROUP BY gynev
    ORDER by SUM(karton) DESC
    LIMIT 3

D:
SELECT gynev, SUM(karton) AS "kiszállítások mennyiség"
    FROM kiszallitasok INNER JOIN gyumolcslevek ON gyumleid=id
    GROUP BY gynev
    HAVING SUM(karton) > 1000
    ORDER by SUM(karton) DESC

E:
SELECT telepules,COUNT(*) AS "partnerek száma"
	FROM partnerek
    GROUP BY telepules
    ORDER BY COUNT(*) DESC
    