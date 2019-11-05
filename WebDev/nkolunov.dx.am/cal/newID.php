<?php session_start(); 
include("../header.php");
//echo "url TEST:".$SESSION['url']; //DEBUG
 ?>
	
		<div id="content">
			<?php 	include("../navbuttons.php");
					include("../dbstuff/newUser.php");
			?>
		</div>

<?php include("../footer.php"); ?>