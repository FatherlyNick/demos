<?php session_start();
	$uid = $_SESSION['userid'];

	if($uid != '') {
		$result = mysqli_query($db,"SELECT * FROM calendary WHERE (username = '$uid') ORDER BY DMY ASC");
		while($row = mysqli_fetch_array($result)) {
			echo "Date:	".$row['DMY']." :: Event Description: ". $row['event'] . "<br/>";
		}
	} else {
		echo("You need to <a href=\"http://www.nkolunov.dx.am/cal/loginForm3.php\"> Login </a> or <a href=\"http://www.nkolunov.dx.am/cal/newID.php\"> Register </a> to view events.");
}
?>
<br/>