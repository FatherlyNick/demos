function fillMailBox(){
	var dropdown1 = document.getElementById('category');
	var textbox = document.getElementById('messagebod');
	var fereq = unescape( encodeURIComponent("Issue:\n======\n\n\nCurrent state:\n==============\n\n\nExpected state:\n===============\n\n\nWhat would this improve? i.e visual/functionality"));

	if(dropdown1.selectedIndex == 0) {
		textbox.value = "";
	} else if(dropdown1.selectedIndex == 1) {
		textbox.value = fereq;
	} else if(dropdown1.selectedIndex == 2) {
		textbox.value = "Title:\n======\n\n\nUse Case:\nStep 1:\nStep 2:\nStep...\n\nLinks to existing equivalents or user submitted mock-ups:\n";
	}
}