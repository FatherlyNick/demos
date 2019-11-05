<?php 	
//Used to post new Admin updates
		error_reporting(E_ALL);
		ini_set('display_errors', '1');

		include("dbcon.php");
		$db = connect_db();

		$updateText1 = $_POST['updateText'];
		$updateText = nl2br($updateText1); //Preserve the linebreaks
		
		if($_POST['imgurl'] !=''){
			$imgUrl = $_POST['imgurl'];
		} else {
			$imgUrl = "media/nkLogo.png";
		}

		$hashedpass = hash('md5', $_POST['password']); //hashed password that was sent in from the form
		
		$get_pwd = mysqli_query($db, "SELECT hashPass FROM 1803541_db.accounts WHERE username = 'admin'"); //get the pwd from db of the admin
		$result = mysqli_fetch_array($get_pwd);

		$db_pwd = $result['hashPass']; //extract the actual pwd and assign to a php var

		if( ($hashedpass == $db_pwd) ) { //if user is a valid
			

			$sql = "INSERT INTO 1803541_db.updates (updateText, imgurl) VALUES (?,?)"; //format: dbName.tableName
			$stmt = $db->prepare($sql); //make SQL string into object

			if ($stmt) {
				$stmt->bind_param('ss', $updateText, $imgUrl);
				$success = $stmt->execute();		
			} else {
				$success = false;
				echo 'Something went wrong'. $sql . "<br>" . $db->error; //echo-ing an error is okay.;
			}
		
			$db = null; //disconnect from DB
	
			if ($success === true) { //Everything went well
				header('Refresh: 2; url="http://www.nkolunov.dx.am/"');
				echo "Success! Redirecting...";
			}

		} else { //Incorrect login data
			header('Refresh: 2; url="http://www.nkolunov.dx.am/updateForm.php"');
			//header("location:javascript://history.go(-1)");
			echo 'Wrong password or username';
		}
?>