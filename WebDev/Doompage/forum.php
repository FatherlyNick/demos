<?php

error_reporting(E_ALL);
ini_set('display_errors', '1');

?>
<?php $page = "about"; ?>
<?php include("header.php"); ?>

	<div id ="sidebar"> <!-- sidebar contents-->

		<?php include("sidebar.php") ?> 

	</div><!--end of sidebar-->


	<div id="content"><!--This stuff should change from page to page-->
		<p> This is the Discussion page! </p>	<br>
	<div id ="forum">
	<?php include("blog-content.php"); ?>
	</div>
		</div><!--end of contents-->






<div id="footer">
<?php include("footer.php"); ?>
</div><!--end of footer-->


