<?php 
	
	session_start();

	
		error_reporting(E_ALL);
	
		ini_set('display_errors', '1');

	
		//$_POST['username'] = "se212020";
	
		//$_POST['password'] = "vqk6630";

	
		include_once("db-connection.php");
	
		//$db = connect_db();

	
		//if (isset($_POST)) {
		
	    
		//	$username = $_POST['username'];	
	    //
		//	$password = $_POST['password'];

	    
		//	$query = $db->prepare('SELECT p_word FROM users WHERE u_name = ?');
	   
		//	$data = array($username);
	    
		//	$query->execute($data);
	    
		//	$result = $query->fetch();

	    //
		//	var_dump($result);

	    //
		//	if ($password == $result[0]) {
	    	//
		//		echo "They're equal";
	    	//
				$_SESSION["loggedIn"] = true;
	    	
				$_SESSION["name"] = $username;
	    //}

	   
			var_dump($_SESSION);

	   
			 //$posts = $db->prepare('SELECT * FROM posts ORDER BY post_date DESC');

	
			//}







?>