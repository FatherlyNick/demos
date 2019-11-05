<?php 

	session_start();

	
	error_reporting(E_ALL);
	
	ini_set('display_errors', '1');

	
	include_once("db-connection.php");
	
	$db = connect_db();


	
	
	if (isset($_POST)) {
		
		var_dump($_POST);
		
		echo "Post is set";
		
		if (isset($_SESSION['loggedIn'])){

			
			$username = $_POST['Name'];
			
			$title = $_POST['title'];
			
			$content = $_POST['Comment'];

		    
			$statement = "INSERT INTO comments (Comment, post_date, Name) VALUES (?, now(), ?)";
		    					$sth = $db->prepare($statement);
		    
			$data = array($content, $username, $title);
		    
			$sth->execute($data);

		
				}

		


	
		}

	





?>