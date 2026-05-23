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

			print " <img height='200px' src='$adat->message' title='$adat->message' align=center>";
		}
		else
		{
			print "A dog.ceo API-ja jelenleg nem működik." ;
		}
	?>
<h2>2. Random user:</h2>

<button onClick="window.location.reload();">Refresh Page</button>

	<?php
		$fu   = fopen( "https://randomuser.me/api/" , "r" ) ;
		$json = fread( $fu , 8192 ) ;
		fclose( $fu ) ;

		$adat = json_decode( $json ) ;

		$kep = $adat->results[0]->picture->medium;
	?>

<form method="post">
		
		<div style=' margin: 88px 30% 18px 88px; font-family: Courier; color:#226; background-color:#ADD8E6; padding: 25px 50px 25px 100px; border: solid; #226; '>
		
		<pre><?php
			$name =	$adat->results[0]->name->first." ".$adat->results[0]->name->last;
			$gender = $adat->results[0]->gender;
			$bdate = $adat->results[0]->dob->date;
			$country = $adat->results[0]->location->country;
			$city = $adat->results[0]->location->city;
			$email = $adat->results[0]->email;
			$phoneNum = $adat->results[0]->cell;
			$username = $adat->results[0]->login->username;
			$password = $adat->results[0]->login->password;
			$profilePicture = " <img height='100px' style='border: solid #226;' src='$kep' title='$kep' align=center><br>" ;
			print_r(
					"<h4> Full name:	<input type='text' name='nev' value='$name'>". 
					"<h4> Gender:   	<input type='text' name='gender' value='$gender' >".
					"<h4> Birth day:	<input type='text' name='bday' value='$bdate' >".
					"<h4> Location: 	<input type='text' name='country' value='$country' > city: <input type='text' name='city' value='$city'>".
					"<h4> Email:	        <input type='text' name='email' value='$email' >".
					"<h4> Phone number:  <input type='text' name='phonenum' value='$phoneNum' >".
					"<h4> Username:  	<input type='text' name='username' value='$username' >".
					"<h4> Password:  	<input type='password' name='password' value='$password' >".
					"<h4> Profile picture:  	<input type='image' name='pfp' value='$profilePicture"
					) ?></pre>
			
		</div>
		
	</form>	

