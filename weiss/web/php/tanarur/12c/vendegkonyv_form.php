<h1>Vendégkönyv</h1>

<form action='vendegkonyv_ir.php' method='post' target='kisablak' enctype='multipart/form-data'>

   Neved: <input name='nev'> <br><br>
   Üzenet:<br>
   <textarea name='uzenet' rows=8 cols=40></textarea> <br><br>

   Kép: <input type='file' name='kep'> <br><br>

   <input type='submit'>

</form>

<hr>

<?php

    $fajlnev = "vendegkonyv.txt" ;
    if( file_exists($fajlnev) )
    {
	$fp = fopen( $fajlnev , "r" ) ;

//	$sz = fread( $fp , filesize($fajlnev) ) ;
//	print $sz ;

	$s = 0 ;
	$kiiras = "" ;
	while( $sor = fgets( $fp ) )
	{ 
	    $adat = explode( ";" , $sor ) ;
	    $s++ ;
	    $kiiras = "
			<div style='border:solid 1px gray; margin:12px; '> 
				<span style='float:right'>$adat[0] </span>
				<b>$s.</b> <small>$adat[1]</small> 
				<hr>
				$adat[2] 
			</div>
	    " . $kiiras ;
	}

	print $kiiras ;

	fclose( $fp ) ;
    }

?>

