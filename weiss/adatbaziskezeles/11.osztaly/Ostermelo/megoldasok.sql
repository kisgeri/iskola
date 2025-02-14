A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!

1. feladat:
    CREATE DATABASE ostermelo          			
	DEFAULT CHARACTER SET = utf8			
	DEFAULT COLLATE utf8_hungarian_ci;

3. feladat:
    SELECT DISTINCT telepules
	FROM partnerek
    	ORDER BY telepules;

4. feladat:
    SELECT COUNT(*) AS alkalmak
	FROM partnerek INNER JOIN kiszallitasok ON id=partnerid
    	WHERE telepules = "Vác";

5. feladat:
    SELECT karton as legtobb
    FROM kiszallitasok
    WHERE datum LIKE "2016-05%"
    ORDER BY legtobb DESC
    LIMIT 1
    ;

6. feladat:
    SELECT telepules, COUNT(*)
    FROM partnerek
    GROUP BY telepules
    HAVING COUNT(*) > 1;
    ;

7. feladat:
    SELECT gynev AS ital , SUM(karton*6) AS doboz
    FROM kiszallitasok INNER JOIN gyumolcslevek ON gyumleid=id
    GROUP BY ital
    ORDER BY doboz DESC
    LIMIT 3
    ;

