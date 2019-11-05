<?php
	$result = mysqli_query($db,"SELECT * FROM updates ORDER BY ID DESC");
	$row = mysqli_fetch_array($result);
	echo $row['updateText'] . "<br/> <img alt='update_image' src=".$row['imgurl']."><br/> 
	<div id=\"post_info\">Entry date: ".$row['uDate'] . "</div><br/>";
?>