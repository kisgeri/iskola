<style>
body{
	background: grey;
}
</style>
<h1>Regisztráció</h1>

<form method="POST">
    <label>Felhasználónév</label>
    <input type="text" name="username" max="25" placeholder="Felhasználónév">
    <br>
    <label>Email</label>
    <input type="email" name="email" max="255" placeholder="email">
    <br>
    <label>Jelszó</label>
    <input type="password" name="pass1" placeholder="Jelszó">
    <br>
    <label>Jelszó mégegyszer</label>
    <input type="password" name="pass2" placeholder="Jelszó mégegyszer">
    <br>
    <input type="submit" name="register" value="Regisztráció">
    
    <?php
        if($_POST["register"]){
            register($_POST);
        }
    ?>
    <p> <a href="login">vissza a bejelentkezésre</a></p>
</form>