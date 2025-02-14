<?php 
    class Database {
        private $username   = "root";
        private $password   = "";
        private $host       = "localhost";
        private $dbname     = "kgj_login_test";
		
        public $pdo = null;

        public function __construct() {
            $this->pdo = new PDO("mysql:host={$this->host};dbname={$this->dbname}", $this->username, $this->password, array(PDO::MYSQL_ATTR_INIT_COMMAND => "SET NAMES utf8"));

            return $this->pdo;
        }

        public function get() {
            return (isset($this->pdo)) ? $this->pdo : false;
        }
    }
?>