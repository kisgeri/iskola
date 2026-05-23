<?php

    header('Content-Type: application/json; charset=utf-8');

    if( !isset( $_GET['ev'] ) )
    {
	$tomb = array( 'hiba' => "hiányos adatok" ,  'uzenet' => "megadandó paraméterek: ev" ) ;
    }
    else
    {
    $ev=$_GET['ev'];

    $a= $ev % 19;
    $b= $ev % 4;
    $c= $ev % 7;
    $d= (19*$a+24) % 30;
    $e= (2*$b+4*$c+6*$d+5) % 7;

    $h = 22+$d+$e;
    $np = $h - 2;
    $hh = $h + 1;
    $pv = $h + 49 - 31 -30; //május júmius
    $ph = $hh + 49 - 31 -30;
    if($h<=31)
    {
        $hvd= 'március '.$h;
        $npd = 'március '.$np;
        $hhd = 'március '.$hh;
        
    }
    else
    {
        $h = $h-31;
        $np=$np-31;
        $hh=$hh-31;
        $hvd= 'április '.$h;
        $npd = 'április '.$np;
        $hhd = 'április '.$hh;
    }

    if($pv<=31)
    {
       $pvd = 'május '.$pv; 
       $phd = 'május '.$ph;
        
        
    }
    else
    {
        $pv=$pv-31;
        $ph=$ph-31;
        $pvd = 'június '.$pv; 
        $phd = 'június '.$ph;
        
    }

    

	$tomb = array(   'ev                '=> $ev,
	                 'nagypentek        '=> $npd,
	                 'husvetvasarnap    '=> $hvd,
	                 'husvethetfo       '=> $hhd,
	                 'punkosdvasarnap   '=> $pvd,
	                 'punkosdhetfo      '=> $phd
	             ) ;

    }

    $json = json_encode( $tomb , JSON_UNESCAPED_UNICODE ) ;

    print $json ;

?>