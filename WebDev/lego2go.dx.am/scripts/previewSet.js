function previewSet() {

console.log("PreviewSet called") //DEBUG
	var dropdown1 = document.getElementById('set_num');
	var setWin = document.getElementById('previewWindow');
console.log("setWin.src: ->"+setWin.src); //DEBUG
console.log("dropdown1.selectIndex: ->"+dropdown1.selectedIndex); //DEBUG

if(dropdown1.selectedIndex == 1) {
		setWin.src = "http://lego2go.dx.am/media/10256.jpg";
	} else if(dropdown1.selectedIndex == 2) {
		setWin.src = "http://lego2go.dx.am/media/42043.jpg";
	} else if(dropdown1.selectedIndex == 3) {
		setWin.src = "http://lego2go.dx.am/media/42055.jpg";
	} else if(dropdown1.selectedIndex == 4) {
		setWin.src = "http://lego2go.dx.am/media/70618.jpg";
	} else if(dropdown1.selectedIndex == 5) {
		setWin.src = "http://lego2go.dx.am/media/60052.jpg";
	} else if(dropdown1.selectedIndex == 6) {
		setWin.src = "http://lego2go.dx.am/media/96941.jpg";
	}




}