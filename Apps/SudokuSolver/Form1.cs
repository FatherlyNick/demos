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
            InitElements();//Create panels and textboxes
        }
        public int[] setValArray = new int[81]; //setValArray will store the indexes of the 'hard-coded' values; -1 means its a soft index and can be modified

        //DEBUG button
        private void Button1_Click(object sender, EventArgs e) {
            setValArray = GetPresets(tBoxArr); //set the indexes. 0 cells are soft, non-0 are solid.
            //execute solving here on setArray
            MessageBox.Show("valAt1: " + GetValAt(1) + " valAt6: " + GetValAt(6) + " tBoxArr[6].Text: " + tBoxArr[6].Text + "; set indexes are: " + setValArray, "!!!DEBUG!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning); //DEBUG
        }

        private void Button2_Click(object sender, EventArgs e) {
            Solve(tBoxArr, setValArray);
        }

        //Method to save 'solid' indexes that cannot be changed
        public int[] GetPresets(TextBox[] inBox) {
            for (int i = 0; i < 81; i++) {
                if (inBox[i].Text != "0") {
                    setValArray[i] = i; //Save index as a 'solid' index; SetValArray will have indexes that need to be checked.
                    tBoxArr[i].ReadOnly = true; // do not allow front-end modifications
                    Console.WriteLine("Solid index at: [" + i + "]: " + GetValAt(i));
                }
                pBar1.PerformStep();
                
            }
            return setValArray; //return array with 'solid' and 'soft' indexes
        }//eo getPresets

        
        public void InitElements() {
            //Point Location = new System.Drawing.Point();
            //Generate textBoxes
            int x = 0, y = 0, increment = 22, factor = 27;
            for (int i = 0; i < 81; i++) {
                tBoxArr[i] = new TextBox { Name = "textBox" + i, Text = ""+i, TabIndex = i, Size = new System.Drawing.Size(20, 20) }; //Create textboxes with init val of 0
                tBoxArr[i].Location = new Point(x,y);
                this.Controls.Add(tBoxArr[i]);
                
                Console.WriteLine("Textbox: " + tBoxArr[i].Name + "; Value: "+tBoxArr[i]+"; TabIndex: " + " Location: " + (tBoxArr[i]).Location); //DEBUG
                //Three cases - we reached end of our 3 cells, we reached end of a cell or we reached end of cell line.
                if ((i + 1) % factor == 0)
                { Console.WriteLine("Reached End of major line. reset x, set y"); x = 0; y += increment+10; factor += 27; } //reached end of major line, need to increase x, reset y
                
                else if ((i + 1) % 9 == 0)
                { Console.WriteLine("Reached End of cell. Increase x, set y"); x += increment+10; y -= (increment * 2); } //reached end of major line, need to increase x, reset y

                else if ((i + 1) % 3 == 0) 
                { Console.WriteLine("Reached End of minor line. Increase y, reset x"); x -= (increment * 2); y += increment; }//reached end of minor line, need to reset x, increase y
                
                else { x += increment; } //else, keep going on x.
            }

        }


        //Get value from textBox cell; No need to match panel and its textBoxes
        // cell starts at 0 ends at 80
        public int GetValAt(int cell) {
            //int val;
            try { return Int32.Parse(tBoxArr[cell].Text); } catch(Exception e) { Console.Write(e); return 0; }
            //return val;
        }

        public void Solve(TextBox [] inputArray, int [] solidArray) {

            bool solved = false;
            int i = 0;
            while (!solved) {

                for (; i <= 3; i++) {
                    System.Console.WriteLine("*******************\n");
                    System.Console.WriteLine("["+inputArray[0].Text+","+inputArray[1].Text + "," + inputArray[2].Text + "]\n");
                    System.Console.WriteLine("[" + countArray[1] + "," + countArray[2] + "," + countArray[3] + "]\n");
                    System.Console.WriteLine("*******************\n");
                    countArray[GetValAt(i)]++;//count the numbers

                }
                solved = true;
            }
                //solved = true;
            //go through the array
        }//eoSolve

        
    }//eo class
}//eo namespace
