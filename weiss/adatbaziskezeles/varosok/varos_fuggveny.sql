A:
SELECT mnev, SUM(nepesseg) as Fő, AVG(nepesseg) as Átlag
FROM varos INNER JOIN megye ON megyeid = megye.id
WHERE mnev <> "Budapest"
GROUP BY mnev
HAVING Átlag > 20000
ORDER BY Átlag DESC

B:
SELECT mnev, ROUND(AVG(nepesseg),0) as Átlag
FROM varos INNER JOIN megye ON megyeid = megye.id
WHERE mnev <> "Budapest"
GROUP BY mnev
ORDER BY Átlag

C:
SELECT mnev, CONCAT(ROUND(AVG(nepesseg),0),' fő') as Átlag
FROM varos INNER JOIN megye ON megyeid = megye.id
WHERE mnev <> "Budapest"
GROUP BY mnev
ORDER BY Átlag

D:
SELECT mnev, COUNT(*) as tELEPÜLÉSSZÁM
FROM varos INNER JOIN megye ON megyeid = megye.id
WHERE mnev <> "Budapest" && CHAR_LENGTH(mnev) = 5
GROUP BY mnev
ORDER BY COUNT(*) DESC

E:
SELECT mnev, CONCAT('~',ROUND(SUM(terulet),-2),' km2') as Terület
FROM varos INNER JOIN megye ON megyeid = megye.id
WHERE mnev <> "Budapest"
GROUP BY mnev
ORDER BY SUM(terulet) DESC
LIMIT 3

F:
SELECT CONCAT(CHAR_LENGTH(vnev), 'kar.') as Névhossz, COUNT(*) as Városszám
FROM varos INNER JOIN megye ON megyeid = megye.id
WHERE CHAR_LENGTH(vnev) > 9
GROUP BY Névhossz
HAVING COUNT(*) > 20

G:
SELECT LEFT(vnev,1) as Kezdőbetü, COUNT(*) as DB
FROM varos INNER JOIN megye ON megyeid = megye.id
WHERE vnev <> "Budapest"
GROUP BY Kezdőbetü
ORDER BY Kezdőbetü
