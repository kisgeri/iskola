<?php
    $account_data = getAccountData($_SESSION["USER:DATA"]["id"]);
?>
<style>
body{
	background: black;
	color: white;
}
</style>
<h1>admin teszt oldal tisztelt <?=$account_data['username'];?>!</h1>
<p> <a href="main">főoldal</a></p>
<p> <a href="logout">kijelntkezés</a></p>

<?php
	if($account_data["role"] == 2){
?>
	<h3>Felhasználók</h3>
	<table border = 3>
		<tr>
			<td>#</td>
			<td>Felhasználónév</td>
			<td>Email</td>
			<td>Utolsó bejelentkezés</td>
			<td>Státusz</td>
			<td>Jogosultság</td>
		</tr>
		<?php getAllUser() ?>
	</table>
<?php
	}
	else{
?>
	<h2>maga nem admin felhasználó tisztelt <?=$account_data['username'];?>, ezért nem láthatja az oldal tartalmát kérem lépjen vissza a fő oldalra!</h1>
<?php
	}

?>
