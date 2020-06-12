<?php

	$host = "localhost" ;
	$server_user = "root";
	$server_password = "";
	$db_base = "unity";
	
	$playerName = $_REQUEST['playerNamePost'];
	$playerPassword = $_REQUEST['playerPasswordPost'];
	
	$conn = new mysqli($host, $server_user, $server_password, $db_base);

	if (!$conn){die("Connection failed: " . mysqli_connect_error());}
	
	$sql = "SELECT senha FROM jogo_plataforma WHERE nome = '".$playerName."'";
	$result = mysqli_query($conn, $sql);	
	
	if (mysqli_num_rows($result) > 0) {	
		$row = mysqli_fetch_assoc($result);
			
        if($row['senha'] == $playerPassword)
			echo 1;
		else echo -1;
		
	}else
	echo 0;
	
	// -1 senha errada | 0 = usuario errado | 1 = tudo certo |
?>