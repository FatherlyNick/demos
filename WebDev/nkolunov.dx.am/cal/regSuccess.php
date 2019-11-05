<?php session_start();
//Smart re-direction. If user came from cal, send them back to cal after registration. If user came from new Action, send them back to New Action form after registration.
if($_SESSION['url'] == '') {
	header('Refresh: 2; URL = calendary.php');
	include("../header.php");
	echo "<div id=\"content\">";
	echo "Wait, how did you get here? Please report this bug!";
	echo "</div>";
	} else {
		$url = $_SESSION['url'];
		header('Refresh: 2; URL = newAction.php'.$url);
		include("../header.php");
		echo "<div id=\"content\">";
		include("../navbuttons.php");
		echo "<br/>";
		echo "<p>User registered! Your username is: ".$_SESSION['userid']."</p>";
		echo "</div>";
	}
 ?>
<?php include("../footer.php"); ?>