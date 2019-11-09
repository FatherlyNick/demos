<?php
	error_reporting(E_ALL);
	ini_set('display_errors', '1');

	function connect_db() {

		$username = '2857667_l2g';
		$password = 'Vqk6630)';
		$db = mysqli_connect('185.176.43.89', $username, $password); // create connection
	
		if(!$db) {
			die("Connection failed: " . mysqli_connect_error());
    	}
		return $db;
	}
?>