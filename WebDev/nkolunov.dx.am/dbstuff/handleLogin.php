<?php	session_start();
		error_reporting(E_ALL);
		ini_set('display_errors', '1');

		include("dbcon.php"); //Connect to DB
		$db = connect_db();
		
		$login = $_POST['username']; //Username that was entered in the form
		$hashedpass = hash('md5', $_POST['password']); //hashed password that was sent in from the form
		
		$get_pwd = mysqli_query($db, "SELECT hashPass FROM 1803541_db.accounts WHERE username = '$login'"); //get the pwd from db of the user
		$result = mysqli_fetch_array($get_pwd);

		$db_pwd = $result['hashPass'];

		
		if (isset($_POST['login']) && ($hashedpass == $db_pwd)) { //if this was triggered by a form submit and the passwords match
			header('Refresh: 2; URL = ../cal/calendary.php');
			echo 'You have entered a valid username and password';
			$_SESSION['userid'] = $login; //login the user
			echo("sess: ".$_SESSION['userid']);

		} else {
			header('Refresh: 2; URL = ../test/st.php'); //Reject
			echo 'Wrong password or username';
		}
?>
