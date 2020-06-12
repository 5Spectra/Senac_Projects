<?php

	$host = "localhost" ;
	$user = "root";
	$password = "";
	$base = "unity";
	
	$conn = mysql_connect($host, $user, $password);
	$conn = mysql_select_db($base);
	
	$sql = "SELECT frase FROM teste";
	
	$result = mysql_query ($sql);
	
	mysql_close();
	
	if (mysql_num_rows($result) > 0){
		while ($row = mysql_fetch_assoc($result))
		echo "|" . $row ['frase'];
		
	}
?>