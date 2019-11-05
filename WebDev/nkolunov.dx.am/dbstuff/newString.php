<?php $strID = $_GET['id']; //set ID of selected string

	$orig = "";
	$tran = "";
	if($strID > 0) { //If user is editing an existing string
		$query = mysqli_query($db,"SELECT * FROM posts WHERE ID = $strID");
		$result = mysqli_fetch_array($query); //Get theexisting String data

		$orig = $result['1']; //Get the original string
		$tran = $result['2']; //Get the translation
		$iURL = $result['4']; //Get the String image URL
		$vURL = $result['5']; //Get the String audio URL
	}
	include("../navbuttons.php");
?>

<div id="translation-form">
	<h1>Add a new definition / translation:</h1>
	<form name="translation-form" onsubmit="return validateForm(this); return false;" action="../dbstuff/post.php?id=<?php echo($strID);?>" method="POST">
		Term / Original:</br>
		<textarea name="original" class="newWord-box" placeholder="Put the word you want to define here"><?php echo($orig); ?></textarea>
		<br />
		Explanation / Translation:</br>
		<textarea name="translation" class="newWord-box" placeholder="Explain the word here"><?php echo($tran); ?></textarea>
		<br />
	Image url: <input type="text" name="i-URL" placeholder="http://www.imgur.com/" value="<?php echo($iURL); ?>"></input><br/>
	Audio url: <input type="text" name="v-URL" placeholder="http://www.vocaroo.com/" value="<?php echo($vURL); ?>"></input><br/>

		<input type="submit" value="Submit"/>
	</form>
</div>