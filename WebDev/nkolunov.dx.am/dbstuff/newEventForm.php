<div id="newEvent-form">
	<h1>Add a new event:</h1>
    		<form name="newEvent-form" action="../dbstuff/postNewEvent.php" method="POST">
    		Event Description:</br>
       			<textarea name="eventDesc" class="newEventBox" placeholder="Event Description" wrap="hard" required></textarea>
				
				Event Type:
					<select name="eventType" id="eventT" required>
						<option value="0">General</option>
						<option value="1">Dead-line</option>
						<option value="2">Celebration</option>
						<option value="3">Reminder</option>
					</select>

					<input type="hidden" name="dmy" value="<?php echo($dmy);?>"></input>
					<input type="hidden" name="urlDMY" value="<?php echo($day."&m=".$month."&y=".$year);?>"></input><br/>

       			<input type="submit" value="Submit"/>
    			</form>
</div>