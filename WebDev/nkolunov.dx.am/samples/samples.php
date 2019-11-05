<?php include("../header.php"); ?>


	<div id="content">
		<?php include("../navbuttons.php"); ?> <br/>

<div id="sectionButtons">
	<input type="submit" value="Java" onClick="fillBox('java/helloWorld.html');"> <br/>
	<input type="submit" value="Visual Basic" onClick="fillBox('visual basic/helloWorld.vb')";> </br>
	<input type="submit" value="C#" onClick="fillBox('cs/helloWorld.html');"> </br>
	<input type="submit" value="C++" onClick="fillBox('cpp/helloWorld.html')";> </br>
	<input type="submit" value="Python" onClick="fillBox('python/helloWorld.html')";> </br>
	<input type="submit" value=".bat" onClick="fillBox('batch/helloWorld.html')";> </br>
</div>


<div id="codeSection">
	<iframe id="codeFrame" src="initText.html" style="border: outset; background-color:#FFFFFF" height="100%" width="100%"></iframe></br>
</div>


	</div>
	
	
<?php include("../footer.php"); ?>