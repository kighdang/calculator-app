using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CalculatorApp

{

    public partial class Form1 : Form
    {
        int mem = 0;
        String input = "0";
        String operation = "NO_OP";


        public Form1()
        {
            InitializeComponent();
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            // Control length of number
            if (input.Length < 9)
            {
                // append a 0 if input isnt 0 
                if (input != "0")
                    input = input + "0";

             


            }

            displayText.Text = input;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Control length of number
            if (input.Length < 9)
            {
                // no input
                if (input == "0" || input == "") 
                    input = "1";

                // input exists, append a 1 
                else
                    input = input + "1";
            }

            displayText.Text = input;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // Control length of number
            if (input.Length < 9)
            {
                // no input
                if (input == "0" || input == "")
                    input = "2";

                // input exists, append a 2 
                else
                    input = input + "2";
            }

            displayText.Text = input;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            // Control length of number
            if (input.Length < 9)
            {
                // no input
                if (input == "0" || input == "")
                    input = "3";

                // input exists, append a 3 
                else
                    input = input + "3";
            }

            displayText.Text = input;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            // Control length of number
            if (input.Length < 9)
            {
                // no input
                if (input == "0" || input == "")
                    input = "4";

                // input exists, append a 4
                else
                    input = input + "4";
            }

            displayText.Text = input;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            // Control length of number
            if (input.Length < 9)
            {
                // no input
                if (input == "0" || input == "")
                    input = "5";

                // input exists, append a 5
                else
                    input = input + "5";
            }

            displayText.Text = input;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            // Control length of number
            if (input.Length < 9)
            {
                // no input
                if (input == "0" || input == "")
                    input = "6";

                // input exists, append a 6
                else
                    input = input + "6";
            }

            displayText.Text = input;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            // Control length of number
            if (input.Length < 9)
            {
                // no input
                if (input == "0" || input == "")
                    input = "7";

                // input exists, append a 7
                else
                    input = input + "7";
            }

            displayText.Text = input;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            // Control length of number
            if (input.Length < 9)
            {
                // no input
                if (input == "0" || input == "")
                    input = "8";

                // input exists, append a 8
                else
                    input = input + "8";
            }

            displayText.Text = input;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            // Control length of number
            if (input.Length < 9)
            {
                // no input
                if (input == "0" || input == "")
                    input = "9";

                // input exists, append a 9 
                else
                    input = input + "9";
            }

            displayText.Text = input;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            lastOp();
            operation = "ADDITION";
            // send input to mem if nothing in mem
            if (mem == 0)
            {
                mem = Int32.Parse(input);
                input = "";
            }

            

            // 2nd operand exists, perform operation
            if (input != "")
            {
                mem = Int32.Parse(input) + mem;
                displayText.Text = mem.ToString();
                input = "";
            }
            


        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            lastOp();
            operation = "SUBTRACTION";
            // send input to mem if nothing in mem
            if (mem == 0)
            {
                mem = Int32.Parse(input);
                input = "";
            }



            // 2nd operand exists, perform operation
            if (input != "")
            {
                mem = Int32.Parse(input) - mem;
                displayText.Text = mem.ToString();
                input = "";
            }
        }

        private void Mult_Click(object sender, EventArgs e)
        {
            lastOp();
            operation = "MULTIPLICATION";
            
            // send input to mem if nothing in mem
            if (mem == 0)
            {
                mem = Int32.Parse(input);
                input = "";
            }



            // 2nd operand exists, perform operation
            if (input != "")
            {
                mem = Int32.Parse(input) * mem;
                displayText.Text = mem.ToString();
                input = "";
            }
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            lastOp();
            operation = "DIVISION";
            // send input to mem if nothing in mem
            if (mem == 0)
            {
                mem = Int32.Parse(input);
                input = "";
            }



            // 2nd operand exists, perform operation
            if (input != "")
            {
                mem = mem / Int32.Parse(input);
                displayText.Text = mem.ToString();
                input = "";
            }
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            lastOp();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            // Set input text to 0
            input = "0";
            mem = 0;
            displayText.Text = input;

        }

        private void Del_Click(object sender, EventArgs e)
        {
            if(input != "0")
            {
                // Remove last digit from input
                input = input.Substring(0, input.Length - 1);

                // No more characters, set input to 0
                if (input.Length == 0)
                    input = "0";

                displayText.Text = input;
            }
        }

        private void lastOp()
        {
            // perform the last operation if input/mem is valid 
            if (input != "" && mem != 0)
            {
                switch (operation)
                {
                    case "ADDITION":
                        addition();
                        break;

                    case "SUBTRACTION":
                        subtraction();
                        break;

                    case "MULTIPLICATION":
                        multiplication();
                        break;

                    case "DIVISION":
                        division();
                        break;
                }


                displayText.Text = mem.ToString();
            }
        }

        private void addition()
        {
            mem = mem + Int32.Parse(input);
            input = "";
        }

        private void subtraction()
        {
            mem = mem - Int32.Parse(input);
            input = "";
        }

        private void multiplication()
        {
            mem = mem * Int32.Parse(input);
            input = "";
        }

        private void division()
        {
            // div by 0 error
            if (input == "0")
            {
                displayText.Text = "DIV BY 0 ERROR";
                input = "";
                operation = "NO_OP";
                mem = 0;
            }

            mem = mem / Int32.Parse(input);


        }
    }
}
