namespace Lab1_simpleCalculator
{
    partial class SimpleCalculator
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
            this.buttonZero = new System.Windows.Forms.Button();
            this.textBox_number = new System.Windows.Forms.TextBox();
            this.buttonOn = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.buttonSign = new System.Windows.Forms.Button();
            this.buttonThree = new System.Windows.Forms.Button();
            this.buttonTwo = new System.Windows.Forms.Button();
            this.buttonOne = new System.Windows.Forms.Button();
            this.buttonNine = new System.Windows.Forms.Button();
            this.buttonEight = new System.Windows.Forms.Button();
            this.buttonSeven = new System.Windows.Forms.Button();
            this.buttonSix = new System.Windows.Forms.Button();
            this.buttonFive = new System.Windows.Forms.Button();
            this.buttonFour = new System.Windows.Forms.Button();
            this.panelNumbers = new System.Windows.Forms.Panel();
            this.module = new System.Windows.Forms.Button();
            this.buttonSQRT = new System.Windows.Forms.Button();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.buttonBackSpc = new System.Windows.Forms.Button();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.squared = new System.Windows.Forms.Button();
            this.buttonDivideX = new System.Windows.Forms.Button();
            this.buttonMulti = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.textBox_memory = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelNumbers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonZero
            // 
            this.buttonZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZero.Location = new System.Drawing.Point(23, 285);
            this.buttonZero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.Size = new System.Drawing.Size(79, 53);
            this.buttonZero.TabIndex = 0;
            this.buttonZero.Text = "0";
            this.buttonZero.UseVisualStyleBackColor = true;
            this.buttonZero.Click += new System.EventHandler(this.buttonZero_Click);
            // 
            // textBox_number
            // 
            this.textBox_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_number.Location = new System.Drawing.Point(48, 98);
            this.textBox_number.Name = "textBox_number";
            this.textBox_number.ReadOnly = true;
            this.textBox_number.Size = new System.Drawing.Size(696, 44);
            this.textBox_number.TabIndex = 2;
            this.textBox_number.Text = "0";
            this.textBox_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonOn
            // 
            this.buttonOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOn.Location = new System.Drawing.Point(48, 182);
            this.buttonOn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOn.Name = "buttonOn";
            this.buttonOn.Size = new System.Drawing.Size(111, 53);
            this.buttonOn.TabIndex = 3;
            this.buttonOn.Text = "OFF";
            this.buttonOn.UseVisualStyleBackColor = true;
            this.buttonOn.Click += new System.EventHandler(this.buttonOn_Click);
            // 
            // buttonDot
            // 
            this.buttonDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDot.Location = new System.Drawing.Point(129, 285);
            this.buttonDot.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(79, 53);
            this.buttonDot.TabIndex = 4;
            this.buttonDot.Text = ".";
            this.buttonDot.UseVisualStyleBackColor = true;
            this.buttonDot.Click += new System.EventHandler(this.buttonDot_Click);
            // 
            // buttonSign
            // 
            this.buttonSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSign.Location = new System.Drawing.Point(239, 285);
            this.buttonSign.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSign.Name = "buttonSign";
            this.buttonSign.Size = new System.Drawing.Size(79, 53);
            this.buttonSign.TabIndex = 5;
            this.buttonSign.Text = "+/-";
            this.buttonSign.UseVisualStyleBackColor = true;
            this.buttonSign.Click += new System.EventHandler(this.buttonSign_Click);
            // 
            // buttonThree
            // 
            this.buttonThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThree.Location = new System.Drawing.Point(239, 195);
            this.buttonThree.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonThree.Name = "buttonThree";
            this.buttonThree.Size = new System.Drawing.Size(79, 53);
            this.buttonThree.TabIndex = 8;
            this.buttonThree.Text = "3";
            this.buttonThree.UseVisualStyleBackColor = true;
            this.buttonThree.Click += new System.EventHandler(this.buttonThree_Click);
            // 
            // buttonTwo
            // 
            this.buttonTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTwo.Location = new System.Drawing.Point(129, 195);
            this.buttonTwo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonTwo.Name = "buttonTwo";
            this.buttonTwo.Size = new System.Drawing.Size(79, 53);
            this.buttonTwo.TabIndex = 7;
            this.buttonTwo.Text = "2";
            this.buttonTwo.UseVisualStyleBackColor = true;
            this.buttonTwo.Click += new System.EventHandler(this.buttonTwo_Click);
            // 
            // buttonOne
            // 
            this.buttonOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOne.Location = new System.Drawing.Point(23, 195);
            this.buttonOne.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(79, 53);
            this.buttonOne.TabIndex = 6;
            this.buttonOne.Text = "1";
            this.buttonOne.UseVisualStyleBackColor = true;
            this.buttonOne.Click += new System.EventHandler(this.buttonOne_Click);
            // 
            // buttonNine
            // 
            this.buttonNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNine.Location = new System.Drawing.Point(239, 16);
            this.buttonNine.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonNine.Name = "buttonNine";
            this.buttonNine.Size = new System.Drawing.Size(79, 53);
            this.buttonNine.TabIndex = 14;
            this.buttonNine.Text = "9";
            this.buttonNine.UseVisualStyleBackColor = true;
            this.buttonNine.Click += new System.EventHandler(this.buttonNine_Click);
            // 
            // buttonEight
            // 
            this.buttonEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEight.Location = new System.Drawing.Point(129, 16);
            this.buttonEight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEight.Name = "buttonEight";
            this.buttonEight.Size = new System.Drawing.Size(79, 53);
            this.buttonEight.TabIndex = 13;
            this.buttonEight.Text = "8";
            this.buttonEight.UseVisualStyleBackColor = true;
            this.buttonEight.Click += new System.EventHandler(this.buttonEight_Click);
            // 
            // buttonSeven
            // 
            this.buttonSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSeven.Location = new System.Drawing.Point(23, 16);
            this.buttonSeven.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSeven.Name = "buttonSeven";
            this.buttonSeven.Size = new System.Drawing.Size(79, 53);
            this.buttonSeven.TabIndex = 12;
            this.buttonSeven.Text = "7";
            this.buttonSeven.UseVisualStyleBackColor = true;
            this.buttonSeven.Click += new System.EventHandler(this.buttonSeven_Click);
            // 
            // buttonSix
            // 
            this.buttonSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSix.Location = new System.Drawing.Point(239, 106);
            this.buttonSix.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSix.Name = "buttonSix";
            this.buttonSix.Size = new System.Drawing.Size(79, 53);
            this.buttonSix.TabIndex = 11;
            this.buttonSix.Text = "6";
            this.buttonSix.UseVisualStyleBackColor = true;
            this.buttonSix.Click += new System.EventHandler(this.buttonSix_Click);
            // 
            // buttonFive
            // 
            this.buttonFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFive.Location = new System.Drawing.Point(129, 106);
            this.buttonFive.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonFive.Name = "buttonFive";
            this.buttonFive.Size = new System.Drawing.Size(79, 53);
            this.buttonFive.TabIndex = 10;
            this.buttonFive.Text = "5";
            this.buttonFive.UseVisualStyleBackColor = true;
            this.buttonFive.Click += new System.EventHandler(this.buttonFive_Click);
            // 
            // buttonFour
            // 
            this.buttonFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFour.Location = new System.Drawing.Point(23, 106);
            this.buttonFour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonFour.Name = "buttonFour";
            this.buttonFour.Size = new System.Drawing.Size(79, 53);
            this.buttonFour.TabIndex = 9;
            this.buttonFour.Text = "4";
            this.buttonFour.UseVisualStyleBackColor = true;
            this.buttonFour.Click += new System.EventHandler(this.buttonFour_Click);
            // 
            // panelNumbers
            // 
            this.panelNumbers.Controls.Add(this.module);
            this.panelNumbers.Controls.Add(this.buttonSQRT);
            this.panelNumbers.Controls.Add(this.buttonEquals);
            this.panelNumbers.Controls.Add(this.buttonBackSpc);
            this.panelNumbers.Controls.Add(this.buttonClearAll);
            this.panelNumbers.Controls.Add(this.buttonClear);
            this.panelNumbers.Controls.Add(this.squared);
            this.panelNumbers.Controls.Add(this.buttonDivideX);
            this.panelNumbers.Controls.Add(this.buttonMulti);
            this.panelNumbers.Controls.Add(this.buttonDivide);
            this.panelNumbers.Controls.Add(this.buttonPlus);
            this.panelNumbers.Controls.Add(this.buttonMinus);
            this.panelNumbers.Controls.Add(this.buttonThree);
            this.panelNumbers.Controls.Add(this.buttonSign);
            this.panelNumbers.Controls.Add(this.buttonNine);
            this.panelNumbers.Controls.Add(this.buttonFour);
            this.panelNumbers.Controls.Add(this.buttonZero);
            this.panelNumbers.Controls.Add(this.buttonTwo);
            this.panelNumbers.Controls.Add(this.buttonEight);
            this.panelNumbers.Controls.Add(this.buttonFive);
            this.panelNumbers.Controls.Add(this.buttonDot);
            this.panelNumbers.Controls.Add(this.buttonOne);
            this.panelNumbers.Controls.Add(this.buttonSeven);
            this.panelNumbers.Controls.Add(this.buttonSix);
            this.panelNumbers.Location = new System.Drawing.Point(23, 254);
            this.panelNumbers.Name = "panelNumbers";
            this.panelNumbers.Size = new System.Drawing.Size(720, 367);
            this.panelNumbers.TabIndex = 15;
            this.panelNumbers.Visible = false;
            // 
            // module
            // 
            this.module.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.module.Location = new System.Drawing.Point(511, 106);
            this.module.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.module.Name = "module";
            this.module.Size = new System.Drawing.Size(79, 53);
            this.module.TabIndex = 28;
            this.module.Text = "%";
            this.module.UseVisualStyleBackColor = true;
            this.module.Click += new System.EventHandler(this.module_Click);
            // 
            // buttonSQRT
            // 
            this.buttonSQRT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSQRT.Location = new System.Drawing.Point(511, 16);
            this.buttonSQRT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSQRT.Name = "buttonSQRT";
            this.buttonSQRT.Size = new System.Drawing.Size(79, 53);
            this.buttonSQRT.TabIndex = 27;
            this.buttonSQRT.Text = "sqrt";
            this.buttonSQRT.UseVisualStyleBackColor = true;
            this.buttonSQRT.Click += new System.EventHandler(this.buttonSQRT_Click);
            // 
            // buttonEquals
            // 
            this.buttonEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEquals.Location = new System.Drawing.Point(639, 285);
            this.buttonEquals.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(79, 53);
            this.buttonEquals.TabIndex = 26;
            this.buttonEquals.Text = "=";
            this.buttonEquals.UseVisualStyleBackColor = true;
            this.buttonEquals.Click += new System.EventHandler(this.buttonEquals_Click);
            // 
            // buttonBackSpc
            // 
            this.buttonBackSpc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackSpc.ForeColor = System.Drawing.Color.Red;
            this.buttonBackSpc.Location = new System.Drawing.Point(639, 195);
            this.buttonBackSpc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBackSpc.Name = "buttonBackSpc";
            this.buttonBackSpc.Size = new System.Drawing.Size(79, 53);
            this.buttonBackSpc.TabIndex = 25;
            this.buttonBackSpc.Text = "<-";
            this.buttonBackSpc.UseVisualStyleBackColor = true;
            this.buttonBackSpc.Click += new System.EventHandler(this.buttonBackspace_Click);
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearAll.ForeColor = System.Drawing.Color.Red;
            this.buttonClearAll.Location = new System.Drawing.Point(639, 106);
            this.buttonClearAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(79, 53);
            this.buttonClearAll.TabIndex = 24;
            this.buttonClearAll.Text = "C";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            this.buttonClearAll.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.Color.Red;
            this.buttonClear.Location = new System.Drawing.Point(639, 16);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(79, 53);
            this.buttonClear.TabIndex = 23;
            this.buttonClear.Text = "CE";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // squared
            // 
            this.squared.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.squared.Location = new System.Drawing.Point(511, 285);
            this.squared.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.squared.Name = "squared";
            this.squared.Size = new System.Drawing.Size(79, 53);
            this.squared.TabIndex = 22;
            this.squared.Text = "X^2";
            this.squared.UseVisualStyleBackColor = true;
            this.squared.Click += new System.EventHandler(this.squared_Click);
            // 
            // buttonDivideX
            // 
            this.buttonDivideX.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDivideX.Location = new System.Drawing.Point(511, 195);
            this.buttonDivideX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDivideX.Name = "buttonDivideX";
            this.buttonDivideX.Size = new System.Drawing.Size(79, 53);
            this.buttonDivideX.TabIndex = 21;
            this.buttonDivideX.Text = "1/x";
            this.buttonDivideX.UseVisualStyleBackColor = true;
            this.buttonDivideX.Click += new System.EventHandler(this.buttonDivideX_Click);
            // 
            // buttonMulti
            // 
            this.buttonMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMulti.Location = new System.Drawing.Point(418, 195);
            this.buttonMulti.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonMulti.Name = "buttonMulti";
            this.buttonMulti.Size = new System.Drawing.Size(79, 53);
            this.buttonMulti.TabIndex = 16;
            this.buttonMulti.Text = "*";
            this.buttonMulti.UseVisualStyleBackColor = true;
            this.buttonMulti.Click += new System.EventHandler(this.buttonMulti_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDivide.Location = new System.Drawing.Point(418, 285);
            this.buttonDivide.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(79, 53);
            this.buttonDivide.TabIndex = 15;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.buttonDivide_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlus.Location = new System.Drawing.Point(418, 16);
            this.buttonPlus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(79, 53);
            this.buttonPlus.TabIndex = 18;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinus.Location = new System.Drawing.Point(418, 106);
            this.buttonMinus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(79, 53);
            this.buttonMinus.TabIndex = 17;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // textBox_memory
            // 
            this.textBox_memory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_memory.Location = new System.Drawing.Point(48, 26);
            this.textBox_memory.Name = "textBox_memory";
            this.textBox_memory.ReadOnly = true;
            this.textBox_memory.Size = new System.Drawing.Size(696, 44);
            this.textBox_memory.TabIndex = 16;
            this.textBox_memory.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::Lab1_simpleCalculator.Properties.Resources.math;
            this.pictureBox1.Image = global::Lab1_simpleCalculator.Properties.Resources.math2;
            this.pictureBox1.Location = new System.Drawing.Point(308, 666);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Lab1_simpleCalculator.Properties.Resources.math;
            this.pictureBox2.Location = new System.Drawing.Point(308, 666);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(212, 229);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // SimpleCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 925);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_memory);
            this.Controls.Add(this.panelNumbers);
            this.Controls.Add(this.buttonOn);
            this.Controls.Add(this.textBox_number);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SimpleCalculator";
            this.Text = "SimpleCalculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.panelNumbers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonZero;
        private System.Windows.Forms.TextBox textBox_number;
        private System.Windows.Forms.Button buttonOn;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button buttonSign;
        private System.Windows.Forms.Button buttonThree;
        private System.Windows.Forms.Button buttonTwo;
        private System.Windows.Forms.Button buttonOne;
        private System.Windows.Forms.Button buttonNine;
        private System.Windows.Forms.Button buttonEight;
        private System.Windows.Forms.Button buttonSeven;
        private System.Windows.Forms.Button buttonSix;
        private System.Windows.Forms.Button buttonFive;
        private System.Windows.Forms.Button buttonFour;
        private System.Windows.Forms.Panel panelNumbers;
        private System.Windows.Forms.TextBox textBox_memory;
        private System.Windows.Forms.Button buttonMulti;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonEquals;
        private System.Windows.Forms.Button buttonBackSpc;
        private System.Windows.Forms.Button buttonClearAll;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button squared;
        private System.Windows.Forms.Button buttonDivideX;
        private System.Windows.Forms.Button module;
        private System.Windows.Forms.Button buttonSQRT;
    }
}

