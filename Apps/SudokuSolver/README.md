Graphical representation of what the entire table looks like
Cells and panels are indexes as per code.

  Panel0		Panel1			Panel2
|--------------| |--------------| |--------------| 
|  [0][1][2]   | | [9][10][11]  | | [18][19][20] |
|  [3][4][5]   | | [12][13][14] | | [21][22][23] |
|  [6][7][8]   | | [15][16][17] | | [24][25][26] |
|--------------| |--------------| |--------------| 
Panel3				Panel4			Panel5
|--------------| |--------------| |--------------| 
| [27][28][29] | | [36][37][38] | | [45][46][47] |
| [30][31][32] | | [39][40][41] | | [48][49][50] |
| [33][34][35] | | [42][43][44] | | [51][52][53] |
|--------------| |--------------| |--------------|  
Panel6				Panel7			Panel8
|--------------| |--------------| |--------------| 
| [54][55][56] | | [63][64][65] | | [72][73][74] |
| [57][58][59] | | [66][67][68] | | [75][76][77] |
| [60][61][62] | | [69][70][71] | | [78][79][80] |
|--------------| |--------------| |--------------|  


Top corner values: 0,9,18,27,36,45,54,63,72 :: {Common denominator = 9}
Bottom corner values: 8,17,26,35,44,53,62,71,80 :: {Common denominator = none, increment is always 9}

To correct a panel = 

1) Check the validity of local panel

count up for eigght 'tiks'; Once you reach eighth 'tik', you are now on new panel.
At every tik - add the value into a temp array.

example
Panel_array = {2,4,6,9,1,6,7,8,3} <- issues: repeated 6 and lack of 5
temp array = {2,4,6,9,1,6,7,8,3}

a) check if all numbers are present
	
	//////////////
	if sum of Panel != 45 then something is wrong. <- not always true. Lets test this theory.
	{9,9,9,9,4,1,1,1,1} = sums to 45 but is obviously not a valid panel.
	///////////////
	
	Numbers_array = {0,0,0,0,0,0,0,0,0,0} // 10 slots because index 9 is needed.

	need to count the number of numbers in the array and all indexes should have a 1 in it.
	i = 0
	loop(i){
		Numbers_array[panel[i]]++;
	}
	result
	Numbers_array: {1,1,1,1,0,2,1,1,1}
	#####

	Then correct the errors.

	Input array: {2,4,6,9,1,6,7,8,3}
	Numbers_array: {0,1,1,1,1,0,2,1,1,1}

	(Index 0 should always be 0) //not sure about this.
	if there is a 0 at an index -> insert that number into the panel_array
	i = 0
	loop(i){
	
	//where to insert the required number though?
	//If there is a missing numbers then there is a repeated numbers 100%.
	so first we should elliminate the repeating numbers.

	if Numbers_array[i] > 1 then //if its a repeating number
	replace = Panel_array.IndexOf<i> //get index of repeating number
	Panel_array[i] = 0; //insert a 0 in repeating index

	if Panel_array[i] == 0 {Panel_array[i] = Numbers_array[i] } //if number is zero, set it to the value of current index
	//
	
	}