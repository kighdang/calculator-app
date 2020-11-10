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
        double mem = 0;
        int divisor = 1;
        String input = "0";
        String lastOp = "NO_OP";


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
            lastOp = "ADDITION";

            if (input != "0")
            {
                // send input to memory if empty
                if (mem == 0)
                    mem = Double.Parse(input);

                // otherwise add input and mem
                else
                    mem += Double.Parse(input);

                displayText.Text = mem.ToString();

                // reset input 
                input = "0";
            }

        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            lastOp = "SUBTRACTION";
            if (input != "0")
            {
                // send input to memory if empty
                if (mem == 0)
                    mem = Double.Parse(input);

                // otherwise subtract input and mem
                else
                    mem -= Double.Parse(input);

                displayText.Text = mem.ToString();

                // reset input 
                input = "0";
            }
        }

        private void Mult_Click(object sender, EventArgs e)
        {
            lastOp = "MULTIPLICATION";
            if (input != "0")
            {
                // send input to memory if empty
                if (mem == 0)
                    mem = Double.Parse(input);

                // otherwise multiply input and mem
                else
                    mem *= Double.Parse(input);

                displayText.Text = mem.ToString();

                // reset input 
                input = "0";
            }
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            lastOp = "DIVISION";

            if (input != "0")
            {
                // send input to memory if empty
                if (mem == 0)
                    mem = Double.Parse(input);

                // otherwise multiply input and mem
                else
                {
                    if (Double.Parse(input) == 0.0)
                        displayText.Text = "DIV BY 0";
                    else
                    {
                        mem /= Double.Parse(input);
                    }

                }
                displayText.Text = mem.ToString();

                // reset input 
                input = "0";
            }
        }



     


        private void Equals_Click(object sender, EventArgs e)
        {
            // do last op
            switch (lastOp)
            {
                case "ADDITION": Add_Click(sender, e);
                    break;
                case "SUBTRACTION":
                    Subtract_Click(sender, e);
                    break;
                case "MULTIPLICATION":
                    Mult_Click(sender, e);
                    break;
                case "DIVISION":
                    Divide_Click(sender, e);
                    break;

            }
            displayText.Text = mem.ToString();
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
                if (input.Length == 0 || input == "-")
                    input = "0";

                displayText.Text = input;
            }
        }
        
        private void posNeg_Click(object sender, EventArgs e)
        {
            // get input
            input = displayText.Text;

            if (input != "0")
            {
                double i = Double.Parse(input);
                i = i * -1;
                input = i.ToString();
                mem = i;
                displayText.Text = i.ToString();
                input = "0";
            }


        }

        private void dec_Click(object sender, EventArgs e)
        {
            if (!input.Contains("."))
            {
                input = input + ".";
            }
        }
    }
}
