<!-- Login form opened from bottom of the anonymous date click page, not sure if this should be there at all.-->
<?php include("../header.php"); ?>
	<div id="content">
			<?php include("../navbuttons.php"); ?>
			<form method="post" name="calLogin" action="../dbstuff/cal-login-handle.php" method="POST"> LOGIN <br/>
				Username:
				<input type="text" name="username" placeholder="username2" maxlength="28" required>
				Password: <input type="password" name="password" placeholder="password" maxlength="28" required> <input type="submit" value="Submit">
				<input type="hidden" name="urlDMY" value="<?php echo($day."&m=".$month."&y=".$year);?>"></input><br/>
				<input type="hidden" name="pageVar" value="">
			</form>
	</div>
<?php include("../footer.php"); ?>