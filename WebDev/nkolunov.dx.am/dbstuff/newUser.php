<!-- This is the form used on newID.php -->
<div id="newUser-form">
    <h1>Add a new user:</h1>
	<!-- Check if the two passwords typed match each-other to avoid wrong password set by user -->
    <form name="new-user" action="../dbstuff/postUser.php" method="POST" onsubmit="return verifyPasswords(document.forms['new-user']['password'].value, document.forms['new-user']['password2'].value)">
	Username:<br/>
		<input type="text" name="username" class="newUser-box" placeholder="Username" required/><br/>
	Password:<br/>
		<input type="password" name="password" class="newUser-box" placeholder="password" required/>
		<input type="password" name="password2" class="newUser-box" placeholder="password" required/>

	Secret question:
		<select name="question" id="question" required>
			<option></option>
			<option value="0">What is your hair color?</option>
			<option value="1">What city do you live in?</option>
			<option value="2">What is your favorite movie?</option>
			<option value="3">What was the name of your first partner?</option>
			<option value="4">What is your dream job?</option>
			<option value="5">What is your favorite brand?</option>
		</select><br/>
	Secret answer:<br/>
	<textarea name="answer" placeholder="Secret answer" required></textarea><br/>
	<input type="submit" value="Submit"/>
    </form>
</div>