<?php
    session_start();

    print_r($_POST);
    print_r($_FILES);

    if(!isset($_POST['ember']))
    {
        die("<script> alert('Nem mentél át a robot elleni teszten. :(')</script>");
    }

    if($_POST['nev']=="")
    {
        die("<script> alert('név kell')</script>");
    }
    if(mb_strlen($_POST['szoveg'])<10)
    {
        die("<script> alert('legalább 10 karakter kell')</script>");
    }

    $fajlnev = "vendegkonyv.txt";

    $nev =$_POST['nev'];
    $datum = date("Y.m.d");

    $_POST = str_replace( "<", "&lt; " , $_POST ) ;
    $szoveg = str_replace("\r\n", "<br>", $_POST['szoveg']);
    $szoveg = str_replace(";", ",", $szoveg);


    if(!file_exists($fajlnev))
    {
        $fp = fopen($fajlnev,"w");
        //fwrite($fp, "($nev| $szoveg|$datum)¤");
        fclose($fp);
    }
    /*
    else{
        $fp = fopen($fajlnev,"a");
        fwrite($fp, "($nev| $szoveg|$datum)¤");
        fclose($fp);
    }*/

        
    $kep = $_FILES['kep'];

    $ujfajlnev = "";

    $sz = date("Y-m-d H:i:s") . ";" .$nev.";". $szoveg.";". $ujfajlnev."\n";

    $fp = fopen($fajlnev,"a");
        fwrite($fp, $sz);
        fclose($fp);

    print"<script> alert('kösz az üzenetett')</script>";
    



?>