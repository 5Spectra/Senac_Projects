<?php

	$host = "localhost" ;
	$server_user = "root";
	$server_password = "";
	$db_base = "unity";
	
	$player = $_REQUEST ['nomeJogador'];
	$moedas = $_REQUEST ['numMoedas'];
	
	$conn = new mysqli($host, $server_user, $server_password, $db_base);
	
	if (!$conn) {
    die("Connection failed: " . mysqli_connect_error());}
	
	$sql = "UPDATE jogo_plataforma SET moedas = '".$moedas."' WHERE nome = '".$player."'";

	$result = mysqli_query($conn, $sql);
	
?>