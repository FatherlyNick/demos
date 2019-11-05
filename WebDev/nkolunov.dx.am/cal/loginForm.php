<!-- Login form when an anonymous user clicks on a date -->
<form method="post" name="calLogin" action="../dbstuff/cal-login-handle.php" method="POST"> LOGIN <br/>
	Username:
	<input type="text" name="username" placeholder="username" maxlength="28" required> <!-- Custom username -->
	Password:
	<input type="password" name="password" placeholder="password" maxlength="28" required> <!-- New user password -->
	<input type="submit" value="Submit">
	<input type="hidden" name="urlDMY" value="<?php echo($day."&m=".$month."&y=".$year);?>"><br/> <!-- Store the date that the user clicked on -->
	<input type="hidden" name="pageVar" value="">
</form>

	<input type="button" onclick="location.href='http://www.nkolunov.dx.am/cal/newID.php';" value="Register" />
	<input type="button" onclick="location.href='http://www.nkolunov.dx.am/cal/forgotID.php';" value="Forgot my ID" />