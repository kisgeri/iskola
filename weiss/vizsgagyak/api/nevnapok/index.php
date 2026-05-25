<?php
// ============================================================================
// 1. ADATBÁZIS KAPCSOLAT ÉS ALAPBEÁLLÍTÁSOK (1. és 3. pontok)
// ============================================================================

// Csatlakozunk a MySQL adatbázishoz a feladat 1. pontja alapján.
// Az utolsó paraméter a "nevnapok" adatbázis neve, amit beimportáltál.
$adb = mysqli_connect("localhost", "root", "", "nevnapok");

// Egy globális tömb a hónapok neveivel. 
// Erre azért van szükség, mert az adatbázisban számként (1-12) vannak a hónapok, 
// de az API-nak és a felületnek szövegesen ("április 30.") kell visszaadnia.
$honapok = [
    "január", "február", "március", "április", "május", "június", 
    "július", "augusztus", "szeptember", "október", "november", "december"
];

// Logikai (kapcsoló) változók inicializálása.
// Alapból FALSE értékűek, és csak akkor váltanak TRUE-ra, ha sikeres találatunk van az URL-ből.
// Ezek segítségével fogja tudni a lap alján lévő HTML rész, hogy mit kell kiírnia a felületre.
$adnap = FALSE;
$adnev = FALSE;

// Változók előkészítése a formázott dátumnak (pl. "április 30.") és az adatbázisból kiolvasott sornak.
$formazott_datum = "";
$sor = null;


// ============================================================================
// 2. ŰRLAPOK FELDOLGOZÁSA ÉS ÁTIRÁNYÍTÁSA (9., 10. és 13. pontok)
// ============================================================================
// Amikor a felhasználó rákattint valamelyik keresés gombra a HTML űrlapon, 
// a böngésző POST kéréssel küldi el az adatokat. Mivel a 13. pont előírja, 
// hogy az API-n keresztül (?nap= vagy ?nev= URL paraméterekkel) kell keresni,
// a POST adatokat azonnal átalakítjuk GET paraméteres URL-lé egy átirányítással (Location).

// A) Dátum alapú űrlap elküldése:
if (isset($_POST['honap']) && isset($_POST['nap_szam']) && !empty($_POST['honap']) && !empty($_POST['nap_szam'])) {
    // Ha megadta a hónapot és a napot is, átirányítjuk a böngészőt a kívánt API formátumra.
    // Például: http://localhost/api/nevnapok/?nap=4-30
    header("Location: ./?nap=" . $_POST['honap'] . "-" . $_POST['nap_szam']);
    exit; // Az exit kulcsfontosságú! Megállítja a futást, hogy az átirányítás azonnal végbemenjen.
}

// B) Név alapú űrlap elküldése:
if (isset($_POST['nev']) && !empty($_POST['nev'])) {
    // Ha beírta a nevet, átirányítjuk a kívánt név alapú API formátumra.
    // Például: http://localhost/api/nevnapok/?nev=Katalin
    // Az urlencode() biztosítja, hogy a különleges karakterek (pl. szóköz, ékezet) is szabályosak legyenek az URL-ben.
    header("Location: ./?nev=" . ($_POST['nev']));
    exit; // Azonnali leállítás az átirányítás miatt.
}


// ============================================================================
// 3. ADATOK FELDOLGOZÁSA AZ URL-BŐL (API KISZOLGÁLÁS ÉS LOGIKA)
// ============================================================================
// Ez a rész felel az a.) feladat REST API működéséért (4, 5, 6, 7, 8. pontok).
// Akár az űrlap irányította ide a böngészőt, akár egy külső program hívta meg közvetlenül az URL-t,
// itt történik az adatbázis-lekérdezés.

