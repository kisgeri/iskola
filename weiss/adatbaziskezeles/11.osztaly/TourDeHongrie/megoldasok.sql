-- A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!

-- 9. feladat:
CREATE DATABASE kgj_tdhongrie
	DEFAULT CHARACTER SET utf8
    DEFAULT COLLATE utf8_hungarian_ci;


-- 11. feladat:
DELETE 
	FROM csapat
    WHERE id = 21;


-- 12. feladat:
SELECT nev
	FROM versenyzo
    WHERE nemzetiseg = 'HUN'
    ORDER BY nev;


-- 13. feladat:
SELECT nemzetiseg, COUNT(*) AS indulokSzama
	FROM versenyzo
    GROUP BY nemzetiseg
    ORDER BY indulokSzama DESC;


-- 14. feladat:
SELECT szakasz, ido
	FROM eredmeny INNER JOIN versenyzo ON versenyzoId=versenyzo.id
    WHERE nev = 'Valter Attila'
    ORDER BY szakasz;

 
-- 15. feladat:
SELECT csapatNev, COUNT(*) AS magyarokSzama
	FROM versenyzo INNER JOIN csapat ON csapatId=csapat.id
    WHERE nemzetiseg = 'HUN'
    GROUP BY csapatNev
    HAVING magyarokSzama > 1;
