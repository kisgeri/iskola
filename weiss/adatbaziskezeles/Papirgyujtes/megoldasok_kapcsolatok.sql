A:
SELECT nev
FROM tanulok LEFT JOIN leadasok ON tazon=tanulo
WHERE tanulo IS NULL

B:
SELECT COUNT(*) as "Inaktív tanulók"
FROM leadasok RIGHT JOIN tanulok ON tanulo=tazon
WHERE tanulo IS NULL

C:
SELECT DISTINCT nev
FROM tanulok INNER JOIN leadasok ON tazon=tanulo
WHERE tazon IS NOT NULL

D:mennyiseg
SELECT COUNT(DISTINCT nev) AS aktív
FROM tanulok INNER JOIN leadasok ON tazon=tanulo

E:
SELECT COUNT(DISTINCT nev) as "összlétszám"
FROM tanulok LEFT JOIN leadasok ON tazon=tanulo

SELECT COUNT(DISTINCT nev) as "összlétszám"
FROM leadasok RIGHT JOIN tanulok ON tanulo=tazon

nem jók:
(túl bonyolított)
SELECT COUNT(DISTINCT nev) + (
SELECT COUNT(*) as "Inaktív tanulók"
FROM leadasok RIGHT JOIN tanulok ON tanulo=tazon
WHERE tanulo IS NULL) AS összlétszám
FROM tanulok INNER JOIN leadasok ON tazon=tanulo

(nem a feladatnak megfelelő)
SELECT COUNT(*) as összlétszám
FROM tanulok

saját:


ki egészíti a D feladatott hogy a mennyiségett is ki írja
SELECT COUNT(DISTINCT nev) AS aktív, SUM(mennyiseg) AS "öszleadott papír"
FROM tanulok INNER JOIN leadasok ON tazon=tanulo

nem tom mi ez. ki adja az inaktívott meg aktívot egymás allat:
SELECT COUNT(DISTINCT nev) AS aktív
FROM tanulok INNER JOIN leadasok ON tazon=tanulo
UNION
SELECT COUNT(*) as "Inaktív tanulók"
FROM leadasok RIGHT JOIN tanulok ON tanulo=tazon
WHERE tanulo IS NULL