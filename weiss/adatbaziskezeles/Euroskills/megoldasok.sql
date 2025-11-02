-- A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!


-- 1. feladat: 2pont
    CREATE DATABASE euroskills_kg
        DEFAULT CHARACTER SET utf8
        DEFAULT COLLATE utf8_hungarian_ci;
-- 3. feladat: 3pont
    SELECT COUNT(*) AS ermek
        FROM versenyzo
        WHERE pont >= 700;


-- 4. feladat: 3pont
    SELECT DISTINCT orszagNev
        FROM orszag INNER JOIN versenyzo ON orszag.id=versenyzo.orszagId
        ORDER by orszagNev;
    


-- 5. feladat:
    SELECT szakmaNev , COUNT(szakmaId) AS "versenyzok szama"
        FROM szakma INNER JOIN versenyzo ON szakma.id=versenyzo.szakmaId
        GROUP BY szakmaNev
        ORDER by COUNT(szakmaId) DESC;
    


-- 6. feladat:
    SELECT nev, orszagNev, szakmaNev, pont
        FROM szakma INNER JOIN versenyzo ON szakma.id=versenyzo.szakmaId
        INNER JOIN orszag ON orszag.id=versenyzo.orszagId
        ORDER BY pont DESC, nev
        LIMIT 25;
