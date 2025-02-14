<hr>
<h2>1. Random kutyaképek:</h2>
	<form method="post">
		<div id='kutyak'>
				<a href='./?p=api&k=vizsla'>vizsla</a>
				<a href='./?p=api&k=shiba'>shiba</a>
				<a href='./?p=api&k=pug'>pug</a>
				<a href='./?p=api&k=husky'>husky</a>
				<a href='./?p=api&k=chow'>chow</a>


				<!-- b opció
				<input type="submit" name="shiba" value="shiba" />
				<input type="submit" name="pug" value="pug" />
				<input type="submit" name="husky" value="husky" />
				<input type="submit" name="chow" value="chow" />-->
		</div>
	</form>

    <?php
		if(isset($_GET['k']))
		{
			$k=$_GET['k'];
		}
		else $k="";

		/* b opció
		if (isset($_POST['shiba'])) {
			$faj = 'shiba'; 
		  }
		else if (isset($_POST['vizsla'])) {
			$faj = 'vizsla'; 
		  }
		else if (isset($_POST['pug'])) {
			$faj = 'pug'; 
		  }
		else if (isset($_POST['husky'])) {
			$faj = 'husky'; 
		  }
		else if (isset($_POST['chow'])) {
			$faj = 'chow'; 
		  }*/
		$fk = @fopen( "https://dog.ceo/api/breed/".$k."/images/random" , "r" ) ;
		if($fk)
		{
			$json = fread( $fk , 8192 ) ;
			fclose( $fk ) ;

			$adat = json_decode( $json ) ;

			print " <img height='200px' src='$adat->message' title='$adat->message' align=right>";
		}
		else
		{
			print "A dog.ceo API-ja jelenleg nem működik." ;
		}
	?>