-- A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!


-- 1. feladat:2/2
CREATE DATABASE kgj_nagykonyv
DEFAULT CHARACTER SET utf8
DEFAULT COLLATE utf8_hungarian_ci

-- 3. feladat:2/2
SELECT DISTINCT nemzetiseg
FROM szerzo
WHERE nemzetiseg <> 'magyar'

-- 4. feladat:3/3
SELECT nev,2005-szulEv AS kor
FROM szerzo
WHERE halEv IS NULL

-- 5. feladat:6/6
SELECT nev, MIN(helyezes) AS legjobb
FROM szerzo INNER JOIN konyv ON szerzoId=szerzo.id
WHERE nemzetiseg = 'magyar'
GROUP BY nev
ORDER BY legjobb

-- 6. feladat:5/6
SELECT nev, COUNT(*) AS konyvek
FROM szerzo INNER JOIN konyv ON szerzoId=szerzo.id
GROUP BY nev
HAVING konyvek > 1 --EZ KI MARADT
ORDER BY konyvek DESC, nev

--+1 AS miatt hogy mindenhol volt

--19/20