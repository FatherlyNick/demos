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
        private ProgressBar pBar1; //Loading
        private readonly int[] countArray = new int[4] { 0, 1, 2, 3 };// temp array to be used for solving
        #endregion

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.button1 = new System.Windows.Forms.Button();
            this.pBar1 = new System.Windows.Forms.ProgressBar();
            this.Button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.pBar1.Location = new System.Drawing.Point(93, 345);
            this.pBar1.Maximum = 81;
            this.pBar1.Name = "pBar1";
            this.pBar1.Size = new System.Drawing.Size(100, 23);
            this.pBar1.Step = 1;
            this.pBar1.TabIndex = 257;
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(200, 345);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(75, 23);
            this.Button2.TabIndex = 258;
            this.Button2.Text = "Solve";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            this.Button2.Enabled = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(460, 380);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.pBar1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SudokuSolver 0.2";
            this.ResumeLayout(false);

        }


        #endregion

        private Button Button2;
    }//eo class
    
} //eo namespace