namespace CalculatorApp
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
            this.display = new System.Windows.Forms.TableLayoutPanel();
            this.displayText = new System.Windows.Forms.TextBox();
            this.numberPanel = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.posNeg = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.dec = new System.Windows.Forms.Button();
            this.operationsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.mult = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.display.SuspendLayout();
            this.numberPanel.SuspendLayout();
            this.operationsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.ColumnCount = 1;
            this.display.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.display.Controls.Add(this.displayText, 0, 0);
            this.display.Dock = System.Windows.Forms.DockStyle.Top;
            this.display.Location = new System.Drawing.Point(0, 0);
            this.display.Name = "display";
            this.display.RowCount = 1;
            this.display.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.display.Size = new System.Drawing.Size(569, 100);
            this.display.TabIndex = 0;
            // 
            // displayText
            // 
            this.displayText.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.displayText.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayText.HideSelection = false;
            this.displayText.Location = new System.Drawing.Point(3, 3);
            this.displayText.MaxLength = 9;
            this.displayText.Multiline = true;
            this.displayText.Name = "displayText";
            this.displayText.ReadOnly = true;
            this.displayText.Size = new System.Drawing.Size(563, 94);
            this.displayText.TabIndex = 0;
            this.displayText.TabStop = false;
            this.displayText.Text = "0";
            this.displayText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numberPanel
            // 
            this.numberPanel.ColumnCount = 3;
            this.numberPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.numberPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.numberPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.numberPanel.Controls.Add(this.button1, 0, 2);
            this.numberPanel.Controls.Add(this.button3, 2, 2);
            this.numberPanel.Controls.Add(this.button2, 1, 2);
            this.numberPanel.Controls.Add(this.button4, 0, 1);
            this.numberPanel.Controls.Add(this.button5, 1, 1);
            this.numberPanel.Controls.Add(this.button6, 2, 1);
            this.numberPanel.Controls.Add(this.button7, 0, 0);
            this.numberPanel.Controls.Add(this.button8, 1, 0);
            this.numberPanel.Controls.Add(this.button9, 2, 0);
            this.numberPanel.Controls.Add(this.posNeg, 0, 3);
            this.numberPanel.Controls.Add(this.button0, 1, 3);
            this.numberPanel.Controls.Add(this.dec, 2, 3);
            this.numberPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.numberPanel.Location = new System.Drawing.Point(0, 100);
            this.numberPanel.Name = "numberPanel";
            this.numberPanel.RowCount = 4;
            this.numberPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.numberPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.numberPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.numberPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.numberPanel.Size = new System.Drawing.Size(428, 531);
            this.numberPanel.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 126);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(287, 267);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 126);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(145, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 126);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(3, 135);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 126);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(145, 135);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(136, 126);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(287, 135);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(138, 126);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(3, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(136, 126);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(145, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(136, 126);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(287, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(138, 126);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // posNeg
            // 
            this.posNeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posNeg.Location = new System.Drawing.Point(3, 399);
            this.posNeg.Name = "posNeg";
            this.posNeg.Size = new System.Drawing.Size(136, 129);
            this.posNeg.TabIndex = 9;
            this.posNeg.Text = "+/-";
            this.posNeg.UseVisualStyleBackColor = true;
            this.posNeg.Click += new System.EventHandler(this.posNeg_Click);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(145, 399);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(136, 129);
            this.button0.TabIndex = 10;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.Button0_Click);
            // 
            // dec
            // 
            this.dec.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dec.Location = new System.Drawing.Point(287, 399);
            this.dec.Name = "dec";
            this.dec.Size = new System.Drawing.Size(138, 129);
            this.dec.TabIndex = 11;
            this.dec.Text = ".";
            this.dec.UseVisualStyleBackColor = true;
            this.dec.Click += new System.EventHandler(this.dec_Click);
            // 
            // operationsPanel
            // 
            this.operationsPanel.ColumnCount = 1;
            this.operationsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.operationsPanel.Controls.Add(this.mult, 0, 3);
            this.operationsPanel.Controls.Add(this.add, 0, 5);
            this.operationsPanel.Controls.Add(this.subtract, 0, 4);
            this.operationsPanel.Controls.Add(this.divide, 0, 2);
            this.operationsPanel.Controls.Add(this.del, 0, 1);
            this.operationsPanel.Controls.Add(this.clear, 0, 0);
            this.operationsPanel.Controls.Add(this.equals, 0, 6);
            this.operationsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.operationsPanel.Location = new System.Drawing.Point(434, 100);
            this.operationsPanel.Name = "operationsPanel";
            this.operationsPanel.RowCount = 7;
            this.operationsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.operationsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.operationsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.operationsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.operationsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.operationsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.operationsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.operationsPanel.Size = new System.Drawing.Size(135, 531);
            this.operationsPanel.TabIndex = 2;
            // 
            // mult
            // 
            this.mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mult.Location = new System.Drawing.Point(3, 228);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(129, 69);
            this.mult.TabIndex = 2;
            this.mult.Text = "*";
            this.mult.UseVisualStyleBackColor = true;
            this.mult.Click += new System.EventHandler(this.Mult_Click);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(3, 378);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(129, 69);
            this.add.TabIndex = 0;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.Add_Click);
            // 
            // subtract
            // 
            this.subtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtract.Location = new System.Drawing.Point(3, 303);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(129, 69);
            this.subtract.TabIndex = 1;
            this.subtract.Text = "-";
            this.subtract.UseVisualStyleBackColor = true;
            this.subtract.Click += new System.EventHandler(this.Subtract_Click);
            // 
            // divide
            // 
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.Location = new System.Drawing.Point(3, 153);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(129, 69);
            this.divide.TabIndex = 3;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // del
            // 
            this.del.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del.Location = new System.Drawing.Point(3, 78);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(129, 69);
            this.del.TabIndex = 5;
            this.del.Text = "DEL";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.Del_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(3, 3);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(129, 69);
            this.clear.TabIndex = 6;
            this.clear.Text = "CLR";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // equals
            // 
            this.equals.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equals.Location = new System.Drawing.Point(3, 453);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(129, 75);
            this.equals.TabIndex = 4;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = true;
            this.equals.Click += new System.EventHandler(this.Equals_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 631);
            this.Controls.Add(this.operationsPanel);
            this.Controls.Add(this.numberPanel);
            this.Controls.Add(this.display);
            this.Name = "Form1";
            this.Text = "Form1";
            this.display.ResumeLayout(false);
            this.display.PerformLayout();
            this.numberPanel.ResumeLayout(false);
            this.operationsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel display;
        private System.Windows.Forms.TableLayoutPanel numberPanel;
        private System.Windows.Forms.TextBox displayText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TableLayoutPanel operationsPanel;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button posNeg;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button dec;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button clear;
    }
}

