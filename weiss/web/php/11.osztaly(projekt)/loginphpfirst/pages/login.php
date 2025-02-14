<style>
body{
	background: grey;
}
</style>
<h1>Bejelentkezés</h1>

<form method="POST">
    <label>Felhasználónév</label>
    <input type="text" name="username" max="25" placeholder="Felhasználónév">
    <br>
    <label>Jelszó </label>
    <input type="password" name="pass" placeholder="Jelszó">
    <br>
    <input type="submit" name="login" value="Bejelentkezés">
    <p> <a href="register">Regisztráció!</a></p>
    <?php
        if($_POST["login"]){
            login($_POST);
            
        }
    ?>
</form>