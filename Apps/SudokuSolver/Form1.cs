using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuSolver { 

    

    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent(); //init everything in the window
            initElements();//Create panels and textboxes
            setVals(); //populate textboxes with init values
    }

        //private void TextBox1_TextChanged(object sender, EventArgs e) {

        //    textBox256.Text = tLayPan[0].Controls["textBox" + 2].Text; //get the text in "textBox" + # and display it in textbox256
        //}


        //DEBUG button
        private void Button1_Click(object sender, EventArgs e) {
            int[] setArray = getPresets(tBoxArr); //set the indexes. 0 cells are soft, non-0 are solid.
            MessageBox.Show("valAt1: "+getValAt(1)+" valAt6,59: "+getValAt(6,59)+ " tBoxArr[1].Text: "+ tBoxArr[1].Text+" setArray[5]: "+setArray[5], "!!!DEBUG!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning); //DEBUG
            //tBoxArr[1].Text = "119";
        }

        //Method to save 'solid' indexes that cannot be changed
        public int[] getPresets(TextBox[] inBox) {
            int[] setValArray = new int[81];
            for(int i = 0; i<81; i++) {
                if (inBox[i].Text != "0") {
                    setValArray[i] = i; //Save index as a 'solid' index; SetValArray will have indexes that need to be checked.
                    tBoxArr[i].ReadOnly = true; // do not allow front-end modifications
                }
                else { setValArray[i] = -1; } //If value is zero (default) mark this as 'soft' index
                pBar1.PerformStep();
            }
            return setValArray; //return array with 'solid' and 'soft' indexes
        }//eo getPresets

        //Stores how many cells are used
        public int size() {
            return (tLayPan[0].ColumnCount) * (tLayPan[0].RowCount);
        }


        public void initElements() {
            //Generate textBoxes
            for (int i = 0; i < 81; i++) {
                tBoxArr[i] = new TextBox { Name = "textBox" + i, Text = "0", TabIndex = i, Size = new System.Drawing.Size(20, 20) }; //Create textboxes with init val of 0
                Console.WriteLine("Textbox: " + tBoxArr[i].Name + "; TabIndex: " + tBoxArr[i].TabIndex); //DEBUG
            }

            //Generate layoutPanels
            for (int i = 0; i < 9; i++) {
                tLayPan[i] = new TableLayoutPanel {
                    Name = "tableLayoutPanel" + i,
                    ColumnCount = 3,
                    RowCount = 3,
                    Size = new System.Drawing.Size(123, 80),  //Add(new System.Windows.Forms.RowStyle())
                };
            }
        }

        //Insurance code;; Set the values in the text boxes to their number from 0 to 80.
        //Its done this way so that we don't have to have a manual init every time a box is added.
        //This will count how many boxes there are and init them all
        // This will throw a false object exception if it cannot find the textBox#, so watch what # is and that a text box # exists.
        public void setVals() {

            int cellCount = 0; // Panel cell count. Total of 81 cellCount MAX value is 80
            int x = 0, y = 0; // cell tupal coordinates (x,y)

            //Populate LayoutPanels with textBoxes
            for (int panelCount = 0; panelCount < 9; panelCount++) {

                while ((cellCount % 9) != 8) { // while its one LayoutPanel, populate it with cells.
                    this.tLayPan[panelCount].Controls.Add(tBoxArr[cellCount], x, y); // Add textBox #cellCount to position x,y

                    // go through the panelLayout coordinates x,y
                    //0,0 ; 1,0 ; 2,0 ;
                    //0,1 ; 1,1 ; 2,1 ;
                    //0,2 ; 1,2 ; 2,2 ;
                    if (x == 2) { x = 0; y++; } else { x++; } // if we are at x2 then this is the last line

                    tBoxArr[cellCount].Text = "0"; //Set all cells equal zero
                    cellCount++;
                }

                this.tLayPan[panelCount].Controls.Add(tBoxArr[cellCount], x, y); //set the last cell at 2,2; then reset x and y
                tBoxArr[cellCount].Text = "0"; //Set all cells equal zero
                cellCount++;
                x = 0;
                y = 0;
                //panelCount will increase by 1 now.
            }
            //now we have 9 panels with 9 cells in each. Time to draw them

            //Panel coordinates have x,y coordinates.
            //x=55,185,315 (+130)
            //y=35,125,215 (+90)
            int p_x = 55; // the x coordinate
            int p_y = 35; // the y coordinate
            for (int i = 0; i < 9; i++) {
                this.tLayPan[i].Location = new System.Drawing.Point(p_x, p_y);
                this.Controls.Add(this.tLayPan[i]);
                p_x += 130; // go to next X
                if ((i % 3) > 1) { p_y += 90; p_x = 55; } //See if its time to go to a new line. increase y, reset x.
            }
        }

        //Get value at index x,y
        //X starts at 0, ends at 8.
        //Y starts at 0, ends at 80
        public int getValAt(int x, int y) {

            int val = 0;
            try { val = Int32.Parse(tLayPan[x].Controls["textBox" + y].Text); } catch { return 0; }
            return val;
        }

        //Get value from textBox cell; No need to match panel and its textBoxes
        // cell starts at 0 ends at 80
        public int getValAt(int cell) {
            int val = 0;
            //int index = 
            //String number = tBoxArr[cell].Text;
            //bool success = false;
            //if ( (Int32.Parse(this.Controls["textBox" + cell].Text).GetType().Equals(Int32.)) ) { return 0; }
            //success = Int32.TryParse(number, out val);
            //if (success) { val = Int32.Parse(this.Controls["textBox" + cell].Text); } else { return 0; }

            try { val = Int32.Parse(tBoxArr[cell].Text); } catch { return 0; }
            return val;
        }

     }//eo class
}//eo namespace
