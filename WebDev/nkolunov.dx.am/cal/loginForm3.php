<?php include("../header.php"); ?>
<!-- Login form opened from the main Cal page -->
	<div id="content">
			<?php include("../navbuttons.php"); ?>
			<form method="post" name="calLoginMain" action="../dbstuff/cal-login-handle.php" method="POST"> LOGIN <br/>
				Username:
				<input type="text" name="username" placeholder="username" maxlength="28" required>
				Password: <input type="password" name="password" placeholder="password" maxlength="28" required>
				<input type="hidden" name="pageVar" value="1">
				<input type="submit" value="Submit">
			</form>
	</div>
<?php include("../footer.php"); ?>