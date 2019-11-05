<?php session_start(); ?>
<!-- Standard Header used across the site -->
<!DOCTYPE html>
<!-- Javascripts that are used to be imported here. -->
<script src="http://www.nkolunov.dx.am/scripts/validate.js" type="text/javascript"></script>
<script src="http://www.nkolunov.dx.am/scripts/fillMailBox.js" type="text/javascript"></script>
<script src="http://www.nkolunov.dx.am/scripts/fillBoxScript.js" type="text/javascript"></script>
<script src="http://www.nkolunov.dx.am/scripts/verifyPasswords.js" type="text/javascript"></script>
<script src="http://www.nkolunov.dx.am/scripts/validate.js" type="text/javascript"></script>

<?php $db = mysqli_connect('185.176.40.66','1803541_db','Vqk6630(','1803541_db'); // DB connection. <address>,<db_name>,<pwd>,<table_space>
	ob_start();	// Start Output Buffer - do not spit out the db output as you get it, but only get it when requested.
?>


	<head>

		<meta charset="utf-8"/>
		<link rel="stylesheet" type="text/css" href="/style/css/style.css" title="default" />
		<title>//N. Kolunov</title>

	</head>

<div id="header"> 
			Work in progress. Expect functional / cosmetic issues and debug text. Older browsers might not support some features.
</div>