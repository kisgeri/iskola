<?php

    print" 
        <form action='vendegkonyv_ir.php' method='post' target='kisablak' enctype='multipart/form-data'>
            ide írd a neved:<br>
            <input type='text' name='nev' placeholder='írd ide a neved:'><br><br>
            írd ide a véleményed:<br>
            <textarea cols='30' rows='10' name='szoveg'></textarea>
            <br>
            kep: <input type='file' name='kep'><br><br>
            <input type='checkbox'name='ember'> Nem vagyok robot<br><br>
            <input type='submit' value='beküldés'>
        </form>
        <hr>
        ";
    $fajlnev = "vendegkonyv.txt";
    if( file_exists($fajlnev))
    {
        $fp = fopen($fajlnev, "r");

        
        $s = 0;
        $kiiras = "" ;
        while($sor = fgets($fp) )
        {
            $adat = explode(";",$sor);
            $s++;
            $kiiras ="<div style='border:solid 1px black; margin:12px;'>
            <span style='float:right'>$adat[0]</span>
            <b>$s.</b> <small>$adat[1]</small>
            <hr>
            $adat[2]
            </div>". $kiiras ;
        }
        
        print $kiiras ;
        fclose($fp);


    }


?>