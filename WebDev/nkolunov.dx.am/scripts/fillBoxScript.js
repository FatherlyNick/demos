function fillBox() {
	var TheTextBox = document.getElementById("codeFrame"); //Store the HTML text box in a var
	var tempPath = "\""+arguments[0]+"\"";
	TheTextBox.src = tempPath;
	TheTextBox.src = arguments[0];
}	