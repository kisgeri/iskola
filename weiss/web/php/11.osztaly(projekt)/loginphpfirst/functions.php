<?php
    require_once("config.php");
    session_start();
    $connection = new Database;

    function register($post){
        if (!empty($post['username']) && !empty($post['pass1']) && !empty($post['pass2']) && !empty($post['email'])){
            global $connection;
            $stmt = $connection->pdo->prepare("SELECT * FROM accounts WHERE username = :username OR email = :email");
			$stmt->bindParam(":username", $post['username']);
			$stmt->bindParam(":email", $post['email']);
			$stmt->execute();
            $result = $stmt->rowCount();
            if ($result == 0){
                if ($post['pass1'] == $post['pass2']){
                    $stmt = $connection->pdo->prepare("INSERT INTO accounts(username, password, email) VALUES(:username,:password,:email)");
                    $stmt->bindParam(":username", $post['username']);
                    $stmt->bindParam(":password", md5($post['pass1']));
                    $stmt->bindParam(":email", $post['email']);
                    $stmt->execute();

                    echo "<br> Sikeres regisztráció!";
                }else{
                    echo "<br> A megadott jelszavak nem egyezik!";
                }
            }else{
                echo "<br> a felhasználónév vagy email már foglalt!";
            }
        }else{
            echo "<br> nincs minden mező kitöltve";
        }
    }

    function login($post){
        if(!empty($post["username"]) && !empty($post["pass"])){
            global $connection;
            $stmt = $connection->pdo->prepare("SELECT * FROM accounts WHERE username = :username AND password = :pass");
			$stmt->bindParam(":username", $post['username']);
			$stmt->bindParam(":pass", md5($post['pass']));
			$stmt->execute();
            $account_data = $stmt->fetch(PDO::FETCH_ASSOC);
            $result = $stmt->rowCount();
            if ($result == 1){
				$stmt = $connection->pdo->prepare("UPDATE accounts SET lastLogin=NOW() WHERE username=:username");
				$stmt->bindParam(":username", $post['username']);
				$stmt->execute();
                $_SESSION['USER:LOGGED'] = true;
                $_SESSION["USER:DATA"] = $account_data;
                echo "<br> Sikeres bejelentkezés!";
                header( "Location:main" );
            }else{
                echo"<br> Sikertelen bejelentkezés: Hibás adat";
            }
        }else{
            echo "<br> nincs minden mező kitöltve";
        }
    }

    function getAccountData($id){
        global $connection;
        $stmt = $connection->pdo->prepare("SELECT * FROM accounts WHERE id = :id");
		$stmt->bindParam(":id", $id);
		$stmt->execute();
        $account_data = $stmt->fetch(PDO::FETCH_ASSOC);
		return $account_data;
	}
	
	function getAllUser(){
		global $connection;
		$stmt = $connection->pdo->prepare("SELECT * FROM accounts");
		$stmt->execute();
		$data = $stmt->fetchAll(PDO::FETCH_ASSOC);
		foreach($data as $data_query){
			if ($data_query['status'] == 1){
				$status = "Felfüggesztett";
			}else{
				$status = "Használható";
			}
			
			if ($data_query['role'] == 1){
				$role = "VIP";
			}elseif ($data_query['role'] == 2){
				$role = "Admin";
			}else{
				$role = "Felhasználó";
			}

			echo "
				<tr>
					<td>{$data_query['id']}</td>
					<td>{$data_query['username']}</td>
					<td>{$data_query['email']}</td>
					<td>{$data_query['lastLogin']}</td>
					<td>{$status}</td>
					<td>{$role}</td>
				</tr>
			";
		}
	}
?>