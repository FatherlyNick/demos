<?php include("navbuttons.php"); ?>
	<!-- Combines the index content onto a single page -->
	<div id=indexContent>
		<p>Welcome to nkolunov! Please select an app you would like to use from above. Enjoy your stay.</p>

		<div id="updates2">
			<?php include("dbstuff/getLatestUpdate.php"); ?>
		</div>
		List of TODO: <a href="index/TODO.html">here</a> <br />
		Link to Changelist: <a href="index/changelist.html">here</a> <br/>
		Link to known issues: <a href="index/issues.html">here</a>
	</div>