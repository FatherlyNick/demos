<?php include("header.php"); ?>
<!-- Admin update form. No need to make this pretty for users. -->
	<div id="content">
		<form method="post" name="postUpdate" action="../dbstuff/postUpdate.php" method="POST">Post admin update <br/>
			<input type="password" name="password" placeholder="password" maxlength="28" required><br/>
			<textarea name="updateText" class="updateBox" wrap="hard"></textarea> <br/>
			Update image url: <input type="text" name="imgurl" placeholder="http://www.imgur.com/"></input><br/>
			<input type="submit" value="Submit">
		</form>
	</div>
<?php include("footer.php"); ?>