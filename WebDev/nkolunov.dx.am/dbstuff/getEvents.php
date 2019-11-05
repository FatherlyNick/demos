<div id="db_table1">
	<?php session_start();
		$uid = $_SESSION['userid'];

		if($uid != '') {
			$result = mysqli_query($db,"SELECT * FROM calendary WHERE (DMY = '$dmy') AND (username = '$uid') ORDER BY ID ASC");
			echo "Event Description:<br/>";
			while($row = mysqli_fetch_array($result)) {
				echo $row['event'] . "<br/>---<br/>";
			}
		} else {
			echo("You need to <a href=\"http://www.nkolunov.dx.am/cal/loginForm2.php".$_SESSION['url']."\"> Login </a> or <a href=\"http://www.nkolunov.dx.am/cal/newID.php".$_SESSION['url']."\"> Register </a> to view events.");
		}

?>
</div><br/>