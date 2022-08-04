namespace MyCalc
{
    partial class Form1
    {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnPercent = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnDot, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnZero, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnPercent, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnThree, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnTwo, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnOne, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnEqual, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSix, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnFive, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnFour, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnPlus, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnNine, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnEight, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSeven, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnMinus, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnMultiply, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDivide, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnClear, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(218, 140);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(416, 239);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblDisplay
            // 
            this.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisplay.Location = new System.Drawing.Point(218, 103);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(416, 23);
            this.lblDisplay.TabIndex = 1;
            this.lblDisplay.Click += new System.EventHandler(this.lblDisplay_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(3, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 41);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(107, 3);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(98, 41);
            this.btnDivide.TabIndex = 1;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(211, 3);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(98, 41);
            this.btnMultiply.TabIndex = 2;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(315, 3);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(98, 41);
            this.btnMinus.TabIndex = 3;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.Location = new System.Drawing.Point(3, 50);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(98, 41);
            this.btnSeven.TabIndex = 4;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.btnSeven_Click);
            // 
            // btnEight
            // 
            this.btnEight.Location = new System.Drawing.Point(107, 50);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(98, 41);
            this.btnEight.TabIndex = 5;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.btnEight_Click);
            // 
            // btnNine
            // 
            this.btnNine.Location = new System.Drawing.Point(211, 50);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(98, 41);
            this.btnNine.TabIndex = 6;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.btnNine_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(315, 50);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(98, 41);
            this.btnPlus.TabIndex = 7;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnFour
            // 
            this.btnFour.Location = new System.Drawing.Point(3, 97);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(98, 41);
            this.btnFour.TabIndex = 8;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnFive
            // 
            this.btnFive.Location = new System.Drawing.Point(107, 97);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(98, 41);
            this.btnFive.TabIndex = 9;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnSix
            // 
            this.btnSix.Location = new System.Drawing.Point(211, 97);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(98, 41);
            this.btnSix.TabIndex = 10;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(315, 97);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(98, 41);
            this.btnEqual.TabIndex = 11;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(3, 144);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(98, 41);
            this.btnOne.TabIndex = 12;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(107, 144);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(98, 41);
            this.btnTwo.TabIndex = 13;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnThree
            // 
            this.btnThree.Location = new System.Drawing.Point(211, 144);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(98, 41);
            this.btnThree.TabIndex = 14;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnPercent
            // 
            this.btnPercent.Location = new System.Drawing.Point(3, 191);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(98, 41);
            this.btnPercent.TabIndex = 16;
            this.btnPercent.Text = "%";
            this.btnPercent.UseVisualStyleBackColor = true;
            this.btnPercent.Click += new System.EventHandler(this.btnPercent_Click);
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(107, 191);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(98, 41);
            this.btnZero.TabIndex = 17;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnDot
            // 
            this.btnDot.Location = new System.Drawing.Point(211, 191);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(98, 41);
            this.btnDot.TabIndex = 18;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 450);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnPercent;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblDisplay;
    }
}

