function validateForm(f) {

	if (f.elements['original'].value == "" || f.elements['translation'].value == "") {
		alert("None of the fields are allowed to be empty!");
		return false;
	} else {
		return true;
	}
}
