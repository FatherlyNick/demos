#include <iostream>
#include <string>
/**
	Utility used to turn strings into html-ready php statements.
	EXAMPLE:
	input = test "string" <php var1> is of the value: <php var2>
	output = <?php echo("test \"string\"".$var." is of the value:".$var2); ?>
	
	argv[0] = name of executable
	argv[1] = First arg
	argv[2] = Second arg

*/
using namespace std;

//need to take this out into a separate .h
string str2url(string inputStr) {
	return "<URL>"+inputStr;
}

string str2pecho(string inputStr) {
	return "<ECHO>"+inputStr;
}

string str2pinclude(string inputStr) {
	return "<INCLUDE>"+inputStr;
}

string readyPage() {
	return "<html></html>";
}

int main(int argc, char* argv[]) { //http://www.cplusplus.com/articles/DEN36Up4/
	
	string input = "";
	int option = 0;
	
	if(argc == 1 || (argv[0] == "-h" || argv[0] == "-H") ) {
		cout << "Usage: \n  <option> <string>" << endl;
		cout << " 1 = URL conversion\n 2 = php echo string\n 3 = php include string\n 4 = template page with db connection and session" << endl;
		cout << "Example input:\n 1 www.example.com\nReturns:\n <a href=\"http://www.example.com\">example.com</a> " << endl;
	} else if(argc == 3) {
		//option >> argv[1]; //1,2,3,4
		//option = static_cast<int>(*argv[1]);
		option = (*argv[1]) - 49; // convert from char to int
		input = argv[2]; // input string
		//do things
		//trigger a case here 1,2,3 or 4.
		//cout << "number of args: " << argc << "\narg1: " << argv[0] << "\narg2: " << argv[1] << "\narg3: "<< argv[2] << endl;
		//cout << "Option: "<< option << endl;
		//cout << "Input: " << input <<endl;
		switch(option) {
			case 1: //URL conversion selected
				cout << "URL conversion selected. Converting..." << endl;
				cout << str2url(input);
				break;
			
			case 2: //php echo selected
				cout << "PHP echo conversion selected. Converting..." << endl;
				cout << str2pecho(input);
				break;
			
			case 3: //php include selected
				cout << "PHP include conversion selected. Converting..." << endl;
				cout << str2pinclude(input);
				break;
			
			case 4:
				cout << "Template page selected. Generating..." << endl;
				cout << readyPage();
				break;
			
			default: //something went wrong
				cout << "Incorrect options selected. Type str2php.exe -h for help." << endl;	
				break;
		}
		
		//input = input; //debug
	} else {
		//something wrong
		cerr << "Incorrect number of arguments entered.";
	}
	//cin >> input; //debug
	
	//cout << "Output: " << endl; //debug
	//cout << str2php(input); //debug
}
