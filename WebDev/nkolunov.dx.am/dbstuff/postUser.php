<?php session_start();
//ID 

//username 

//hashID This is username hashed

//secretAns The secret answer

//secretQ Secret question


	error_reporting(E_ALL);
	ini_set('display_errors', '1');

	include_once("dbcon.php");
	$db = connect_db();

	//if POST is set, then this page was reached from a form
	if(isset($_POST)) {
		// The variables in square brackets are the variable recieved from the HTML form
		$username = $_POST['username']; //pre-hash username
		$password = hash('md5', $_POST['password']); // Hashed Username
		$secQ = $_POST['question']; //secret question INT from 0 to 9
		$preHashSecAns = $_POST['answer']; //secret answer pre-hash
		$secAns = hash('md5', $preHashSecAns); //hashed secret answer, so as to not store RAW TEXT in db

		$sql = "INSERT INTO 1803541_db.accounts (username, hashPass, secretAns, secretQ) VALUES (?,?,?,?)"; //format: dbName.tableName
		$stmt = $db->prepare($sql); //make SQL string into object

		if ($stmt) {
			$stmt->bind_param('sssi', $username, $password, $secAns, $secQ);
			$success = $stmt->execute();
			$_SESSION['userid'] = $username;
			
		} else {
			$success = false;
			echo "Error: " . $sql . "<br>" . $db->error; //echo'ng an error is okay.
		}
		
		$db = null; //disconnect from DB

		if ($success === true) {
			exit(header("Location: ../cal/regSuccess.php")); //now need the page to tell the user that everything went well
		}


	} //end of isset $_POST
?>