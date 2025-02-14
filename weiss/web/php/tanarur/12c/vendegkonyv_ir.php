<?php

    print_r( $_POST ) ;

    print "<hr>" ;

    print_r( $_FILES ) ;

    if( $_POST['nev']=="" )  die("<script>  alert('Baj van!') </script>") ;
    if( mb_strlen($_POST['uzenet'])<10 )  die("<script>  alert('Legalább 10 karaktert írj...') </script>") ;

    $fajlnev = "vendegkonyv.txt" ;
    if( !file_exists($fajlnev) )
    {
	$fp = fopen( $fajlnev , "w" ) ;
	fclose( $fp ) ;
    }

    $kep = $_FILES['kep'] ;

    $uzenet = str_replace( "<", "&lt; " , $_POST ) ;

//  $uzenet = str_replace( "\r\n", "<br>" , $_POST['uzenet'] ) ;  //  <- Ez így nem jó, mert ignorálja az előző sort! Ez volt a baj az órán :P
    $uzenet = str_replace( "\r\n", "<br>" , $uzenet          ) ;  //  <- Ez a helyes változat


    $uzenet = str_replace( ";"   , ","    , $uzenet          ) ;

    $ujfajlnev = "";   /// ???????????? ;

    $sz = date("Y-m-d H:i:s") . ";" . $_POST['nev'] . ";" . $uzenet . ";" . $ujfajlnev . "\r\n" ;

    $fp = fopen( $fajlnev , "a" ) ;
    fwrite( $fp , $sz ) ;
    fclose( $fp ) ;

   print "<script>  alert('Köszönjük véleményedet') </script>" ;

?>