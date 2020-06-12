<?php

	$host = "localhost" ;
	$user = "root";
	$password = "";
	$base = "unity";
		
	$userName = $_REQUEST['userName'];
	$userPassword = $_REQUEST['userPassword'];
	
	$conn = mysql_connect($host, $user, $password);
	$conn = mysql_select_db($base);
	
	$sql = "SELECT password FROM login";
	$sql .= " WHERE user = '".$userName."'";
	
	$result = mysql_query ($sql);
	
	mysql_close();
	
	$retorno = 0;

	if (mysql_num_rows($result) > 0){
		$row = mysql_fetch_array ($result);
		
			if ($row ['password'] == $userPassword){
				$retorno = 1;
			}
			echo $retorno;
		}
		
?>