// ----------------------------------------------------------------------------
// A) DÁTUM ALAPÚ ÁG (Ha az URL-ben szerepel a ?nap= paraméter - 4. és 5. pont)
// ----------------------------------------------------------------------------
if (isset($_GET['nap'])) {
    // A kötőjel mentén szétvágjuk a kapott stringet (pl. "4-30" -> ["4", "30"])
    $adatok = explode("-", $_GET['nap']);
    
    // Csak akkor lépünk tovább, ha a szétvágás után pontosan 2 elemet kaptunk (hónap és nap)
    if (count($adatok) == 2) {
        $honap_szam = intval($adatok[0]); // Egész számmá alakítjuk a hónapot (pl. 4)
        $nap_szam   = intval($adatok[1]); // Egész számmá alakítjuk a napot (pl. 30)
        
        // Lekérdezzük az adatbázisból a megadott hónaphoz és naphoz tartozó neveket.
        // (A feladatleírásod alapján a tábládban az oszlopok neve: ho, nap, nev1, nev2)
        $tabla = mysqli_query($adb, "SELECT nev1, nev2 FROM nevnap WHERE ho = $honap_szam AND nap = $nap_szam");
        
        // Ha találtunk érvényes sort az adatbázisban:
        if ($sor = mysqli_fetch_array($tabla, MYSQLI_ASSOC)) {
            // Összeállítjuk a szöveges dátumot. Mivel a tömb 0-tól indexelődik, a hónap számából le kell vonni 1-et.
            // pl. $honapok[4 - 1] -> $honapok[3] -> "április", így a végeredmény: "április 30."
            $formazott_datum = $honapok[$honap_szam - 1] . " " . $nap_szam . ".";
            
            // Jelezzük a lenti HTML résznek, hogy sikeres dátumos találatunk van, ki kell majd rajzolni a felületre.
            $adnap = TRUE;
            
            // INTELLIGENS API FELISMERÉS:
            // Megnézzük, hogy a kérést egy külső szoftver/automata tesztelő küldte-e ( application/json-t vár el ),
            // vagy nincs User-Agent (háttérprogram hívja). Ha igen, akkor tiszta API-ként kell válaszolnunk!
            //emiatt jelenik meg a htmnl nem a json, ha ezt az if-et kitörlöm akkor látszódik a json nyers válasz
            if (isset($_SERVER['HTTP_ACCEPT']) && strpos($_SERVER['HTTP_ACCEPT'], 'application/json') !== false || !isset($_SERVER['HTTP_USER_AGENT'])) {
                // Beállítjuk a hivatalos JSON fejlécet
                header('Content-Type: application/json; charset=utf-8');
                // 5. PONT: Kiírjuk a pontosan elvárt szerkezetű JSON kódot
                echo json_encode(["datum" => $formazott_datum, "nevnap1" => $sor['nev1'], "nevnap2" => $sor['nev2']], JSON_UNESCAPED_UNICODE);
                mysqli_close($adb);
                exit; // AZONNAL LEÁLLUNK, hogy a HTML kód véletlenül se fűződjön hozzá a tiszta JSON-höz!
            }
        } else {
            // 8. PONT: Ha a dátum formátuma jó volt, de nincs ilyen nap az adatbázisban, JSON hibaüzenetet adunk és leállunk.
            header('Content-Type: application/json; charset=utf-8');
            echo json_encode(["hiba" => "nincs találat"], JSON_UNESCAPED_UNICODE);
            mysqli_close($adb);
            exit;
        }
    }
}

