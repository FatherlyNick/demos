<?php session_start();
	$uid = $_SESSION['userid']; //Store username
	include("../header.php");
?>
<!-- 
	The main page of the Calendary app.
 -->

		<div id="content">
			<?php include("../navbuttons.php"); 
				if($uid != '') { //if user is logged in, display logout button
					echo "<input type=\"button\" onclick=\"location.href='http://www.nkolunov.dx.am/dbstuff/logout.php'\"; value=\"Logout\" />";
				} else {
					echo "<input type=\"button\" onclick=\"location.href='http://www.nkolunov.dx.am/cal/newID.php';\" value=\"New Calendary User\" /> <br/>";								}
			?>
			
			<p>Manage your calendar here. <br/>

			Click on any date, to add an event for that day.

			</p>


			<p class="userEvents"><?php include("../dbstuff/getAllEvents.php"); ?> </p>
			<script src="http://www.nkolunov.dx.am/scripts/calendar.js" type="text/javascript"></script>
		</div>

<?php include("../footer.php"); ?>