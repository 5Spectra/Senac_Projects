<?php

	$teste = $_POST['teste'];
	
	$host = "localhost" ;
	$user = "root";
	$password = "";
	$base = "unity";
	
	$conn = mysql_connect($host, $user, $password);
	$conn = mysql_select_db($base);
	
	$sql = "INSERT INTO teste";
	$sql .= "(frase) values('".$teste."')";
	
	$result = mysql_query ($sql);
	
	mysql_close();
?>