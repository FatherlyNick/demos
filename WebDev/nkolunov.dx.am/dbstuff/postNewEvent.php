<?php session_start();
//Used by Calendary to add new event
//ID ID of the post

//userid Hashed username

//DMY day month year combined into one number

//event Event text

	error_reporting(E_ALL);
	ini_set('display_errors', '1');

	include_once("dbcon.php");
	$db = connect_db();
	//if POST is set, then this page was reached from a form
	if(isset($_POST)) {
		// The variables in square brackets are the variable recieved from the HTML form
		$url = $_POST['urlDMY']; //DMY formatted for the URL
		$eventDesc1 = $_POST['eventDesc']; //Event description
		$eventDesc = nl2br($eventDesc1); //Preserve new lines as a line break. This will display new lines in the event description as the user typed them in.
		$nDMY = $_POST['dmy']; //dmy from the form
		$evType = $_POST['eventType']; //Type of the event.
		$uid = $_SESSION['userid']; //ID of the user.

		$sql = "INSERT INTO 1803541_db.calendary (DMY, event, eventType, username) VALUES (?,?,?,?)"; //format: dbName.tableName
		$stmt = $db->prepare($sql); //make SQL string into object

		if ($stmt) {
			$stmt->bind_param('isis', $nDMY, $eventDesc, $evType, $uid); //is = Integer, String
			$success = $stmt->execute();
		} else {
			$success = false;
			echo "Error: " . $sql . "<br>" . $db->error; //echo-ing an error is okay.
		}

	} //end of isset $_POST
		
	$db = null; //disconnect from DB

	exit(header("Location: ../cal/newAction.php?d=$url")); // Redirects to the id of the user. //now need the page to tell the user that
?>