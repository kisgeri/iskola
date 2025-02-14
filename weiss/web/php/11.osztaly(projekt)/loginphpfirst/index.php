<?php
    error_reporting(E_ALL);
    ini_set('display_errors', '0');
    require_once("functions.php");
    if (isset($_GET["u"])) {
		$page = explode("/", htmlentities($_GET["u"]));
		$exp_page = $page[0];
        if (!file_exists("pages/" . $page[0] . ".php") && $page[0] != "logout" && !empty($page[0])) {
            $exp_page = "404";
        }

        if ($_SESSION["USER:LOGGED"] == FALSE){
            if ($page[0] == "login" || $page[0] == "register" || $page[0] == "elfelejtettjelszo"){
                //echo "Az bazdmeg";
            }else{
                $exp_page = "login";
            }
        }else{
            if ($page[0] == "login" || $page[0] == "register" || $page[0] == "elfelejtettjelszo"){
                $exp_page = "main";
            }
        }

        switch ($exp_page) {
            /// Alap oldalak ///elfelejtettjelszo
            case "":
                require_once("pages/main.php");
                break;
            case "main":
                require_once("pages/main.php");
                break;
            case "login":
                require_once("pages/login.php");
                break;
            case "register":
                require_once("pages/register.php");
                break;
			case "admin":
				require_once("pages/admin.php");
				break;
            case "logout":
                $_SESSION["USER:LOGGED"] = false;
                $_SESSION["USER:DATA"] = false;
                header( "Location:login" );
                break;
        }
    }
?>
