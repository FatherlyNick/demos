<?php include("../header.php"); ?>

<div id="wrapper">
	
	<div id="content">

		<?php include("../navbuttons.php"); ?>
		<p>Section for submitting feedback or requesting features</p>

		<form method="post" name="contact_form" action="contact-form-handler.php">
		Your Name:
		<input type="text" name="name" placeholder="Name" maxlength="28" required/>
		Email Address:
		<input type="email" name="email" placeholder="mail@mail.com" required/>
		Category:
		<select name="category" id="category" onchange="fillMailBox()" required>
			<option value="null"></option>
			<option value="feedback">Feedback</option>
			<option value="Feature-req">Feature request</option>
		</select></br>
    		Message:
    			<textarea name="messagebod" id="messagebod" class="feedback-form" required></textarea>
			
			<input type="submit" value="Submit"/>
		</form>
	</div>

	<?php include("../footer.php"); ?>
</div>