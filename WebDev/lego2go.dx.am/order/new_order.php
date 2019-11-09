<?php include("../header.php"); ?>
	<body>
		<div id="content">
		<p>This is the order page. Under construction.</p>
		<div id="setPreview">
			<!-- <iframe id="previewWindow2" src="" style="border: outset; background-color:#333" height="100%" width="30%"></iframe><br/> -->
			<img id="previewWindow" src="" style="border: outset; background-color:#333" height="100%" width="30%" hidden="true" alt="Set Image">
		</div>


        <li>
            <ul>Item 1</ul> <ul>Item 3</ul>
            <ul>Item 2</ul> <ul>Item 4</ul>
        </li>

		<form name="order-form" onsubmit="return validateForm(this); return false;" action="order2.php" method="POST">
		Set number:<br/>
		<select name="set_num" id="set_num" onchange="previewSet()" required>
			<option value="null"></option>
			<option value="10256">10256 - Taj Mahal</option>
			<option value="42043">42043 - Mercedez-Benz Arocs</option>
			<option value="42055">42055 - Bucket Wheel Excavator</option>
			<option value="70618">70618 - Destiny's Bounty</option>
			<option value="60052">60052 - CITY Cargo Train</option>
			<option value="96941">96941 - Halo Covenant Phantom</option>
		</select><br/>		<br />
		Duration:<br/>
		<input type="number" name="duration" max="28" min="2" placeholder="Min 2 days. Max 28 days" required/>
		<br />
		<input type="submit" value="Proceed"/>
		</form>

		</div>
	</body>