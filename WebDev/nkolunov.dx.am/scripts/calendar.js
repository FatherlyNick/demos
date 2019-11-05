//  DECLARE AND INITIALIZE VARIABLES
var day_of_week = new Array('Sun','Mon','Tue','Wed','Thu','Fri','Sat');
var month_of_year = new Array('January','February','March','April','May','June','July','August','September','October','November','December');
var Calendar = new Date();
var year = Calendar.getFullYear();	// Returns year (YYYY)
var monthNow = Calendar.getMonth();	// Returns the month of today (0-11)
var today = Calendar.getDate();		// Returns day (1-31)
var weekdayNow = Calendar.getDay();	// Returns day (0-6) 0=Sunday -> depends on the current date (setDay())
var DAYS_OF_WEEK = 7;	// "constant" for number of days in a week
var DAYS_OF_MONTH = 31;	// "constant" for number of days in a month
var cal;	// Used for printing, stores the HTML
Calendar.setMonth((0));
var displayMonth = 1;    // Start the calendar month at 0, January.
/* VARIABLES FOR FORMATTING
NOTE: You can format the 'BORDER', 'BGCOLOR', 'CELLPADDING', 'BORDERCOLOR' tags to customize your caledanr's look. */

var TR_start = '<TR>'; //Start of row
var TR_end = '</TR>'; //close row
var URL_start = '<A href="http://www.nkolunov.dx.am/cal/newAction.php?d=';
var URL_end = '">';
var URL_close = '</A>';
var highlight_start = '<TD WIDTH="30"><TABLE CELLSPACING=0 BORDER=1 BGCOLOR=DEDEFF BORDERCOLOR=CCCCCC><TR><TD WIDTH=20><B><CENTER>';
var highlight_end   = '</CENTER></TD></TR></TABLE></B>';
var TD_start = '<TD WIDTH="30"><CENTER>'; //Start cell
var TD_end = '</CENTER></TD>'; //close cell

/* BEGIN CODE FOR CALENDAR NOTE: You can format the 'BORDER', 'BGCOLOR', 'CELLPADDING', 'BORDERCOLOR' tags to customize your calendar's look.*/
for(currentMonth = 0; currentMonth<=11; currentMonth++) { //Loop through all months

	Calendar.setDate(1);    // Start the calendar day at '1'
	cal =  '<TABLE BORDER=1 CELLSPACING=0 CELLPADDING=0 BORDERCOLOR=BBBBBB><TR><TD>';
	cal = cal + '<TABLE BORDER=0 CELLSPACING=0 CELLPADDING=2>' + TR_start;
	cal = cal + '<TD COLSPAN="' + DAYS_OF_WEEK + '" BGCOLOR="#EFEFEF"><CENTER><B>';
	cal = cal + month_of_year[currentMonth]  + '   ' + year + '</B>' + TD_end + TR_end;
	cal = cal + TR_start;

// LOOPS FOR EACH DAY OF WEEK
for(index=0; index < DAYS_OF_WEEK; index++) { //Go through the DAYS_OF_WEEK array 
	
  // BOLD TODAY'S DAY OF WEEK
  if( (weekdayNow == index) && (monthNow == currentMonth) ) {
    cal = cal + TD_start + '<B>' + day_of_week[index] + '</B>' + TD_end;
  }

  // PRINTS DAY of week
  else {
    cal = cal + TD_start + day_of_week[index] + TD_end;
  }

}//end of printing day of week (M-S)

cal += TD_end + TR_end; //close cell + close row
cal += TR_start; //start next row

// FILL IN BLANK GAPS UNTIL TODAY'S DAY OF WEEK
for(index=0; index < Calendar.getDay(); index++) { //Draw '#' until today's day of week (M-S)
	cal = cal + TD_start + '#' + TD_end;
}

// LOOPS FOR EACH DAY IN CALENDAR
for(index=0; index < DAYS_OF_MONTH; index++) {
	if( Calendar.getDate() > index ) { //If current date > index
		// RETURNS THE NEXT DAY TO PRINT
		weekday = Calendar.getDay(); //weekday = current day of week of the set month

		// START NEW ROW FOR FIRST DAY OF WEEK
		if(weekday == 0) {
			cal += TR_start;
		}
		if(weekday != DAYS_OF_WEEK) {

			// SET VARIABLE INSIDE LOOP FOR INCREMENTING PURPOSES
			var day  = Calendar.getDate();

				// HIGHLIGHT TODAY'S DATE
				if( today == Calendar.getDate() && (monthNow == currentMonth)) {
					cal += highlight_start + URL_start+day+'&m='+displayMonth+'&y='+year+URL_end + day + URL_close + highlight_end + TD_end;
				} else {
					cal += TD_start + URL_start+day+'&m='+displayMonth+'&y='+year+URL_end + day + URL_close + TD_end;
				}
		}

		// END ROW FOR LAST DAY OF WEEK
		if(weekday == DAYS_OF_WEEK) {
			cal += TR_end;
		}
	}

  // INCREMENTS UNTIL END OF THE MONTH
  Calendar.setDate(Calendar.getDate()+1);

}// end for loop printing of the current month

cal += '</TD></TR></TABLE></TABLE>'; //close the table
cal = cal + '<br>'; //Add a blank line after this complete calendar
document.write(cal); //  PRINT CALENDAR
displayMonth++;
}//end of outer for loop, the year is complete