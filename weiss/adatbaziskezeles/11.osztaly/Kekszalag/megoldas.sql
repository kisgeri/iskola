-- 8.feladat
CREATE DATABASE kgj_kekszalag
	DEFAULT CHARACTER SET utf8
    DEFAULT COLLATE utf8_hungarian_ci;


-- 10.feladat
DELETE
	FROM klubok
    WHERE klubNev = 'ZZZ';

-- 11.feladat
UPDATE klubok
    SET klubNev = 'ADMIRAL'
    WHERE klubok.id = 1;


-- 12.feladat
SELECT AVG(pontok) AS atlagPont
	FROM hajok;


-- 13.feladat
SELECT klubNev
	FROM klubok
    WHERE klubNev LIKE '___'
    ORDER BY klubNev DESC;


-- 14.feladat
SELECT kormanyosNev,hajoNev
	FROM hajok
    WHERE kormanyosNev LIKE '%István';


-- 15.feladat
SELECT COUNT(*) AS hajokSzama
	FROM hajok
    WHERE ido IS NULL;


-- 16.feladat
SELECT ido,osztalyNev,hajoNev
	FROM osztalyok INNER JOIN hajok ON osztalyok.id=hajoOszt
    WHERE ido IS NOT NULL
    ORDER BY ido
    LIMIT 15;

