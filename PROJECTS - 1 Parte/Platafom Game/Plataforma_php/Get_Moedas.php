<?php

	$host = "localhost" ;
	$server_user = "root";
	$server_password = "";
	$db_base = "unity";
	
	$playerN = $_REQUEST['nomeJogador'];
	
	$conn = new mysqli($host, $server_user, $server_password, $db_base);
	
	if (!$conn) {
    die("Connection failed: " . mysqli_connect_error());}
	
	//Pega as moedas de um jogador especifico
	$sql = "SELECT moedas FROM jogo_plataforma WHERE nome = '".$playerN."'";

	$result = mysqli_query($conn, $sql);	
	
	if (mysqli_num_rows($result) > 0) 
    while($row = mysqli_fetch_assoc($result)) 
        echo $row["moedas"]; //. ".";
		
		
?>