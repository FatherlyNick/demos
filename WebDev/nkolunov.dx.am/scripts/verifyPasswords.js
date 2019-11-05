function verifyPasswords(arg1, arg2) {
	if(arg1 === arg2) {
		return true;
	} else {
		alert("Passwords do not match!");
		return false;
	}
}