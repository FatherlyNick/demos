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
        }
        public int[] setValArray = new int[81]; //setValArray will store the indexes of the 'hard-coded' values; -1 means its a soft index and can be modified

        //private void TextBox1_TextChanged(object sender, EventArgs e) {

        //    textBox256.Text = tLayPan[0].Controls["textBox" + 2].Text; //get the text in "textBox" + # and display it in textbox256
        //}


        //DEBUG button
        private void Button1_Click(object sender, EventArgs e) {
            setValArray = getPresets(tBoxArr); //set the indexes. 0 cells are soft, non-0 are solid.
            //execute solving here on setArray
            MessageBox.Show("valAt1: " + getValAt(1) + " valAt6,59: " + getValAt(6) + " tBoxArr[1].Text: " + tBoxArr[1].Text + " setArray[5]: " + setValArray[5], "!!!DEBUG!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning); //DEBUG
            
        }

        //Method to save 'solid' indexes that cannot be changed
        public int[] getPresets(TextBox[] inBox) {
           // int[] setValArray = new int[81];
            for (int i = 0; i < 81; i++) {
                if (inBox[i].Text != "0") {
                    setValArray[i] = i; //Save index as a 'solid' index; SetValArray will have indexes that need to be checked.
                    tBoxArr[i].ReadOnly = true; // do not allow front-end modifications
                }
                //else { setValArray[i] = -1; tBoxArr[i].Text = ""+((i % 9)+1); } //If value is zero (default) mark this as 'soft' index and populate cell with its number
                pBar1.PerformStep();
                Console.WriteLine("setValArray["+i+"]: "+setValArray[i]);
            }
            return setValArray; //return array with 'solid' and 'soft' indexes
        }//eo getPresets

        
        public void initElements() {
            //Point Location = new System.Drawing.Point();
            //Generate textBoxes
            int x = 0, y = 0, increment = 22, sVal = 2, factor = 27;
            for (int i = 0; i < 81; i++) {
                tBoxArr[i] = new TextBox { Name = "textBox" + i, Text = ""+i, TabIndex = i, Size = new System.Drawing.Size(20, 20) }; //Create textboxes with init val of 0
                tBoxArr[i].Location = new Point(x,y);
                this.Controls.Add(tBoxArr[i]);
                
                Console.WriteLine("Textbox: " + tBoxArr[i].Name + "; TabIndex: " + " Location: " + (tBoxArr[i]).Location); //DEBUG
                //Three cases - we reached end of our 3 cells, we reached end of a cell or we reached end of cell line.
                if ((i + 1) % factor == 0)
                { Console.WriteLine("Reached End of major line. reset x, set y"); x = 0; y += increment+10; factor += 27; } //reached end of major line, need to increase x, reset y
                
                else if ((i + 1) % 9 == 0)
                { Console.WriteLine("Reached End of cell. Increase x, set y"); x += increment+10; y = y - (increment * 2); } //reached end of major line, need to increase x, reset y

                else if ((i + 1) % 3 == 0) 
                { Console.WriteLine("Reached End of minor line. Increase y, reset x"); x = x - (increment * 2); y += increment; }//reached end of minor line, need to reset x, increase y
                
                else { x += increment; } //else, keep going on x.
            }

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

        public void solve(int [] inputArray) {
            //go through the 
            for (int i = inputArray.Length; i > 0; i--) {
             /* 
                 
             1) start at index 0;
             2) if index 0 is a -1 flag, we can modify it. Else, move to next index
             3) 

            first, we need to fix conflicts with the hard-coded numbers in all panels


             
             
             */
            }


        }

    }//eo class
}//eo namespace
