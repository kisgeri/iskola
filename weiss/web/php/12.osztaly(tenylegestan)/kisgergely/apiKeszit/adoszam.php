<?php
header('Content-Type: application/json; charset=utf-8');

    if( !isset( $_GET['adoszam'] ) )
    {
	$tomb = array( 'hiba' => "hiányos adatok" ,  'uzenet' => "megadandó paraméterek: adoszam" ) ;
    }
    else
    {
        $adoszam = $_GET['adoszam'];
        $kezdetidatum ='1867-01-01';
        $adat = intval($adoszam[1].$adoszam[2].$adoszam[3].$adoszam[4].$adoszam[5]);
    

    $tomb = array(   'jel       '=> $adoszam,
                     'szul_datum'=> date('Y-m-d', strtotime($kezdetidatum."+{$adat}days")),
                     
	             ) ;
    }
$json = json_encode( $tomb , JSON_UNESCAPED_UNICODE ) ;

print $json ;
    
?>