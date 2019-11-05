<?php 

	error_reporting(E_ALL);
	
	ini_set('display_errors', '1');

	
	include_once("db-connection.php");
	
	$db = connect_db();

	
	$var1 = "Woo";
	
	$var2 = "Sucess";

	
	echo "Whlksjfdl";

	
	$statement = "INSERT INTO  (col1, col2) VALUES (?, ?)";
   
	//$statement = "INSERT INTO comments (Comment, post_date, Name) VALUES (?, now(), ?)";

	
	echo $statement;
	
	$sth = $db->prepare($statement);
	
	$data = array($var1, $var2);
	
	$sth->execute($data);




?>