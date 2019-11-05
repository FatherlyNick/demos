<?php include("../header.php");
	session_start();
	$dmy = '';
	$month = $_GET['m'];
	$day = $_GET['d'];
	$year = $_GET['y'];
	$dmy = $day.$month.$year;
	$uid = $_SESSION['userid'];
	$_SESSION['url'] = "?d=".$day."&m=".$month."&y=".$year;
?>

	<div id="content">
		<?php include("../navbuttons.php"); ?>
			<?php if($uid == '') { include("loginForm.php"); } //If anonymous, show login form
				else { echo "<hr>";
						echo "<div id=\"currentEvents\">";
							echo "<p>Events for the date:".$_GET['d'] . "/" . $month . "/" .$_GET['y'];
							echo "<br/>";
							include("../dbstuff/getEvents.php");
						echo "</div>";
						
						echo "<div id=\"newEvent\">";
							include("../dbstuff/newEventForm.php");
						echo "</div>";
				}
			?>
	</div>
	
<?php mysqli_close($db);
include("../footer.php"); ?>