<?php
// Code used by Definitionary to insert new words or update words

	error_reporting(E_ALL);
	ini_set('display_errors', '1');

	include_once("dbcon.php");
	$db = connect_db();

	//if POST is set, then this page was reached from a form
	if(isset($_POST)) {
		// The variables in square brackets are the variable recieved from the HTML form
		$orig = $_POST['original'];
		$trans = $_POST['translation'];
		$iURL = $_POST['i-URL'];
		$vURL = $_POST['v-URL'];
		$strID = $_GET['id'];

		if(is_null($strID) || $strID == "") { //If this is not an existing string
			$sql = "INSERT INTO 1803541_db.posts (original,translation,imgURL,voURL) VALUES (?,?,?,?)"; //format: dbName.tableName
			$stmt = $db->prepare($sql); //make SQL string into object

			if ($stmt) {
				$stmt->bind_param('ssss', $orig, $trans, $iURL, $vURL); // ss means two strings
				$success = $stmt->execute(); //Insert the new string into DB. Sets success to true if it completes correctly.
			} else { //something went wrong
				$success = false;
				echo "Error: " . $sql . "<br>" . $db->error; //echo'ng an error is okay.
			}

		} else { //Update existing string
					
			$sql = "UPDATE 1803541_db.posts SET original='$orig',translation='$trans',imgURL='$iURL',voURL='$vURL' WHERE ID=$strID"; //SQL command to update the existing String entry in DB
			$stmt = $db->prepare($sql); //Make SQL string into Object

			if($stmt) {
				$success = $stmt->execute(); //Update the string in DB. Set success to true if it completes correctly.

			} else { //Something went wrong
				$success = false;
				echo "Update failed <br>" . $sql . "<br>" . $db->error;
			}

		} //end of UPDATE string

	}//end of POST

	$db = null; //disconnect from DB

	exit(header("Location: ../defy/definitionary.php"));
?>