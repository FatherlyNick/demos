<?php 	session_start();
		error_reporting(E_ALL);
		ini_set('display_errors', '1');

		include("dbcon.php");
		$db = connect_db();
		
		$login = $_POST['username'];
		$hashedpass = hash('md5', $_POST['password']); //hashed password that was sent in from the form
		
		$get_pwd = mysqli_query($db, "SELECT hashPass FROM 1803541_db.accounts WHERE username = '$login'"); //get the pwd from db of the user
		$result = mysqli_fetch_array($get_pwd);

		$db_pwd = $result['hashPass']; //extract the actual pwd and assign to a php var

		if( ($_POST['pageVar'] != '') && ($hashedpass == $db_pwd) ) { //if user is logging in from the main cal page
			$_SESSION['userid'] = $login;
			header('Refresh: 2; URL = ../cal/calendary.php');
			echo 'You have entered valid use name and password';
		}
		
		else if (isset($_POST) && ($hashedpass == $db_pwd)) { //if this was triggered by a form submit
			$url = $_SESSION['url']; //DMY formatted for the URL
			$url = "http://www.nkolunov.dx.am/cal/newAction.php".$url;
			$_SESSION['userid'] = $login;
			header("refresh: 2; URL=$url");
			echo 'You have entered valid use name and password';
		} else {
			header("Refresh: 2; URL = ../cal/newAction.php");
			echo 'Wrong password or username';
		}
?>