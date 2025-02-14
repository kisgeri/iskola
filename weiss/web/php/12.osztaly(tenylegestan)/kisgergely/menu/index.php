<?php session_start(); ?>
<!DOCTYPE html>
<html>
    <head>
        <title>
        <?php
                if(isset($_GET['p']))
                {
                    $p=$_GET['p'];
                }
                else
                {
                    $p="";
                }

                if($p == "")
                {
                   print "minőség kedvező áron";
                }else
                if($p == "kapcs")
                {
                    print "kapcsolataink";
                }else
                if($p == "eler")
                {
                    print "elerheteőseg";
                }else
                if($p == "szavazás")
                {
                    print "szavaz";
                }else
                if($p == "vendegkonyv")
                {
                    print "vendékkönyv";
                }else
                if($p == "api")
                {
                    print "api tan";
                }else
                {
                    print "404 - ERROR";
                }

                print " kütyübolt.hu"
                
            ?>
        </title>

        <style>
            body
            {
                margin: 0;
                font-size: 1.2em;
            }

            div#menu
            {
                text-align: center;
                background-color: grey;
                
            }

            div#tartalom
            {
                padding: 5px 48px;
                min-height:500px;
                
            }

            div#lablec
            {
                background-color: grey;
                min-height: 91px
            }

            div#menu a
            {
                
                padding: 5px;
                color:white;
                text-decoration:none;
                display: inline-block;
                width: 120px;
            }

            div#menu a:hover
            {
                
                background-color: white;
                color: grey;
            }

           
        </style>
    </head>
    <body>
        <div id='menu'>
            <a href='./'>Kezdőlap</a>
            <a href='./?p=kapcs'>Kapcsolat</a>
            <a href='./?p=eler'>Elérhetőség</a>
            <a href='./?p=szavazás'>szavazás</a>
            <a href='./?p=vendegkonyv'>vendégkönyv</a>
            <a href='./?p=api'>api gyak</a>
        </div>

        <div id='tartalom'>
            <?php
                if(isset($_GET['p']))
                {
                    $p=$_GET['p'];
                }
                else
                {
                    $p="";
                }

                if($p == "")
                {
                    print "<H1>AKCIÓ!!!!!!!!!!!!!!</h1>";
                    print "<H3>(ez egy tanuló oldal.)</h3>";
                }
                elseif($p == "kapcs")
                {
                    print "<H1>kapcsolatok</h1>";
                }
                elseif($p == "eler")
                {
                    print "<H1>ez most az</h1>";
                }
                elseif($p == "szavazás")
                {
                    print "<H1> SZAVAZ MOST !!! </H1>";
                    include ("szavazas.php");
                }
                elseif($p == "vendegkonyv")
                {
                    print "<H1>vendégkönyv:</h1>";
                    include ("vendegkonyv.php");
                }
                elseif($p == "api")
                {
                    print "<H1>api tanulás:</h1>";
                    include ("apitan.php");
                }
                else
                {
                    include ("404.php");
                }


                
            ?>

        </div>
        <div id='lablec'>
                <?php
                    
                    print"
                    <iframe src='' frameborder='0' width='500px' name='kisablak'>

                    </iframe>
                    <br><br>
                    ";
                    
                    $fajlnev = date("ymd").".txt";
                    if (!file_exists($fajlnev))
                    {
                        $fp = fopen($fajlnev,"w");
                        fwrite($fp, "0");
                        fclose($fp);
                        
                    }

                    $fp = fopen($fajlnev,"r");
                    $n=fread($fp, filesize($fajlnev));
                    fclose($fp);

                    if( !isset($_SESSION['izom']))
                    {
                        $n++;

                        $fp = fopen($fajlnev,"w");
                        fwrite($fp, $n);
                        fclose($fp);

                        $_SESSION['izom'] = "évvége";
                    }
                    

                    print"<span style='float:right'> latogató szám: $n</span>";
                         
                    $napok = array("","hétfő","kedd","szerda","csütörtök","péntek","szombat","vasárnap");
                    $honapok = array("","január","február","március","április","május","junius","julius","augusztus","szeptember","október","november","december");

                    print(date("Y.m.d"));
                    print "<br>";
                    print $honapok[date("n")]." ". date("d") ." ".$napok[date("w")];
                    print"<br>";
                    print"névnap: ";
                    print nevnapos(date("Y"), date("n"), date("j"));
                    print"<br>";
                    $szul = mktime(0, 0, 0, 07, 13, 2006);
                    $eltnapok  = (int)((time() - $szul) / (24*60*60));
                    print "$eltnapok. napja születtem"." ". $napok[date("N", $szul)];
                    

                    function nevnapos($ev,$ho,$nap)
                    {

                    $napok = Array(13);

                        $napok[1] = Array("", "Fruzsina","Ábel","Genovéva és Benjámin","Titusz és Leona",  
                                                "Simon","Boldizsár","Attila és Ramóna","Gyöngyvér","Marcell",  
                                                "Melánia","Ágota","Ernő","Veronika","Bódog","Lóránt és Loránd",  
                                                "Gusztáv","Antal és Antónia","Piroska","Sára, Márió","Fábián és Sebestyén",  
                                                "Ágnes","Vince és Artúr","Zelma és Rajmund","Timót","Pál","Vanda és Paula",  
                                                "Angelika","Károly és Karola","Adél","Martina és Gerda","Marcella");

                    if ($ev % 4 != 0)
                        $napok[2] = Array("", "Ignác","Karolina és Aida","Balázs","Ráhel és Csenge","Ágota és Ingrid",  
                                                "Dorottya és Dóra","Tódor és Rómeó","Aranka","Abigél és Alex","Elvira",  
                                                "Bertold és Marietta","Lívia és Lídia","Ella és Linda","Bálint és Valentin",  
                                                "Kolos és Georgina","Julianna és Lilla","Donát és Vilté","Bernadett","Zsuzsanna",  
                                                "Aladár és Álmos","Eleonóra","Gerzson","Alfréd",  
                                                "Mátyás","Géza","Edina","Ákos és Bátor","Elemér","","","");
                    else  
                        $napok[2] = Array("", "Ignác","Karolina és Aida","Balázs","Ráhel és Csenge","Ágota és Ingrid",  
                                                "Dorottya és Dóra","Tódor és Rómeó","Aranka","Abigél, Alex","Elvira",  
                                                "Bertold és Marietta","Lívia és Lídia","Ella és Linda","Bálint és Valentin",  
                                                "Kolos és Georgina","Julianna és Lilla","Donát","Bernadett","Zsuzsanna",  
                                                "Aladár és Álmos","Eleonóra","Gerzson","Alfréd",  
                                                "Szökőnap","Mátyás","Géza","Edina","Ákos és Bátor","Elemér","","");

                        $napok[3] = Array("", "Albin","Lujza","Kornélia","Kázmér","Adorján és Adrián","Leonóra és Inez",  
                                                "Tamás","Zoltán","Franciska és Fanni","Ildikó","Szilárd",  
                                                "Gergely","Krisztián és Ajtony","Matild","Kristóf",  
                                                "Henrietta","Gertrúd és Patrik","Sándor és Ede","József és Bánk","Klaudia",  
                                                "Benedek","Beáta és Izolda","Emőke","Gábor és Karina","Irén és Irisz",  
                                                "Emánuel","Hajnalka","Gedeon és Johanna","Auguszta","Zalán","Árpád");  

                        $napok[4] = Array("", "Hugó","Áron","Buda, Richárd","Izidor","Vince","Vilmos és Bíborka",  
                                                "Herman","Dénes","Erhard","Zsolt","Leó és Szaniszló","Gyula","Ida",  
                                                "Tibor","Anasztázia és Tas","Csongor","Rudolf","Andrea és Ilma","Emma",  
                                                "Tivadar","Konrád","Csilla és Noémi","Béla","György","Márk","Ervin",  
                                                "Zita","Valéria","Péter","Katalin és Kitti","" );

                        $napok[5] = Array("", "Fülöp és Jakab","Zsigmond","Tímea és Irma","Mónika és Flórián",  
                                                "Györgyi","Ivett és Frida","Gizella","Mihály","Gergely","Ármin és Pálma",  
                                                "Ferenc","Pongrác","Szervác és Imola","Bonifác","Zsófia és Szonja",  
                                                "Mózes és Botond","Paszkál","Erik és Alexandra","Ivó és Milán",  
                                                "Bernát és Felícia","Konstantin","Júlia és Rita","Dezső","Eszter és Eliza",  
                                                "Orbán","Fülöp és Evelin","Hella","Emil és Csanád","Magdolna",  
                                                "Janka és Zsanett","Angéla és Petronella" );

                        $napok[6] = Array("", "Tünde","Kármen, Anita","Klotild","Bulcsú","Fatime","Norbert és Cintia",  
                                                "Róbert","Medárd","Félix","Margit és Gréta","Barnabás","Villő",  
                                                "Antal és Anett","Vazul","Jolán és Vid","Jusztin","Laura és Alida",  
                                                "Arnold és Levente","Gyárfás","Rafael","Alajos és Leila","Paulina",  
                                                "Zoltán","Iván","Vilmos","János és Pál","László","Levente és Irén",  
                                                "Péter és Pál","Pál","" );

                        $napok[7] = Array("", "Tihamér, Annamária","Ottó","Kornél és Soma","Ulrik","Emese és Sarolta",  
                                                "Csaba","Appolónia","Ellák","Lukrécia","Amália","Nóra és Lili",  
                                                "Izabella és Dalma","Jenő","Őrs és Stella","Henrik és Roland","Valter",  
                                                "Endre és Elek","Frigyes","Emília","Illés","Dániel és Daniella",  
                                                "Magdolna","Lenke","Kinga és Kincső","Kristóf és Jakab","Anna és Anikó",  
                                                "Olga és Liliána","Szabolcs","Márta és Flóra","Judit és Xénia","Oszkár" );

                        $napok[8] = Array("", "Boglárka","Lehel","Hermina","Domonkos és Dominika","Krisztina",  
                                                "Berta és Bettina","Ibolya","László","Emőd","Lőrinc",  
                                                "Zsuzsanna és Tiborc","Klára","Ipoly","Marcell","Mária","Ábrahám",  
                                                "Jácint","Ilona","Huba","István","Sámuel és Hajna",  
                                                "Menyhért és Mirjam","Bence","Bertalan","Lajos és Patrícia","Izsó",  
                                                "Gáspár","Ágoston","Beatrix és Erna","Rózsa","Erika és Bella" );

                        $napok[9] = Array("", "Egyed és Egon","Rebeka és Dorina","Hilda","Rozália","Viktor és Lőrinc",  
                                                "Zakariás","Regina","Mária és Adrienn","Ádám","Nikolett és Hunor",  
                                                "Teodóra","Mária","Kornél","Szeréna és Roxána","Enikő és Melitta","Edit",  
                                                "Zsófia","Diána","Vilhelmina","Friderika","Máté és Mirella","Móric",  
                                                "Tekla","Gellért és Mercédesz","Eufrozina és Kende","Jusztina","Adalbert",  
                                                "Vencel","Mihály","Jeromos","" );

                        $napok[10]= Array("", "Malvin","Petra","Helga","Ferenc","Aurél","Brúnó és Renáta","Amália",  
                                                "Koppány","Dénes","Gedeon","Brigitta","Miksa","Kálmán és Ede","Helén",  
                                                "Teréz","Gál","Hedvig","Lukács","Nándor","Vendel","Orsolya","Előd",  
                                                "Gyöngyi","Salamon","Blanka és Bianka","Dömötör",
                                                "Szabina","Simon és Szimonetta","Nárcisz","Alfonz","Farkas" );

                        $napok[11]= Array("", "Marianna","Achilles","Győző","Károly","Imre","Lénárd","Rezső",  
                                                "Zsombor","Tivadar","Réka","Márton","Jónás és Renátó","Szilvia",  
                                                "Aliz","Albert és Lipót","Ödön","Hortenzia és Gergő","Jenő","Erzsébet",  
                                                "Jolán","Olivér","Cecília","Kelemen és Klementina","Emma","Katalin",  
                                                "Virág","Virgil","Stefánia","Taksony","András és Andor","" );

                        $napok[12]= Array("", "Elza","Melinda és Vivien","Ferenc és Olívia","Borbála és Barbara","Vilma",  
                                                "Miklós","Ambrus","Mária","Natália","Judit","Árpád","Gabriella",  
                                                "Luca és Otília","Szilárda","Valér","Etelka és Aletta","Lázár és Olimpia",  
                                                "Auguszta","Viola","Teofil","Tamás","Zéno","Viktória","Ádám és Éva",  
                                                "Eugénia","István","János","Kamilla",  
                                                "Tamás és Tamara","Dávid","Szilveszter" );

                    return $napok[$ho][$nap];  

                    }  

                ?>
        </div>

    </body>
</html>