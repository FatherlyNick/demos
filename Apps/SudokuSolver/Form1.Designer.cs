using System;
using System.Reflection;
using System.Windows.Forms;

namespace SudokuSolver {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region varDefs
        private TextBox[] tBoxArr = new TextBox[81]; //create an 81 cell int array
        //private TableLayoutPanel[] tLayPan = new TableLayoutPanel[9]; //Array of 9 panels. Each panel has 9 cells
        private Button button1;
        //private TextBox textBox1;
        private TextBox textBox256; //DEBUG
        private ProgressBar pBar1; //Loading
        #endregion

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.textBox256 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // textBox256
            // 
            this.textBox256.Location = new System.Drawing.Point(93, 345);
            this.textBox256.Name = "textBox256";
            this.textBox256.Size = new System.Drawing.Size(100, 20);
            this.textBox256.TabIndex = 256;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 255;
            this.button1.Text = "DEBUG";
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pBar1
            // 
            this.pBar1.Location = new System.Drawing.Point(199, 345);
            this.pBar1.Maximum = 81;
            this.pBar1.Name = "pBar1";
            this.pBar1.Size = new System.Drawing.Size(100, 23);
            this.pBar1.Step = 1;
            this.pBar1.TabIndex = 257;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(460, 380);
            this.Controls.Add(this.pBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox256);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SudokuSolver 0.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
    }//eo class
    
} //eo namespace