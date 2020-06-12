<?php

	$host = "localhost" ;
	$server_user = "root";
	$server_password = "";
	$db_base = "unity";
	
	$playerName = $_REQUEST['playerNameCreate'];
	$playerPassword = $_REQUEST['playerPasswordCreate'];
	
	//Basico
	$conn = new mysqli($host, $server_user, $server_password, $db_base);	
	if (!$conn) {
    die("Connection failed: " . mysqli_connect_error());}
	
	//Verifica se o nome já existe------------------------------
	$sql = "SELECT nome FROM jogo_plataforma"; //WHERE nome = '".$playerName."'";
	$result = mysqli_query($conn, $sql);
	
	if (mysqli_num_rows($result) > 0) 
		while($row = mysqli_fetch_assoc($result)) 
		if  ($playerName == $row['nome']){
			echo "Existe";
			exit();
		}
		
	//Cria Conta-------------------------------------------------
	$sql = "INSERT INTO jogo_plataforma (nome, senha, moedas) 
			VALUES ('".$playerName."','".$playerPassword."','0')";
	$result = mysqli_query($conn, $sql);	
	
	if ($result)
		echo "Good";
	else
		echo "Error";

?>