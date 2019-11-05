<?php
	//$page = "definitionary"; //Deprecated
	include("../header.php");
	include("../dbstuff/dbcon.php");
?>

<body>
	<div id="content">

		<?php include("../navbuttons.php"); ?>

		<p>A web app where users can add words and define meaning for that word / modify existing definitions<br/>

		<div id="Alphabet jump list"><a name="top"></a>
			<a href="#a">A</a> <a href="#b">B</a> <a href="#c">C</a> <a href="#d">D</a> <a href="#e">E</a> <a href="#f">F</a> <a href="#g">G</a> <a href="#h">H</a> <a href="#i">I</a> <a href="#j">J</a> <a href="#k">K</a> <a href="#l">L</a> <a href="#m">M</a> <a href="#n">N</a> <a href="#o">O</a> <a href="#p">P</a> <a href="#q">Q</a> <a href="#r">R</a> <a href="#s">S</a> <a href="#t">T</a> <a href="#u">U</a> <a href="#v">V</a> <a href="#w">W</a> <a href="#x">X</a> <a href="#y">Y</a> <a href="#z">Z</a> <br/>
		</div>


		<form class="defButFixed">
			<button formaction="newWord.php">+ Add new word</button>
		</form>


		<?php
			//Generate alphabet sections on the page
			$low_let=97; //Lower case a
			for($cap_let=65; $cap_let<=90; $cap_let++) {
				echo "<a name=".chr($low_let).">/==========<br/>Section ".chr($cap_let)."<br/>\\==========</a> </br>";
				$section = "[".chr($cap_let)."]"."|"."[".chr($low_let)."]"; // [a]|[A] this is used in the regular expression to fetch the right 
				include("../dbstuff/getWords.php"); //This executes the PULL from getWords.php with a different case letter
				$low_let++;
			}
		?>
			v1.2 BETA
	</div> <!-- end of content -->

<?php 
	mysqli_close($db); //Disconnect from DB
	include("../footer.php");
?>