<?php

	define('HOST', 'localhost' );	
	define('USER', 'root' );	
	define('PASSWORD', '' );	
	define('DB_NAME', 'unity' );
	
	class Player{
		private $user;
		
		public function setPlayer($p){
		$this -> player = $p;
		}
		
		public function getPlayer(){
		return $this -> player;
		}

		public function openConn(){
			
			try{
				$PDO = new PDO ('mysql:host='.HOST.';dbname='.DB_NAME, USER, PASSWORD);
				$PDO -> exec ("set names utf8");
				return $PDO;
			}
			catch (PDOException $e){
				echo $e->getMessage();
			}
		}
		
		public function deletePlayer(){
			$PDO = $this -> openConn();
			$sql = 'DELETE FROM login WHERE user = :user';
			
			$stmt = $PDO -> prepare($sql);
			$user = $this -> getPlayer();
			$stmt -> bindParam(':user',$user);
			
			$result = $stmt -> execute();
			$this -> closeConn();
			
			if(!$result){
				var_dump($stmt->errorInfo());
				exit;
			}
			else{
				echo "OK";
			}
		}
		
		public function closeConn(){
			$PDO = $this -> openConn();
			$PDO = null;
		}
	}
	
	$user = $_REQUEST['user'];
	$apaga = new player();
	$apaga -> setPlayer($user);
	$apaga -> deletePlayer();

?>