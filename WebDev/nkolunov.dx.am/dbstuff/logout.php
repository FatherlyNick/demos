<?php
	session_start();
	unset($_SESSION['userid']); //remove username variable
	$uid = ''; //set local username to blank string
	$_SESSION['userid'] = ''; //set Session username to blank string

	header('Refresh: 2; URL = http://www.nkolunov.dx.am/cal/calendary.php');

	echo("You have logged out");

?>