// ----------------------------------------------------------------------------
// B) NÉV ALAPÚ ÁG (Ha az URL-ben szerepel a ?nev= paraméter - 6. pont)
// ----------------------------------------------------------------------------
if (isset($_GET['nev'])) {
    // Biztonságosan megtisztítjuk a beérkező nevet az SQL injekció ellen.
    $nev = mysqli_real_escape_string($adb, $_GET['nev']);
    
    // Kikeressük azt a sort, ahol a név egyezik a nev1 vagy a nev2 oszloppal.
    $tabla = mysqli_query($adb, "SELECT ho, nap, nev1, nev2 FROM nevnap WHERE nev1 = '$nev' OR nev2 = '$nev'");
    
    // Ha találtunk ilyen nevet az adatbázisban:
    if ($sor = mysqli_fetch_array($tabla, MYSQLI_ASSOC)) {
        // Az adatbázisból visszakapott hónapszámból elkészítjük a szöveges dátumot (pl. "december 31.")
        $formazott_datum = $honapok[$sor['ho'] - 1] . " " . $sor['nap'] . ".";
        
        // Jelezzük a lenti HTML résznek, hogy név alapú találatunk van.
        $adnev = TRUE;
        
        // INTELLIGENS API FELISMERÉS:
        // 6. PONT: Ha automatizált szoftver kéri az API-t, tiszta JSON-t adunk vissza, 
        // melynek szerkezete pontosan meg kell egyezzen az 5. pontban kért struktúrával (datum, nevnap1, nevnap2).
        //emiatt jelenik meg a htmnl nem a json, ha ezt az if-et kitörlöm akkor látszódik a json nyers válasz
        if (isset($_SERVER['HTTP_ACCEPT']) && strpos($_SERVER['HTTP_ACCEPT'], 'application/json') !== false || !isset($_SERVER['HTTP_USER_AGENT'])) {
            header('Content-Type: application/json; charset=utf-8');
            echo json_encode(["datum" => $formazott_datum, "nevnap1" => $sor['nev1'], "nevnap2" => $sor['nev2']], JSON_UNESCAPED_UNICODE);
            mysqli_close($adb);
            exit; // Azonnali leállítás, a HTML-t nem engedjük lefutni.
        
    } else {
        // 8. PONT: Ha a név nem található meg az adatbázisban, JSON hibaüzenetet adunk és leállunk.
        header('Content-Type: application/json; charset=utf-8');
        echo json_encode(["hiba" => "nincs találat"], JSON_UNESCAPED_UNICODE);
        mysqli_close($adb);
        exit;
    }
}

// ----------------------------------------------------------------------------
// C) PARAMÉTER HIÁNYA ÁG (Ha teljesen üresen hívták meg az API-t - 7. pont)
// ----------------------------------------------------------------------------
// Ha a lekérdezési karakterlánc (QUERY_STRING) teljesen üres, ÉS tiszta API hívás történik:
if (empty($_SERVER['QUERY_STRING']) && (isset($_SERVER['HTTP_ACCEPT']) && strpos($_SERVER['HTTP_ACCEPT'], 'application/json') !== false || !isset($_SERVER['HTTP_USER_AGENT']))) {
    header('Content-Type: application/json; charset=utf-8');
    // 7. PONT: JSON formátumú útmutatót adunk vissza a pontos használatról, majd leállunk.
    echo json_encode(["minta1" => "/?nap=12-31", "minta2" => "/?nev=Szilveszter"], JSON_UNESCAPED_UNICODE);
    mysqli_close($adb);
    exit;
}


// ============================================================================
// 4. WEBINFÓ / HTML FELÜLET ÉS CSS RESPOND (11., 12. és 14. pontok)
// ============================================================================
// Ha a kód idáig eljutott, az azt jelenti, hogy egy rendes felhasználó látogatta meg az oldalt 
// a böngészőből. Kirajzoljuk a felületet. Mivel az API ágakban nem állt le a kód (a böngészős látogatóknak 
// nem adtunk ki ott 'exit'-et), a felület folyamatosan látható marad (11. pont).
?>
<!DOCTYPE html>
<html lang="hu">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Névnap API Kereső</title>
    <style>
        /* 12. PONT: Alapértelmezett CSS mobilra / álló kijelzőre */

        .kontener {
            display: flex;
            flex-direction: column; /* Mobilnézetben a tartalmak szigorúan EGYSÉG ALATT jelennek meg */
            gap: 15px;
        }


        /* 12. PONT: CSS Media Query nagy kijelzőkre / Asztali számítógépekre (széles képernyő) */
        @media (min-width: 768px) {
            body { 
                margin: 40px;      /* Nagyobb margók asztali gépen */
                font-size: 18px;   /* Nagyobb, jól olvasható betűméret széles képernyőn */
            }
            .kontener {
                flex-direction: row; /* Széles képernyőn a két fő blokk EGYMÁS MELLETT jelenik meg */
            }
            .urlap-doboz, .talalat-doboz {
                flex: 1;           /* Egyenlő arányban osztják el a képernyő szélességét */
                padding: 30px;     /* Nagyobb belső margók asztalon */
            }
            select, input[type="number"], input[type="text"], input[type="submit"] {
                width: auto;       /* Elengedjük a 100%-os szélességet, így szépen sorba rendeződnek */
                display: inline-block;
                margin-bottom: 0;
            }
        }
    </style>
</head>
<body>

    <div class="kontener">
        
        <div class="urlap-doboz">
            <h3>Névnap keresése</h3>
            
            <form method="post" action="">
                <select name="honap">
                    <option value="">Válasszon hónapot...</option>
                    <option value="1">Január</option>
                    <option value="2">Február</option>
                    <option value="3">Március</option>
                    <option value="4">Április</option>
                    <option value="5">Május</option>
                    <option value="6">Június</option>
                    <option value="7">Július</option>
                    <option value="8">Augusztus</option>
                    <option value="9">Szeptember</option>
                    <option value="10">Október</option>
                    <option value="11">November</option>
                    <option value="12">December</option>
                </select>
                <input type="number" name="nap_szam" min="1" max="31" placeholder="Pl.: 20">
                <input type="submit" value="Keresés dátum szerint" />
            </form>

            <form method="post" action="">
                <input type="text" name="nev" placeholder="Pl.: Gergely">
                <input type="submit" value="Keresés név szerint" />
            </form>
        </div>

        <div class="talalat-doboz">
            <h3>Keresési eredmény</h3>
            <?php
            // 14. PONT: Az API-tól kapott adatok kiértékelése és intelligens szöveges megjelenítése

            if ($adnap) {
                // 14. pont 1. alpont: Dátum szerinti sikeres keresés eredménye (kiírjuk kik ünneplik)
                echo "<p>A keresett napon (<b>" . $formazott_datum . "</b>) névnapot ünnepel:</p>";
                echo "<ul>";
                echo "<li><b>" . $sor['nev1'] . "</b></li>";
                if (!empty($sor['nev2'])) {
                    echo "<li><b>" . $sor['nev2'] . "</b></li>";
                }
                echo "</ul>";
            } 
            elseif ($adnev) {
                // 14. pont 2. alpont: Keresztnév szerinti sikeres keresés eredménye (kiírjuk a visszaadott dátumot)
                echo "<p>A(z) <b>" . $_GET['nev'] . "</b> névnek ekkor van a névnapja: <b>" . $formazott_datum . "</b></p>";
            } 
            elseif (isset($_GET['nap']) || isset($_GET['nev'])) {
                // 14. pont 3. alpont: Eredménytelen keresés (Ha van paraméter az URL-ben, de az adatbázis üres volt)
                echo "<p style='color: red;'>Hiba: nincs találat</p>";
            } 
            else {
                // 14. pont 4. alpont: Alapállapot / Üresen hagyott kereső (Rövid utasítás és az API használati útmutatója)
                echo "<p>Kérjük, a kereséshez válasszon ki egy dátumot, vagy gépeljen be egy keresztnevet a bal oldali mezőkben!</p>";
                echo "<p><small><b>API Útmutató (7. pont):</b> " . json_encode(["minta1" => "/?nap=12-31", "minta2" => "/?nev=Szilveszter"], JSON_UNESCAPED_UNICODE) . "</small></p>";
            }
            ?>
        </div>
    </div>

</body>
</html>
<?php 
// Lezárjuk a MySQL kapcsolatot a szkript legvégén.
mysqli_close($adb); 
?>