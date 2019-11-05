<div id="db_table1">
	<?php
		$result = mysqli_query($db,"SELECT * FROM posts WHERE original REGEXP '^[$section].*$' ORDER BY original ASC"); //Select word that starts with[$section]

		while($row = mysqli_fetch_array($result)) {
		
			echo "
				Original:	". $row['original'] . "<br/>
				Meaning:	". $row['translation'] . "<br/>";

			if($row['imgURL'] != "") { //If there exists an image URL
				echo "Picture: <a href=\"".$row['imgURL']."\">Link to image</a><br/>";
			}

			if($row['voURL'] != "") { //If there exists a VO URL
				echo "Audio: <a href=\"".$row['voURL']."\">Link to audio</a><br/>";
			}

			echo "<div id=\"post_info\">Entry date: ".$row['P_date']."</div><input type=\"button\" onclick=\"location.href='http://www.nkolunov.dx.am/defy/newWord.php?id=".$row['ID']."';\" value=\"Edit\" />/----------------<br/>"; //Print out the word formatted

		}

	?>
</div><br/>