<?php include("../header.php") ?>
<div id="content">
***UNDER CONSTRUCTION***<br/>This is a db connection test page. The page is connecting to a mySQL database and querying values from a table intended for bug reports.<br/>
<br/>
<hr>

<?php

	include("dbcon.php");
	

	// Check connection
	if (mysqli_connect_errno()) {
		echo "Failed to connect to MySQL: " . mysqli_connect_error();
	}

	$result = mysqli_query($db,"SELECT * FROM posts ORDER BY original ASC");

	echo "<div id=\"db_table1\">";
	while($row = mysqli_fetch_array($result)) {
		
		echo "Enrty ID: ". $row['ID'] . "<br/>

		Original: ". $row['original'] . "<br/>

		Translation ". $row['translation'] . "<br/>

		Entry date: ".$row['P_date'] . "<br/>";

	}

	
	mysqli_close($db);
echo "</div>";
?>

<?php include("newString.php"); ?>
</div>