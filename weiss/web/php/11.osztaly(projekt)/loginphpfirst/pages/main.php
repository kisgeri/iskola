<?php
    $account_data = getAccountData($_SESSION["USER:DATA"]["id"]);
?>
<style>
body{
	background: green;
}
</style>
<h1>ez egy teszt oldal kedves <?=$account_data['username'];?>!</h1>
<p> <a href="logout">kijelntkezés</a></p>

<?php
	if($account_data["role"] == 2){
?>
	<a href='admin'>admin oldal</a>
<?php
	}
?>
