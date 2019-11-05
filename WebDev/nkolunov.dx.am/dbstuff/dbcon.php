<?php
	error_reporting(E_ALL);
	ini_set('display_errors', '1');

	function connect_db() {

		$username = 'redacted_username'; //use your DB username
		$password = 'readcted_password'; //user your db password
		$db = mysqli_connect('xx.xx.40.66', $username, $password); // create connection with db via IP address. Change to your db address
	
		if(!$db) {
			die("Connection failed: " . mysqli_connect_error());
    	}
		return $db;
	}
?>
